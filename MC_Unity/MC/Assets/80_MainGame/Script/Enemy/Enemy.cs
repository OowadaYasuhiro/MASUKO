using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public partial class Enemy : MainGameCharacterModel
{
    //自分の番号
    internal int myNumber;

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
    CharacterState lastRunType;

    //表示クラス
    CharacterManager characterManager;

    internal void Initialized(MainGame mainGame, string difficulty, string name, int number)
    {
        myNumber = number;
        this.mainGame = mainGame;
        if (myNumber == 1)
        {
            position = mainGame.mainGame_StageDeta.enemy1_spawn_position;
        }
        else
        {
            position = mainGame.mainGame_StageDeta.enemy2_spawn_position;
        }
        this.Charactername = name;
        Setting(difficulty);
        directionRight = true;
        characterManager = mainGame.GetComponent<CharacterManager>();
    }

    private void Start()
    {
        charactorState = CharacterState.Standby;
        charactorAnimState = CharacterAnimState.Wait;
    }

    //情報収集
    public void FastUpDate()
    {
        switch (charactorState)
        {
            case CharacterState.Stan:
                charactorState = lastRunType;
                break;
            case CharacterState.Run:
                lastRunType = CharacterState.Run;
                //攻撃範囲に敵がいて戦闘無視状態で無い場合
                if (findEnemy == true && fightThrough == false)
                {
                    charactorState = CharacterState.Fight;
                }
                break;
            case CharacterState.RunAway:
                lastRunType = CharacterState.RunAway;
                //攻撃範囲に敵がいて戦闘無視状態で無い場合
                if (findEnemy == true && fightThrough == false)
                {
                    charactorState = CharacterState.Fight;
                }
                break;
            case CharacterState.Fight:
                if (fightThrough == true)
                {
                    charactorState = lastRunType;
                }
                break;
        }
    }

    //計算
    public void UpDate()
    {
        //スキルの反映とリセット
        if (skillEvent != null)
        {
            skillEvent();
            ReMoveAllEvents();
        }
        switch (charactorState)
        {
            case CharacterState.Fight:
                foreach (MainGameCharacterModel target in targetEnemy)
                {
                    target.AddDamage(damage);
                }
                fightTime++;
                if (fightTime >= maxFightTime)
                {
                    fightThrough = true;
                }
                break;
            case CharacterState.Run:

                Move(mainGame.gameSpeed);
                break;
            case CharacterState.RunAway:

                Move(mainGame.gameSpeed);
                break;
        }
    }

    //結果
    public void LateUpDate()
    {
        characterManager.CharacterVisualization(position, false, myNumber);
    }
}
