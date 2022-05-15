using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;

public class EnemyState
{
    public Enemystate state;

    public void CheckState(DamageModelComponent dmc)
    {
        if (dmc.Hp <= 0)
        {
            state = Enemystate.Dead;
        }
    }

}
