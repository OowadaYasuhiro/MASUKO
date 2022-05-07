using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Constant
{
    //体力管理
    DamageModelComponent damageModel;

    //基本情報
    EnemyData enemyData;


    public Enemy(EnemyName enemyName,string difficulty)
    {
        enemyData = new EnemyData(enemyName,difficulty);
        damageModel = new DamageModelComponent(enemyData.maxHp,enemyData.physicsDamageResistance,enemyData.zyuGekiResistance,enemyData.zyuRyokuResistance);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
