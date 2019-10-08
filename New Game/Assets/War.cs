using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.EventSystems;



public class Enemy{    //Общий класс для всех будущих классов
    int HP_En;
    int Damage;

    public Enemy(int Hp, int dmg){
        this.HP_En = Hp;
        this.Damage = dmg;
    }

    public bool Dmg(int dmg_player){
        this.HP_En -= dmg_player;
        if(HP_En <= 0)
            return false;
        
        return true;
    } 
}

public class Hero
{
    int Hp_Hero;
    int Eat_Hero;
    int Water_Hero;
    int Stamina_Hero;
   public int Damage_Hero;

    public Hero(int hp, int eat, int water, int stamina, int damage)
    {
        this.Hp_Hero = hp;
        this.Eat_Hero = eat;
        this.Water_Hero = water;
        this.Stamina_Hero = stamina;
        this.Damage_Hero = damage;
    }

    public bool Damag(int dmg_enemy)
    {
        this.Hp_Hero -= dmg_enemy;
        if (Hp_Hero <= 0)
            return false;

        return true;
    }
}

public class War : MonoBehaviour
{
    Enemy Spider = new Enemy(100, 10);
    Hero Warrior = new Hero(100, 100, 100, 100, 15);
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
       
        
    }

    public void OnMouseDown()
    {
        if (Spider.Dmg(Warrior.Damage_Hero) == false)
        {
            Destroy(gameObject);
        }
    }
}
