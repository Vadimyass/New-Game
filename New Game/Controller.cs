using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float horirontalSpeed;
    float speedX;
    public float verticalImpulse;
    bool isGrounded;
    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            speedX = -horirontalSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            speedX = horirontalSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0, verticalImpulse), ForceMode2D.Impulse);
        }
        transform.Translate(speedX, 0, 0);
        speedX = 0;    
        //rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 12f, rb.velocity.y);
    }
    
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Ground")
                isGrounded = true;
        }
        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Ground")
                isGrounded = false;
        }
}   
