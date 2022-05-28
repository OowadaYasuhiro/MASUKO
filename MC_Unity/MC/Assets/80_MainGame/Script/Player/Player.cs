using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MainGameCharactorModel
{
    //スキル
    bool skill1;
    bool skill2;
    bool skill3;
    SkillEvent skillEvent1;
    SkillEvent skillEvent2;
    SkillEvent skillEvent3;
    SkillEvent skillEvent;
    //撤退
    bool goback;

    public Player(string name)
    {
        this.name = name;
    }

    private void Start()
    {
        charactorState = CharactorState.Wait;
        charactorAnimState = CharactorAnimState.Wait;
    }

    public void AddSkillEvent(SkillEvent skillEvent)
    {
        this.skillEvent += skillEvent;
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

    void ReMoveAllEvents()
    {
        foreach (var d in skillEvent.GetInvocationList())
        {
            skillEvent -= (SkillEvent)d;
        }
    }
}
