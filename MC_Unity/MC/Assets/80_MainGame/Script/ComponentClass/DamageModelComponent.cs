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

    //受け取ったダメージから耐性の分引いてhpに適応
    public void AddDamage(Damage damage)
    {
        if (damage.Type == Damage.physicsDamage)
        {
            double RPD = 100.0 - (double)physicsDamageResistance / 100.0;
            hp -= (int)((double)damage.value * RPD);
        }
        if (damage.Type == Damage.zyuGeki)
        {
            double RPD = 100.0 - (double)zyuGekiResistance / 100.0;
            hp -= (int)((double)damage.value * RPD);
        }
        if (damage.Type == Damage.zyuRyoku)
        {
            double RPD = 100.0 - (double)zyuRyokuResistance / 100.0;
            hp -= (int)((double)damage.value * RPD);
        }

    }
}
