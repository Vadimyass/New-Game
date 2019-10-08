using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
public class Block
{
    int id;
    int Hp;
    
    public Block(int Id_block, int Hp_Block){ //констр. 
        this.id = Id_block;
        this.Hp = Hp_Block;
    }
    public int delete(int dmg) //уничтожить блок
    {
        if (Input.GetMouseButtonDown(0))
        {
            return this.Hp -= dmg;
        }
        //Debug.Log(this.Hp);
        return this.Hp;
    }
}