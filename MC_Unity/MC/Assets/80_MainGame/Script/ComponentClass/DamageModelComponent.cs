using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using static Constant;
=======
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03

public class DamageModelComponent
{
    //体力
    int hp;
<<<<<<< HEAD
    public int Hp { get {return hp;} private set{; } }
=======
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
    int maxHp;
    //耐性(カット率)
    int physicsDamageResistance;
    int zyuGekiResistance;
    int zyuRyokuResistance;

    public DamageModelComponent(int maxHp, int physicsDamageResistance, int zyuGekiResistance, int zyuRyokuResistance)
    {
        hp = maxHp;
        this.maxHp = maxHp;
        this.physicsDamageResistance = physicsDamageResistance;
        this.zyuGekiResistance = zyuGekiResistance;
        this.zyuRyokuResistance = zyuRyokuResistance;
    }

    //受け取ったダメージから耐性の分引いてhpに適応
    public void AddDamage(Damage damage)
    {
<<<<<<< HEAD
        if (damage.Type == physicsDamage)
=======
        if (damage.Type == Damage.physicsDamage)
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
        {
            double RPD = 100.0 - (double)physicsDamageResistance / 100.0;
            hp -= (int)((double)damage.value * RPD);
        }
<<<<<<< HEAD
        if (damage.Type == zyuGeki)
=======
        if (damage.Type == Damage.zyuGeki)
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
        {
            double RPD = 100.0 - (double)zyuGekiResistance / 100.0;
            hp -= (int)((double)damage.value * RPD);
        }
<<<<<<< HEAD
        if (damage.Type == zyuRyoku)
=======
        if (damage.Type == Damage.zyuRyoku)
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
        {
            double RPD = 100.0 - (double)zyuRyokuResistance / 100.0;
            hp -= (int)((double)damage.value * RPD);
        }

    }
}
