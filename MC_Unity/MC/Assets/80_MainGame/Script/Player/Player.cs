using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Player : MainGameCharacterModel
{
    //自分の番号
    internal int myNumber;
    //スキル
    //使用されたかどうか
    internal bool skill1;
    internal bool skill2;
    internal bool skill3;
    //スキルの内容
    internal SkillEvent skillEvent1;
    internal SkillEvent skillEvent2;
    internal SkillEvent skillEvent3;
    //クールダウン
    int skill1CoolDown;
    int skill2CoolDown;
    int skill3CoolDown;
    //クールタイム
    int skill1CoolTime;
    int skill2CoolTime;
    int skill3CoolTime;
    //使用可能か
    internal bool skill1Cool;
    internal bool skill2Cool;
    internal bool skill3Cool;
    bool lateSkill1Cool;
    bool lateSkill2Cool;
    bool lateSkill3Cool;
    //スキルのスタック(合計数)
    int skill1Stack;
    int skill2Stack;
    int skill3Stack;
    //最大スタック数
    int maxSkill1Stack;
    int maxSkill2Stack;
    int maxSkill3Stack;

    //怨嗟
    //使用されたかどうか
    internal bool ult;
    //怨嗟内容
    SkillEvent ultSkillEvent;
    //所持怨念
    float grudgeAmount;
    //怨念増加比率
    float grudgeAmountIncreasePercentage = 1;
    //消費怨念
    int ultCost;
    //怨嗟スタック(合計数)
    int ultStack;
    //最大怨嗟スタック数
    int maxUltStack;

    //パッシブスキル
    SkillEvent passiveSkill;
    //パッシブスキルスタック
    int passiveStack;
    //最大スタック数
    int maxPassiveStack;

    //撤退
    internal bool goback;
    internal int relocationFrame;
    int relocationFrameValue;

    //攻撃
    Damage damage;
    int attackFrequency;
    int attackCooldown;

    //遺物
    Artifact artifact1;
    Artifact artifact2;
    Artifact artifact3;

    //MainGameのアドレス
    MainGame mainGame;

    //表示クラス
    CharacterManager characterManager;

    //待機座標
    Vector2 outPosition = new Vector2(-1,-1);

    internal void Initialized(MainGame mainGame, int number)
    {
        this.mainGame = mainGame;
        Setting(number);
        characterManager = mainGame.GetComponent<CharacterManager>();
    }

    private void Start()
    {
        charactorState = CharacterState.Standby;
        charactorAnimState = CharacterAnimState.Wait;
        goback = true;
        skill1Cool = true;
        skill2Cool = true;
        skill3Cool = true;
        lateSkill1Cool = true;
        lateSkill2Cool = true;
        lateSkill3Cool = true;
        directionRight = false;
    }

    //情報収集
    public void FastUpDate()
    {
        resultingAttackPower = baseAttackPower;
        //クールタイム管理
        skillCoolTimeCounter();
        //スキルボタン表示
        SkillButtonEnable();
        //スキルが使用されてクールダウンが完了していたら
        if (skill1 == true && skill1Cool == true)
        {
            skillEvent1();
            skill1CoolTime = skill1CoolDown;
            skill1Stack = 0;
            skill1Cool = false;
        }
        if (skill2 == true && skill2Cool == true)
        {
            skillEvent2();
            skill2CoolTime = skill2CoolDown;
            skill2Stack = 0;
            skill2Cool = false;
        }
        if (skill3 == true && skill3Cool == true)
        {
            skillEvent3();
            skill3CoolTime = skill3CoolDown;
            skill3Stack = 0;
            skill3Cool = false;
        }

        //怨嗟管理
        UltStackCounter();
        //怨嗟
        if (ult == true && ultStack > 0)
        {
            ultSkillEvent();
            ultStack = 0;
        }

        if (findEnemy == true)
        {
            charactorState = CharacterState.Fight;
        }

        switch (charactorState)
        {
            case CharacterState.Resting:
                relocationFrameValue++;
                if (relocationFrameValue >= relocationFrame)
                {
                    charactorState = CharacterState.Standby;
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
        //パッシブスキル
        if (passiveSkill != null)
        {
            passiveSkill();
        }
        switch (charactorState)
        {
            case CharacterState.Fight:
                attackCooldown--;
                if (attackCooldown <= 0)
                {
                    attackCooldown = attackFrequency;
                    foreach (MainGameCharacterModel target in targetEnemy)
                    {
                        target.AddDamage(new Damage(Damage.physicsDamage, resultingAttackPower));
                    }
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
        }

        if (charactorState == CharacterState.Standby || charactorState == CharacterState.Resting)
        {
            goback = true;
            position = outPosition;
        }


        
        /******************アニメーション*******************/
        characterManager.CharacterVisualization(position,true,myNumber);
        characterManager.SetCharacterHpSlider(myNumber,hp,maxHp);
    }

    //配置
    internal void Deploy(Vector2 targetPosition)
    {
        charactorState = CharacterState.Wait;
        goback = false;
        position = targetPosition;
        displaying = true;
    }
}
