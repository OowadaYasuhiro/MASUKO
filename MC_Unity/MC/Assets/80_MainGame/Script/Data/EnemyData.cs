﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using static Constant;
=======
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03

public class EnemyData
{
    //名前
<<<<<<< HEAD
    EnemyName enemyName;

    //時間軸
    public float timeLine;
=======
    public enum EnemyName
    {
        TUYOGARISYOUNEN,
        NAMIKINASYOUZYO,
        KOISURUGYARU,
        KOWAMOTEYANKI,
        PIENNNAONNNANOKO,
        PIEKIN
    }

    public EnemyName enemyName;
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03

    //攻撃力
    public int attackDamage;
    //移動速度
<<<<<<< HEAD
    public float speed;
=======
    public int speed;
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
    //攻撃範囲
    public Vector2[] attackRange;
    //体力
    public int maxHp;
    //耐性(カット率)
    public int physicsDamageResistance;
    public int zyuGekiResistance;
    public int zyuRyokuResistance;

    public EnemyData(EnemyName eName,string difficulty)
    {
        enemyName = eName;
        switch (eName)
        {
            case (EnemyName.TUYOGARISYOUNEN):
<<<<<<< HEAD
                speed = 1;
                attackRange = new Vector2[] {
                    new Vector2(1,0)
                };
                physicsDamageResistance = 0;
                zyuGekiResistance = 0;
                zyuRyokuResistance = 0;
                switch (difficulty)
                {
                    case(easy):
                        attackDamage = 30;
                        maxHp = 1000;
                        break;
                    case (normal):
                        attackDamage = 40;
                        maxHp = 1500;
                        break;
                    case (hard):
                        attackDamage = 50;
                        maxHp = 2000;
=======
                switch (difficulty)
                {
                    case(StageSelect_Deta.easy):
                        attackDamage = 0;
                        speed = 0;
                        attackRange = new Vector2[] {
                            new Vector2(1,0)
                        };
                        maxHp = 0;
                        physicsDamageResistance = 0;
                        zyuGekiResistance = 0;
                        zyuRyokuResistance = 0;
                        break;
                    case (StageSelect_Deta.normal):

                        break;
                    case (StageSelect_Deta.hard):

>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
                        break;
                }
                break;
            case (EnemyName.NAMIKINASYOUZYO):
<<<<<<< HEAD
                speed = 0.8f;
                attackRange = new Vector2[] {
                    new Vector2(1,0),
                    new Vector2(2,0)
                };
                physicsDamageResistance = 10;
                zyuGekiResistance = 10;
                zyuRyokuResistance = 0;
                switch (difficulty)
                {
                    case (easy):
                        attackDamage = 40;
                        maxHp = 1500;
                        break;
                    case (normal):
                        attackDamage = 50;
                        maxHp = 3000;
                        break;
                    case (hard):
                        attackDamage = 60;
                        maxHp = 4000;
=======
                switch (difficulty)
                {
                    case (StageSelect_Deta.easy):

                        break;
                    case (StageSelect_Deta.normal):

                        break;
                    case (StageSelect_Deta.hard):

>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
                        break;
                }
                break;
            case (EnemyName.KOISURUGYARU):
<<<<<<< HEAD
                speed = 2;
                attackRange = new Vector2[] {
                    new Vector2(1,0)
                };
                physicsDamageResistance = 0;
                zyuGekiResistance = 10;
                zyuRyokuResistance = 0;
                switch (difficulty)
                {
                    case (easy):
                        attackDamage = 20;
                        maxHp = 1500;
                        break;
                    case (normal):
                        attackDamage = 30;
                        maxHp = 2000;
                        break;
                    case (hard):
                        attackDamage = 40;
                        maxHp = 3000;
=======
                switch (difficulty)
                {
                    case (StageSelect_Deta.easy):

                        break;
                    case (StageSelect_Deta.normal):

                        break;
                    case (StageSelect_Deta.hard):

>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
                        break;
                }
                break;
            case (EnemyName.KOWAMOTEYANKI):
<<<<<<< HEAD
                speed = 1;
                attackRange = new Vector2[] {
                    new Vector2(1,0)
                };
                physicsDamageResistance = 40;
                zyuGekiResistance = 0;
                zyuRyokuResistance = 0;
                switch (difficulty)
                {
                    case (easy):
                        attackDamage = 10;
                        maxHp = 3000;
                        break;
                    case (normal):
                        attackDamage = 20;
                        maxHp = 4000;
                        break;
                    case (hard):
                        attackDamage = 30;
                        maxHp = 5000;
=======
                switch (difficulty)
                {
                    case (StageSelect_Deta.easy):

                        break;
                    case (StageSelect_Deta.normal):

                        break;
                    case (StageSelect_Deta.hard):

>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
                        break;
                }
                break;
            case (EnemyName.PIENNNAONNNANOKO):
<<<<<<< HEAD
                speed = 0.8f;
                attackRange = new Vector2[] {
                    new Vector2(1,0),
                    new Vector2(2,0),
                    new Vector2(3,0)
                };
                physicsDamageResistance = 0;
                zyuGekiResistance = 0;
                zyuRyokuResistance = 30;
                switch (difficulty)
                {
                    case (easy):
                        attackDamage = 40;
                        maxHp = 4000;
                        break;
                    case (normal):
                        attackDamage = 50;
                        maxHp = 5000;
                        break;
                    case (hard):
                        attackDamage = 60;
                        maxHp = 6000;
=======
                switch (difficulty)
                {
                    case (StageSelect_Deta.easy):

                        break;
                    case (StageSelect_Deta.normal):

                        break;
                    case (StageSelect_Deta.hard):

>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
                        break;
                }
                break;
            case (EnemyName.PIEKIN):
<<<<<<< HEAD
                speed = 1.5f;
                attackRange = new Vector2[] {
                    new Vector2(1,0),
                    new Vector2(2,0)
                };
                physicsDamageResistance = 20;
                zyuGekiResistance = 30;
                zyuRyokuResistance = 0;
                switch (difficulty)
                {
                    case (easy):
                        attackDamage = 50;
                        maxHp = 4000;
                        break;
                    case (normal):
                        attackDamage = 60;
                        maxHp = 5000;
                        break;
                    case (hard):
                        attackDamage = 70;
                        maxHp = 6000;
=======
                switch (difficulty)
                {
                    case (StageSelect_Deta.easy):

                        break;
                    case (StageSelect_Deta.normal):

                        break;
                    case (StageSelect_Deta.hard):

>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
                        break;
                }
                break;
        }
    }
}
