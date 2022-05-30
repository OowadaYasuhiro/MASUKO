using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MainGameCharactorModel
{
    //スキル
    bool skill1;
    bool skill2;
    bool skill3;
    public SkillEvent skillEvent1;
    SkillEvent skillEvent2;
    SkillEvent skillEvent3;
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
