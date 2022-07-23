using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;

partial class MainGame : MonoBehaviour
{
    List<MainGameCharacterModel> subjectList = new List<MainGameCharacterModel>();
    //範囲内の対象を取得
    //検索対象の選択が必要
    public MainGameCharacterModel[] SearchCharacter(Vector2 position, Vector2[] area,bool player,bool enemy,bool summonsCharacter)
    {
        subjectList.Clear();
        //受け取った座標を検索
        foreach (Vector2 place in area)
        {
            if (player == true)
            {
                foreach (Player targetplayer in this.players)
                {
                    if (targetplayer.displaying == false)
                    {
                        continue;
                    }
                    if (targetplayer.position.x >= (position.x + place.x - 0.5) && targetplayer.position.x < (position.x + place.x + 0.5))
                    {
                        if (targetplayer.position.y >= (position.y + place.y - 0.5) && targetplayer.position.y < (position.y + place.y + 0.5))
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
                    if (targetenemy.displaying == false)
                    {
                        continue;
                    }
                    if (targetenemy.position.x >= (position.x + place.x - 0.5) && targetenemy.position.x < (position.x + place.x + 0.5))
                    {
                        if (targetenemy.position.y >= (position.y + place.y - 0.5) && targetenemy.position.y < (position.y + place.y + 0.5))
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
                    if (targetsummonsCharacter == null || targetsummonsCharacter.displaying == false)
                    {
                        continue;
                    }
                    if (targetsummonsCharacter.position.x >= (position.x + place.x - 0.5) && targetsummonsCharacter.position.x < (position.x + place.x + 0.5))
                    {
                        if (targetsummonsCharacter.position.y >= (position.y + place.y - 0.5) && targetsummonsCharacter.position.y < (position.y + place.y + 0.5))
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
        difficulty = easy;
        switch (stage)
        {
            case (main_ep1_1):
                switch (waveNumber)
                {
                    case 1:
                        enemies = null;
                        enemies = new Enemy[1] { gameObject.AddComponent<Enemy>() };
                        enemies[0].Initialized(this, difficulty, Tuyogarisyounen, 1);
                        break;
                    case 2:
                        enemies = null;
                        enemies = new Enemy[2] { gameObject.AddComponent<Enemy>(), gameObject.AddComponent<Enemy>() };
                        enemies[0].Initialized(this, difficulty, Tuyogarisyounen, 1);
                        enemies[1].Initialized(this, difficulty, Tuyogarisyounen, 2);
                        break;
                    case 3:
                        enemies = null;
                        enemies = new Enemy[2] { gameObject.AddComponent<Enemy>(), gameObject.AddComponent<Enemy>() };
                        enemies[0].Initialized(this, difficulty, Tuyogarisyounen, 1);
                        enemies[1].Initialized(this, difficulty, Namaikinasyouzyo, 2);
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

