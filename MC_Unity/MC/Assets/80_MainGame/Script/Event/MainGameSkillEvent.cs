using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;

public class MainGameSkillEvent : MonoBehaviour
{
    //対象
    Enemy enemy;

    //何もしない
    public void Null() { }

    //スタン
    public void EnemyStan(Enemy enemy,float time)
    {
        this.enemy = enemy;
        enemy.SetGameEvent += Stan;
        Invoke("ReleaseStun",time);
    }
    void Stan()
    {
        enemy.ChengeEnemyState(Enemystate.Stan);
    }
    void ReleaseStun()
    {
        enemy.ChengeEnemyState(Enemystate.Run);
    }


}
