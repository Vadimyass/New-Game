using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    public float Speed = 5;
    private float MoveInput;
    public float JumpForce = 5;
    private Rigidbody2D rb;
    private bool FacingRight = true;

    private bool IsGrounded;
    public Transform GroundCheck;
    public float CheckRadius = 0.5f;
    public LayerMask WhatIsGround;

    private int ExtraJumps;
    public int ExtraJumpsValue = 0;

    private void Start()
    {
        ExtraJumps = ExtraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        IsGrounded = Physics2D.OverlapCircle(GroundCheck.position, CheckRadius, WhatIsGround); //закинуть обьект GroundCheck, сделать для Terrarin слой Ground и поместить в параметр WhatIsGround
        MoveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(MoveInput * Speed, rb.velocity.y);

        if (FacingRight == false && MoveInput > 0)
        {
            Flip();
        }
        else if (FacingRight == true && MoveInput < 0)
        {
            Flip();
        }
    }
    private void Update()
    {
        if (IsGrounded == true)
        {
            ExtraJumps = ExtraJumpsValue;
        }
        if( Input.GetKeyDown(KeyCode.Space) && ExtraJumps > 0)
        {
            rb.velocity = Vector2.up * JumpForce;
            ExtraJumps--;
        }else if ( Input.GetKeyDown(KeyCode.Space) && ExtraJumps == 0 && IsGrounded == true)
        {
            rb.velocity = Vector2.up * JumpForce;
        }
    }
    void Flip()
    {
        FacingRight = !FacingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }    
}
