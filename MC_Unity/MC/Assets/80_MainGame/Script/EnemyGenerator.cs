using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;

partial class MainGame : MonoBehaviour
{
    //自動で敵を生成
    void GeneratEnemy()
    {
        string difficulty = StageSelect_Deta.selectDifficulty;
        switch (stage)
        {
            case (main_ep1_1):
                switch (waveNumber)
                {
                    case 1:
                        enemies = null;
                        enemies[0] = new Enemy(EnemyName.TUYOGARISYOUNEN,difficulty);
                        break;
                    case 2:
                        enemies = null;
                        enemies[0] = new Enemy(EnemyName.TUYOGARISYOUNEN, difficulty);
                        enemies[1] = new Enemy(EnemyName.TUYOGARISYOUNEN, difficulty);
                        break;
                    case 3:
                        enemies = null;
                        enemies[0] = new Enemy(EnemyName.TUYOGARISYOUNEN, difficulty);
                        enemies[1] = new Enemy(EnemyName.NAMIKINASYOUZYO, difficulty);
                        break;
                }
                break;
            case (main_ep1_2):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep1_3):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep1_4):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep2_1):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep2_2):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep2_3):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep2_4):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep3_1):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep3_2):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep3_3):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep3_4):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep4_1):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep4_2):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep4_3):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep4_4):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep5_1):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep5_2):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep5_3):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
            case (main_ep5_4):
                switch (waveNumber)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
                break;
        }
    }
}

