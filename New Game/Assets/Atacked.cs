using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Atacked : MonoBehaviour {
    private SpriteRenderer Sr;
    public Color AddColorWithClick;
    public Color CurrentAddedColor;
    public Color ClearColor = new Color(1, 1, 1, 1);



    void Start()
    {
        Sr = GetComponent<SpriteRenderer>();
        CurrentAddedColor = ClearColor;
     
    }

    
    public void OnMouseDown()
    {
        CurrentAddedColor = AddColorWithClick;
        Debug.Log("clicked");
    }
    void FixedUpdate()
    {
        CurrentAddedColor = Color.Lerp(CurrentAddedColor, ClearColor , Time.deltaTime*4);
        Sr.color = CurrentAddedColor;
    }
}
