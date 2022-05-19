using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
<<<<<<< HEAD
using static Constant;
=======
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
using static Constant;
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a

public class DamageModelComponent
{
    //体力
    int hp;
<<<<<<< HEAD
<<<<<<< HEAD
    public int Hp { get {return hp;} private set{; } }
=======
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
    public int Hp { get {return hp;} private set{; } }
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
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
<<<<<<< HEAD
        if (damage.Type == physicsDamage)
=======
        if (damage.Type == Damage.physicsDamage)
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
        if (damage.Type == physicsDamage)
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
        {
            double RPD = 100.0 - (double)physicsDamageResistance / 100.0;
            hp -= (int)((double)damage.value * RPD);
        }
<<<<<<< HEAD
<<<<<<< HEAD
        if (damage.Type == zyuGeki)
=======
        if (damage.Type == Damage.zyuGeki)
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
        if (damage.Type == zyuGeki)
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
        {
            double RPD = 100.0 - (double)zyuGekiResistance / 100.0;
            hp -= (int)((double)damage.value * RPD);
        }
<<<<<<< HEAD
<<<<<<< HEAD
        if (damage.Type == zyuRyoku)
=======
        if (damage.Type == Damage.zyuRyoku)
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
        if (damage.Type == zyuRyoku)
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
        {
            double RPD = 100.0 - (double)zyuRyokuResistance / 100.0;
            hp -= (int)((double)damage.value * RPD);
        }

    }
}
