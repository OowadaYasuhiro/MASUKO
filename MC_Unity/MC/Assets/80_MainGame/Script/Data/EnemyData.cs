using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData
{
    //名前
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

    //攻撃力
    public int attackDamage;
    //移動速度
    public int speed;
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

                        break;
                }
                break;
            case (EnemyName.NAMIKINASYOUZYO):
                switch (difficulty)
                {
                    case (StageSelect_Deta.easy):

                        break;
                    case (StageSelect_Deta.normal):

                        break;
                    case (StageSelect_Deta.hard):

                        break;
                }
                break;
            case (EnemyName.KOISURUGYARU):
                switch (difficulty)
                {
                    case (StageSelect_Deta.easy):

                        break;
                    case (StageSelect_Deta.normal):

                        break;
                    case (StageSelect_Deta.hard):

                        break;
                }
                break;
            case (EnemyName.KOWAMOTEYANKI):
                switch (difficulty)
                {
                    case (StageSelect_Deta.easy):

                        break;
                    case (StageSelect_Deta.normal):

                        break;
                    case (StageSelect_Deta.hard):

                        break;
                }
                break;
            case (EnemyName.PIENNNAONNNANOKO):
                switch (difficulty)
                {
                    case (StageSelect_Deta.easy):

                        break;
                    case (StageSelect_Deta.normal):

                        break;
                    case (StageSelect_Deta.hard):

                        break;
                }
                break;
            case (EnemyName.PIEKIN):
                switch (difficulty)
                {
                    case (StageSelect_Deta.easy):

                        break;
                    case (StageSelect_Deta.normal):

                        break;
                    case (StageSelect_Deta.hard):

                        break;
                }
                break;
        }
    }
}
