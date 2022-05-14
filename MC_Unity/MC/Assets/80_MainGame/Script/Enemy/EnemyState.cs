using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : Constant
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
