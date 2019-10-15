using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class B_D : MonoBehaviour
{
    //Block Dirt_With_Grass = new Block(1, 30);
    Block Dirt = new Block(2, 30);
    //Block Stone = new Block(3, 60);

    public GameObject Ground;
    public GameObject Tree;


    void Start()
    {
        Ground.name = "Ground";
        Tree.name = "Tree";

    }
    void Update()
    {
    }


    public void OnMouseDown()
    {
            if (Dirt.delete(5) <= 0) //уничтожить блок с 5ью урона
            {
                Destroy(gameObject);
            }
            Debug.Log(name);
    }
}
