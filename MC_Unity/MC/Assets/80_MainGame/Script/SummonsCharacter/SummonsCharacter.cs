using UnityEngine;

public class SummonsCharacter : MainGameCharacterModel
{
    //MainGameのアドレス
    MainGame mainGame;

    //攻撃するかどうか
    bool attackable;

    //スキルを発動するかどうか
    bool skillble;

    //スキル
    SkillEvent skill;

    //
    public SummonsCharacter(MainGame mainGame, int attackDamage, SkillEvent skillEvent, Vector2[] attackRange)
    {
        this.mainGame = mainGame;
        baseAttackPower = attackDamage;
        skill = skillEvent;
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
