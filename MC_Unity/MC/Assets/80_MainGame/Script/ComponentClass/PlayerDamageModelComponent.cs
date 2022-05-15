using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageModelComponent
{
    //体力
    int hp;
    public int Hp { get { return hp;}private set { ;} }
    int maxHp;
    //防御力
    int defense;
    public PlayerDamageModelComponent(int hp,int def)
    {
        this.hp = hp;
        maxHp = hp;
        defense = def;
    }

    //受け取ったダメージから耐性分引いてhpに適応
    public void AddDamage(Damage damage)
    {
        hp -= (int)((double)damage.value * (((double)defense/20))/100.0);
    }
}
