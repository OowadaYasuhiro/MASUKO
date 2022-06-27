using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;

public class SummonsObject : MainGameCharacterModel
{

    //MainGameのアドレス
    MainGame mainGame;

    //攻撃
    Damage damage;

    //スキル
    SkillEvent skill;

    //DaemonSkill2,
    public SummonsObject(MainGame mainGame, SkillEvent skillEvent)
    {
        this.mainGame = mainGame;
        skill = skillEvent;
    }

    //情報収集
    public void FastUpDate()
    {
        
    }

    //計算
    public void UpDate()
    {
        //スキルの反映とリセット
        skillEvent();
        ReMoveAllEvents();

        skill();
    }

    //結果
    public void LateUpDate()
    {

    }

}
