using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Player : MainGameCharactorModel
{
    //自分の番号
    int myNumber;
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
    int grudgeAmount;
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
    public bool goback;

    //遺物
    Artifact artifact1;
    Artifact artifact2;
    Artifact artifact3;

    //MainGameのアドレス
    MainGame mainGame;

    public Player(MainGame mainGame, int number)
    {
        this.mainGame = mainGame;
        Setting(number);
    }

    private void Start()
    {
        charactorState = CharactorState.Resting;
        charactorAnimState = CharactorAnimState.Wait;
        skill1Cool = true;
        skill2Cool = true;
        skill3Cool = true;
    }

    //情報収集
    public void FastUpDate()
    {
        //クールタイム管理
        skillCoolTimeCounter();
        //スキルが使用されてクールダウンが完了していたら
        if (skill1 == true && skill1Cool == true)
        {
            skillEvent1();
            skill1Stack = 0;
            skill1Cool = false;
        }
        if (skill2 == true && skill1Cool == true)
        {
            skillEvent2();
            skill2Stack = 0;
            skill2Cool = false;
        }
        if (skill3 == true && skill1Cool == true)
        {
            skillEvent3();
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

        switch (charactorState)
        {
            case CharactorState.Resting:
                
                break;
            case CharactorState.Fight:

                break;
        }

    }

    //計算
    public void UpDate()
    {
        //スキルの反映とリセット
        skillEvent();
        ReMoveAllEvents();
        //パッシブスキル
        passiveSkill();
        switch (charactorState)
        {
            case CharactorState.Fight:
                foreach (MainGameCharactorModel target in targetEnemy)
                {
                    target.AddDamage(new Damage(Damage.physicsDamage, resultingAttackPower));
                }
                break;
        }
    }

    //結果
    public void LateUpDate()
    {
        
    }
}
