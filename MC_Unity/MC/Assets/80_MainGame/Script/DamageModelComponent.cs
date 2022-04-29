using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageModelComponent
{
    //体力
    int hp;
    int maxHp;
    //耐性(カット率)
    int physicsDamageResistance;
    int zyuGekiResistance;
    int zyuRyokuResistance;

    public DamageModelComponent(int hp, int maxHp, int physicsDamageResistance, int zyuGekiResistance, int zyuRyokuResistance)
    {
        this.hp = hp;
        this.maxHp = maxHp;
        this.physicsDamageResistance = physicsDamageResistance;
        this.zyuGekiResistance = zyuGekiResistance;
        this.zyuRyokuResistance = zyuRyokuResistance;
    }

    //public void 
}
