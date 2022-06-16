using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;

public class SummonsObject : MainGameCharactorModel
{

    //MainGameのアドレス
    MainGame mainGame;

    //攻撃するかどうか
    bool attackable;

    //攻撃
    Damage damage;

    //スキルを発動するかどうか
    bool skillble;

    //スキル
    SkillEvent skill;

    //DaemonSkill2,
    public SummonsObject(MainGame mainGame, SkillEvent skillEvent, Vector2[] attackRange)
    {
        this.mainGame = mainGame;
        skill = skillEvent;
        this.attackRange = attackRange;
        attackable = true;
        skillble = true;
    }

    //情報収集
    public void FastUpDate()
    {
        if (attackable == true && findEnemy == true)
        {
            foreach (MainGameCharactorModel target in targetEnemy)
            {
                target.AddDamage(damage);
            }
        }
        if (skillble == true)
        {
            skill();
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
