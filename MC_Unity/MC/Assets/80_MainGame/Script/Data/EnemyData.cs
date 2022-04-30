using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData
{
    public enum EnemyName
    {
        TUYOGARISYOUNEN,
        NAMIKINASYOUZYO,
        KOISURUGYARU,
        KOWAMOTEYANKI,
        PIENNNAONNNANOKO,
        PIEKIN
    }

    EnemyName enemyName;

    public const string easy = "easy";
    public const string normal = "normal";
    public const string hard = "hard";

    int attackDamage;
    int speed;
    Vector2[] attackRange;
    DamageModelComponent enemyDamageModelComponent;

    public EnemyData(EnemyName eName,string difficulty)
    {
        switch (eName)
        {
            case (EnemyName.TUYOGARISYOUNEN):
                switch (difficulty)
                {
                    case(easy):

                        break;
                    case (normal):

                        break;
                    case (hard):

                        break;
                }
                break;
            case (EnemyName.NAMIKINASYOUZYO):
                switch (difficulty)
                {
                    case (easy):

                        break;
                    case (normal):

                        break;
                    case (hard):

                        break;
                }
                break;
            case (EnemyName.KOISURUGYARU):
                switch (difficulty)
                {
                    case (easy):

                        break;
                    case (normal):

                        break;
                    case (hard):

                        break;
                }
                break;
            case (EnemyName.KOWAMOTEYANKI):
                switch (difficulty)
                {
                    case (easy):

                        break;
                    case (normal):

                        break;
                    case (hard):

                        break;
                }
                break;
            case (EnemyName.PIENNNAONNNANOKO):
                switch (difficulty)
                {
                    case (easy):

                        break;
                    case (normal):

                        break;
                    case (hard):

                        break;
                }
                break;
            case (EnemyName.PIEKIN):
                switch (difficulty)
                {
                    case (easy):

                        break;
                    case (normal):

                        break;
                    case (hard):

                        break;
                }
                break;
        }
    }
}
