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
    int throughTime = 0;

    //通常攻撃
    Damage damage;
    int attackFrequency;
    int attackCooldown = 0;
    float attackAnimationFrequency = 0.5f;

    //MainGameのアドレス
    MainGame mainGame;

    //最後の移動状態
    CharacterState lastRunType;

    //表示クラス
    CharacterManager characterManager;

    //アニメーション用ディレイ
    bool animationSkip = false;

    //プレイヤーが目の前にいるか
    bool onCollisionPlayer = false;
    const int withFightTime = 300;
    int withFightCool = 0;
    Vector2[] targetRange = new Vector2[] {new Vector2(0,0),new Vector2(1,0)};

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
        maxThroughTime = (int)(moveSpeed * 180f);
        damage = new Damage(Damage.physicsDamage, baseAttackPower);
        damage.type = Damage.physicsDamage;
        damage.value = baseAttackPower;
        
    }

    private void Start()
    {
        charactorState = CharacterState.Standby;
        charactorAnimState = CharacterAnimState.Wait;
        fightThrough = false;
        displaying = true;
    }

    //情報収集
    public void FastUpDate()
    {
        if (animationSkip == false)
        {
            if (fightThrough == true)
            {
                throughTime++;
                if (throughTime >= maxThroughTime)
                {
                    fightThrough = false;
                }
            }
            if (findEnemy == true && fightThrough == false)
            {
                charactorState = CharacterState.Fight;
            }
            if (mainGame.SearchCharacter(position, targetRange, true, false, false).Length > 0)
            {
                onCollisionPlayer = true;
            }
            else
            {
                onCollisionPlayer = false;
            }
            if (onCollisionPlayer == true)
            {
                withFightCool++;
                if (withFightCool == withFightTime)
                {
                    onCollisionPlayer = false;
                }
            }
        }
    }

    //計算
    public void UpDate()
    {
        if (animationSkip == false)
        {
            //スキルの反映とリセット
            if (skillEvent != null)
            {
                skillEvent();
                ReMoveAllEvents();
            }
            switch (charactorState)
            {
                case CharacterState.Run:
                    if (onCollisionPlayer == true)
                    {
                        goto case CharacterState.Fight;
                    }
                    lastRunType = CharacterState.Run;
                    Move(mainGame.gameSpeed);
                    break;
                case CharacterState.RunAway:
                    if (onCollisionPlayer == true)
                    {
                        goto case CharacterState.Fight;
                    }
                    lastRunType = CharacterState.RunAway;
                    Move(mainGame.gameSpeed);
                    break;
                case CharacterState.Fight:
                    attackCooldown--;
                    if (attackCooldown <= 0)
                    {
                        attackCooldown = attackFrequency;
                        foreach (MainGameCharacterModel target in targetEnemy)
                        {
                            damage.value = baseAttackPower;
                            target.AddDamage(damage);
                        }
                        animationSkip = true;
                        Invoke("EndAnimationSkip", attackAnimationFrequency);
                    }
                    fightTime++;
                    if (fightTime >= maxFightTime)
                    {
                        fightThrough = true;
                    }
                    break;
            }
        }
    }

    //結果
    public void LateUpDate()
    {
        if (alive == false)
        {
            charactorState = CharacterState.Dead;
            charactorAnimState = CharacterAnimState.Die;
        }
        switch (charactorState)
        {
            case CharacterState.Wait:
                charactorAnimState = CharacterAnimState.Wait;
                break;
            case CharacterState.Run:
            case CharacterState.RunAway:
                charactorAnimState = CharacterAnimState.Run;
                break;
            case CharacterState.Fight:
                charactorAnimState = CharacterAnimState.Fight;
                break;
        }
        characterManager.CharacterVisualization(position, false, myNumber);
        characterManager.CharacterAnimation(false,myNumber,charactorAnimState,Charactername,takeDamage);
        characterManager.SetCharacterDirection(false,myNumber,directionRight);
    }

    void EndAnimationSkip()
    {
        animationSkip = false;
    }
}
