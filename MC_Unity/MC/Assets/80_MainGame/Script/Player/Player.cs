using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Player : MainGameCharacterModel
{
    //自分の番号
    public int myNumber;
    //スキル
    PlayerSkill[] m_playerSkill = new PlayerSkill[3];

    //怨嗟
    //使用されたかどうか
    public bool ult;
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

    //遺物の効果
    SkillEvent relicSkill;

    //撤退
    public bool goback;
    public int relocationFrame;
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

    //最後のステート状態
    CharacterState lastStateType;

    public void Initialized(MainGame mainGame, int number)
    {
        this.mainGame = mainGame;
        for (int i = 0; i < m_playerSkill.Length; i++)
        {
            m_playerSkill[i].m_mainGame = mainGame;
            m_playerSkill[i].m_player = this;
        }
        myNumber = number;
        player = true;
        Charactor FDC = new Charactor();
        if (number == 1)
        {
            FDC = (Charactor)Master.formationdeta.selectcharactor1;
            artifact1 = Master.formationdeta.charactor1Artifacts[0];
            artifact2 = Master.formationdeta.charactor1Artifacts[1];
            artifact3 = Master.formationdeta.charactor1Artifacts[2];
        }
        if (number == 2)
        {
            FDC = (Charactor)Master.formationdeta.selectcharactor2;
            artifact1 = Master.formationdeta.charactor2Artifacts[0];
            artifact2 = Master.formationdeta.charactor2Artifacts[1];
            artifact3 = Master.formationdeta.charactor2Artifacts[2];
        }
        Charactername = FDC.name;
        characterManager = mainGame.GetComponent<CharacterManager>();
        lastStateType = charactorState;
    }

    private void Start()
    {
        charactorState = CharacterState.Standby;
        charactorAnimState = CharacterAnimState.Wait;
        goback = true;
        for (int i = 0; i < m_playerSkill.Length; i++)
        {
            m_playerSkill[i].m_skillEnabled = true;
            m_playerSkill[i].m_lateSkillEnabled = true;
        }
        directionRight = false;
    }

    //情報収集
    public void FastUpDate()
    {
        resultingAttackPower = baseAttackPower;
        //クールタイム管理
        for (int i = 0; i < m_playerSkill.Length; i++)
        {
            m_playerSkill[i].SkillCoolTimeCounter();
        }
        //スキルボタン表示
        SkillButtonEnable();
        for (int i = 0; i < m_playerSkill.Length; i++)
        {
            if (m_playerSkill[i].m_skillActivating == true)
            {
                m_playerSkill[i].m_skillEvent();
                m_playerSkill[i].m_skillCoolTime = m_playerSkill[i].m_skillCoolDown;
                m_playerSkill[i].m_skillStack = 0;
                m_playerSkill[i].m_skillActivating = false;
            }
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
        else
        {
            charactorState = lastStateType;
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
        if (relicSkill != null)
        {
            relicSkill();
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
            charactorState = CharacterState.Recovery;
        }

        if (charactorState == CharacterState.Standby || charactorState == CharacterState.Resting)
        {
            goback = true;
            position = outPosition;
        }

        switch (charactorState)
        {
            case CharacterState.Wait:
                charactorAnimState = CharacterAnimState.Wait;
                lastStateType = charactorState;
                break;
            case CharacterState.Fight:
                charactorAnimState = CharacterAnimState.Fight;
                break;
        }

        characterManager.CharacterVisualization(position,true,myNumber);
        characterManager.CharacterAnimation(true, myNumber, charactorAnimState, Charactername,takeDamage);
        characterManager.SetCharacterDirection(true, myNumber, directionRight);
        characterManager.SetCharacterHpSlider(myNumber,hp,maxHp,true);
    }

    //配置
    public void Deploy(Vector2 targetPosition)
    {
        charactorState = CharacterState.Wait;
        lastStateType = CharacterState.Wait;
        goback = false;
        position = targetPosition;
        displaying = true;
    }
}
