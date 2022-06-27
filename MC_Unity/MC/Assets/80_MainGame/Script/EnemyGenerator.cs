using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;

partial class MainGame : MonoBehaviour
{
    List<MainGameCharacterModel> subjectList;
    //範囲内の対象を取得
    //検索対象の選択が必要
    public MainGameCharacterModel[] SearchCharacter(Vector2[] area,bool player,bool enemy,bool summonsCharacter)
    {
        subjectList.Clear();
        //受け取った座標を検索
        foreach (Vector2 place in area)
        {
            if (player == true)
            {
                foreach (Player targetplayer in this.players)
                {
                    if (targetplayer.position.x >= (place.x - 0.5) && targetplayer.position.x < (place.x + 0.5))
                    {
                        if (targetplayer.position.y >= (place.y - 0.5) && targetplayer.position.y < (place.y + 0.5))
                        {
                            subjectList.Add(targetplayer);
                        }
                    }
                }
            }
            if (enemy == true)
            {
                foreach (Enemy targetenemy in this.enemies)
                {
                    if (targetenemy.position.x >= (place.x - 0.5) && targetenemy.position.x < (place.x + 0.5))
                    {
                        if (targetenemy.position.y >= (place.y - 0.5) && targetenemy.position.y < (place.y + 0.5))
                        {
                            subjectList.Add(targetenemy);
                        }
                    }
                }
            }
            if (summonsCharacter == true)
            {
                foreach (SummonsCharacter targetsummonsCharacter in this.summonsCharacter)
                {
                    if (targetsummonsCharacter.position.x >= (place.x - 0.5) && targetsummonsCharacter.position.x < (place.x + 0.5))
                    {
                        if (targetsummonsCharacter.position.y >= (place.y - 0.5) && targetsummonsCharacter.position.y < (place.y + 0.5))
                        {
                            subjectList.Add(targetsummonsCharacter);
                        }
                    }
                }
            }
        }
        MainGameCharacterModel[] subject = new MainGameCharacterModel[subjectList.Count];
        for (int i = 0;i < subjectList.Count;i++)
        {
            subject[i] = subjectList[i];
        }
        return subject;
    }

    
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
                        enemies = new Enemy[1] {new Enemy(this, difficulty, Tuyogarisyounen)};
                        break;
                    case 2:
                        enemies = null;
                        enemies = new Enemy[2] { new Enemy(this, difficulty, Tuyogarisyounen), new Enemy(this, difficulty, Tuyogarisyounen) };
                        break;
                    case 3:
                        enemies = null;
                        enemies = new Enemy[2] { new Enemy(this, difficulty, Tuyogarisyounen), new Enemy(this, difficulty, Namaikinasyouzyo) };
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

