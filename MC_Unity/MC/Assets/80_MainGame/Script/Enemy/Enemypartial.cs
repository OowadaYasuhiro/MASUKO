using System;
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
                attackFrequency = 60;
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

        string sn = StageSelect_Deta.selectStageNumber;
        int ep = int.Parse(sn.Substring(1,1));
        switch (ep)
        {
            case 1:
                if (myNumber == 1)
                {
                    targetPosition = new Vector2[]
                    {
                        new Vector2(0,4),
                        new Vector2(1,4),
                        new Vector2(2,4),
                        new Vector2(3,4),
                        new Vector2(4,4),
                        new Vector2(5,4),
                        new Vector2(6,4),
                        new Vector2(7,4),
                        new Vector2(8,4),
                        new Vector2(9,4),
                        new Vector2(8,4),
                        new Vector2(7,4),
                        new Vector2(6,4),
                        new Vector2(5,4),
                        new Vector2(4,4),
                        new Vector2(3,4),
                        new Vector2(2,4),
                        new Vector2(1,4),
                        new Vector2(0,4),
                    };
                    targetObject = mainGame.mainGame_StageDeta.enemy1_target_object;
                }
                else
                {
                    targetPosition = new Vector2[]
                    {
                        new Vector2(0,1),
                        new Vector2(1,1),
                        new Vector2(2,1),
                        new Vector2(3,1),
                        new Vector2(4,1),
                        new Vector2(5,1),
                        new Vector2(6,1),
                        new Vector2(7,1),
                        new Vector2(8,1),
                        new Vector2(9,1),
                        new Vector2(8,1),
                        new Vector2(7,1),
                        new Vector2(6,1),
                        new Vector2(5,1),
                        new Vector2(4,1),
                        new Vector2(3,1),
                        new Vector2(2,1),
                        new Vector2(1,1),
                        new Vector2(0,1),
                    };
                    targetObject = mainGame.mainGame_StageDeta.enemy2_target_object;
                }
                break;
            case 2:
                if (myNumber == 1)
                {
                    targetPosition = new Vector2[]
                    {

                    };
                }
                else
                {
                    targetPosition = new Vector2[]
                    {

                    };
                }
                break;
            case 3:
                if (myNumber == 1)
                {
                    targetPosition = new Vector2[]
                    {

                    };
                }
                else
                {
                    targetPosition = new Vector2[]
                    {

                    };
                }
                break;
            case 4:
                if (myNumber == 1)
                {
                    targetPosition = new Vector2[]
                    {

                    };
                }
                else
                {
                    targetPosition = new Vector2[]
                    {

                    };
                }
                break;
            case 5:
                if (myNumber == 1)
                {
                    targetPosition = new Vector2[]
                    {

                    };
                }
                else
                {
                    targetPosition = new Vector2[]
                    {

                    };
                }
                break;
        }
    }
}
