using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public partial class Enemy : MainGameCharacterModel
{
    //自分の番号
    public int myNumber;

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
    float attackAnimationFrequency = 0.3f;

    //MainGameのアドレス
    MainGame mainGame;

    //最後の移動状態
    CharacterState lastRunType;

    //表示クラス
    CharacterManager characterManager;

    //アニメーション用ディレイ
    bool animationSkip = false;

    public void Initialized(MainGame mainGame, string difficulty, string name, int number)
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
        maxThroughTime = (int)(moveSpeed * 200f);
        damage = new Damage(Damage.physicsDamage, baseAttackPower);
        damage.type = Damage.physicsDamage;
        damage.value = baseAttackPower;
        displaying = true;
    }

    private void Start()
    {
        charactorState = CharacterState.Standby;
        charactorAnimState = CharacterAnimState.Wait;
        fightThrough = false;
    }

    //情報収集
    public void FastUpDate()
    {
        switch (charactorState)
        {
            case CharacterState.RunAway:
            case CharacterState.Run:
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
            case CharacterState.Run:
                
                lastRunType = CharacterState.Run;
                Move(mainGame.gameSpeed);
                break;
            case CharacterState.RunAway:
                
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
        if (alive == false)
        {
            charactorState = CharacterState.Dead;
            charactorAnimState = CharacterAnimState.Die;
        }
        if (animationSkip == false)
        {
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
                    animationSkip = true;
                    Invoke(nameof(EndAnimationSkip), attackAnimationFrequency);
                    break;
                case CharacterState.Stan:
                    charactorAnimState = CharacterAnimState.Stan;
                    animationSkip = true;
                    Invoke(nameof(EndAnimationSkip), attackAnimationFrequency);
                    break;
            }
        }

        if (Goal == true)
        {
            mainGame.EnemyGoal();
            charactorAnimState = CharacterAnimState.Win;
        }

        characterManager.CharacterVisualization(position, false, myNumber);
        characterManager.CharacterAnimation(false,myNumber,charactorAnimState,Charactername,takeDamage);
        characterManager.SetCharacterDirection(false,myNumber,directionRight);
        characterManager.SetCharacterHpSlider(myNumber, hp, maxHp, false);

    }

    void EndAnimationSkip()
    {
        animationSkip = false;
    }
}
