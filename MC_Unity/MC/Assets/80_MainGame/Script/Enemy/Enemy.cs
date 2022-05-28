using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MainGameCharactorModel
{
    //戦闘時間
    const float maxFightTime = 10f;
    float fightTime;

    //スキル
    SkillEvent skillEvent;


    public Enemy(string name)
    {
        this.name = name;
    }

    private void Start()
    {
        charactorState = CharactorState.Standby;
        charactorAnimState = CharactorAnimState.Wait;
    }

    public void AddSkillEvent(SkillEvent skillEvent)
    {
        this.skillEvent += skillEvent; 
    }

    //情報収集
    public void FastUpDate()
    {
        switch (charactorState)
        {
            case CharactorState.Run:

                break;
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
