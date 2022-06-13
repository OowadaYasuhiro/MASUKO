using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public partial class Enemy : MainGameCharactorModel
{
    //戦闘時間
    const float maxFightTime = 10f;
    float fightTime;
    //通常攻撃
    Damage damage;
    //MainGameのアドレス
    MainGame mainGame;
    //最後の移動状態
    CharactorState lastRunType;


    public Enemy( MainGame mainGame, string difficulty)
    {
        this.mainGame = mainGame;
        //this.name = name;
        Setting(difficulty);
    }

    private void Start()
    {
        charactorState = CharactorState.Standby;
        charactorAnimState = CharactorAnimState.Wait;
    }

    //情報収集
    public void FastUpDate()
    {
        switch (charactorState)
        {
            case CharactorState.Stan:
                charactorState = lastRunType;
                break;
            case CharactorState.Run:
                lastRunType = CharactorState.Run;
                if (findEnemy == true)
                {
                    charactorState = CharactorState.Fight;
                }
                break;
            case CharactorState.RunAway:
                lastRunType = CharactorState.RunAway;
                if (findEnemy == true)
                {
                    charactorState = CharactorState.Fight;
                }
                break;
        }
    }

    //計算
    public void UpDate()
    {
        //スキルの反映とリセット
        skillEvent();
        ReMoveAllEvents();
        switch (charactorState)
        {
            case CharactorState.Fight:
                targetEnemy[0].AddDamage(damage);
                break;
        }
    }

    //結果
    public void LateUpDate()
    {

    }
}
