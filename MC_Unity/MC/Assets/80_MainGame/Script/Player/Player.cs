using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Player : MainGameCharactorModel
{
    //スキル
    public bool skill1;
    public bool skill2;
    public bool skill3;
    public SkillEvent skillEvent1;
    public SkillEvent skillEvent2;
    public SkillEvent skillEvent3;
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
    }

    //情報収集
    public void FastUpDate()
    {
        if (skill1 == true)
        {
            skillEvent1();
        }
        if (skill2 == true)
        {
            skillEvent2();
        }
        if (skill3 == true)
        {
            skillEvent3();
        }
    }

    //計算
    public void UpDate()
    {
        //スキルの反映とリセット
        skillEvent();
        ReMoveAllEvents();
    }

    //結果
    public void LateUpDate()
    {
        
    }
}
