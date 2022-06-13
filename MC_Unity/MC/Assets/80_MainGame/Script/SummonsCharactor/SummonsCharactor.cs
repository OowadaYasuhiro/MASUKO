using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonsCharactor : MainGameCharactorModel
{

    //MainGameのアドレス
    MainGame mainGame;

    //攻撃するかどうか
    bool attackable;

    //DaemonSkill2,
    public SummonsCharactor(MainGame mainGame, int attackDamage, SkillEvent skillEvent, Vector2[] attackRange)
    {
        this.mainGame = mainGame;
        baseAttackPower = attackDamage;
        this.skillEvent = skillEvent;
        this.attackRange = attackRange;
        attackable = true;
    }

    //情報収集
    public void FastUpDate()
    {
        if (attackable == true)
        {

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
