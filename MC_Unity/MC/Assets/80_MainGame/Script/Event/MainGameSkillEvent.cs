using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameSkillEvent : Constant
{
    //対象
    Enemy enemy;

    //何もしない
    public void Null() { }

    //スタン
    public void EnemyStan(Enemy enemy)
    {
        this.enemy = enemy;
        enemy.SetGameEvent = Stan;
    }
    void Stan()
    {
        enemy.ChengeEnemyState(Enemystate.Stan);
    }


}
