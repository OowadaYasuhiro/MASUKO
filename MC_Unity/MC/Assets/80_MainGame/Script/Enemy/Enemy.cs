using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public partial class Enemy : MainGameCharactorModel
{
    //戦闘時間
    const int maxFightTime = 600;
    int fightTime;

    //戦闘無視時間
    bool fightThrough;
    int maxThroughTime;
    int throughTime;

    //通常攻撃
    Damage damage;

    //MainGameのアドレス
    MainGame mainGame;

    //最後の移動状態
    CharactorState lastRunType;


    public Enemy( MainGame mainGame, string difficulty, string name)
    {
        this.mainGame = mainGame;
        this.Charactorname = name;
        Setting(difficulty);
        directionRight = true;
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
                //攻撃範囲に敵がいて戦闘無視状態で無い場合
                if (findEnemy == true && fightThrough == false)
                {
                    charactorState = CharactorState.Fight;
                }
                break;
            case CharactorState.RunAway:
                lastRunType = CharactorState.RunAway;
                //攻撃範囲に敵がいて戦闘無視状態で無い場合
                if (findEnemy == true && fightThrough == false)
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
                foreach (MainGameCharactorModel target in targetEnemy)
                {
                    target.AddDamage(damage);
                }
                fightTime++;
                if (fightTime >= maxFightTime)
                {
                    fightThrough = true;
                }
                break;
        }
    }

    //結果
    public void LateUpDate()
    {

    }
}
