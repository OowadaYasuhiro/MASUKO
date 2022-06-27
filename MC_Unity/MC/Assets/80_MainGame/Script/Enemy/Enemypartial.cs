using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;

public partial class Enemy
{
    void Setting(string difficulty)
    {
        switch (Charactername)
        {
            case Tuyogarisyounen:
                moveSpeed = 1.0f;
                attackRange = new Vector2[] { new Vector2(0,0), new Vector2(1,0)};
                viewRange = new Vector2[] { new Vector2(0, 0), new Vector2(1,0)};
                physicsDamageResistance = 0;
                zyuGekiResistance = 0;
                zyuRyokuResistance = 0;
                switch (difficulty)
                {
                    case easy:
                        maxHp = 1000;
                        hp = 1000;
                        baseAttackPower = 30;
                        break;
                    case normal:
                        maxHp = 1500;
                        hp = 1500;
                        baseAttackPower = 40;
                        break;
                    case hard:
                        maxHp = 2000;
                        hp = 2000;
                        baseAttackPower = 50;
                        break;
                }
                break;
            case Namaikinasyouzyo:
                switch (difficulty)
                {
                    case easy:

                        break;
                    case normal:

                        break;
                    case hard:

                        break;
                }
                break;
            case Koisurugyaru:
                switch (difficulty)
                {
                    case easy:

                        break;
                    case normal:

                        break;
                    case hard:

                        break;
                }
                break;
            case Kowamoteyanki:
                switch (difficulty)
                {
                    case easy:

                        break;
                    case normal:

                        break;
                    case hard:

                        break;
                }
                break;
            case Piennnaonnnanoko:
                switch (difficulty)
                {
                    case easy:

                        break;
                    case normal:

                        break;
                    case hard:

                        break;
                }
                break;
            case Piekin:
                switch (difficulty)
                {
                    case easy:

                        break;
                    case normal:

                        break;
                    case hard:

                        break;
                }
                break;
        }
    }
}
