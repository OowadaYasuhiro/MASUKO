using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;

public partial class Player
{
    //コンストラクターから呼び出し、フィールドの情報を埋めていく
    void Setting(int number)
    {
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

        switch (Charactername)
        {
            case Daemon:
                //最大スタック数設定
                maxSkill1Stack = 1;
                skill1Stack = maxSkill1Stack;
                //クールダウン設定
                switch (FDC.skill1level)
                {
                    case 1:
                        skill1CoolDown = 600;
                        break;
                    case 2:
                        skill1CoolDown = 600;
                        break;
                    case 3:
                        skill1CoolDown = 540;
                        break;
                    case 4:
                        skill1CoolDown = 540;
                        break;
                    case 5:
                        skill1CoolDown = 480;
                        break;
                }
                skillEvent1 = DaemonSkill1;
                void DaemonSkill1()
                {
                    goto Skip0;
                    //ステートをスタンに移行
                    void EnemyStan()
                    {
                        charactorState = CharacterState.Stan;
                    }
                    Skip0:
                    SkillEvent Stan = EnemyStan;
                    double damageMagnification = 0;
                    switch (FDC.skill1level)
                    {
                        case 1:
                            damageMagnification = 0.1;
                            break;
                        case 2:
                            damageMagnification = 0.25;
                            break;
                        case 3:
                            damageMagnification = 0.2;
                            break;
                        case 4:
                            damageMagnification = 0.25;
                            break;
                        case 5:
                            damageMagnification = 0.3;
                            break;
                    }
                    goto Skip1;
                    //攻撃力のn%の物理ダメージ(要検討)
                    void PlayerSkillAttack()
                    {
                        AddDamage(new Damage(Damage.physicsDamage, (int)(resultingAttackPower * damageMagnification)));
                    }
                    Skip1:
                    SkillEvent SkillAttack = PlayerSkillAttack;
                    //攻撃範囲内の敵を取得
                    MainGameCharacterModel[] target = mainGame.SearchCharacter(attackRange, false, true, false);
                    //ターゲット全員に対しスキルを発動
                    foreach (MainGameCharacterModel targetCharacter in target)
                    {
                        StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(mainGame, targetCharacter, 180, 1, Stan));
                        StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(mainGame, targetCharacter, 300, 72, SkillAttack));
                    }
                }
                //最大スタック数設定
                maxSkill2Stack = 1;
                skill2Stack = maxSkill2Stack;
                //スキル２のダメージ
                int Skill2Damage = 0;
                //クールダウン設定
                switch (FDC.skill2level)
                {
                    case 1:
                        skill2CoolDown = 720;
                        Skill2Damage = (int)(baseAttackPower * 1.05);
                        break;
                    case 2:
                        skill2CoolDown = 720;
                        Skill2Damage = (int)(baseAttackPower * 1.15);
                        break;
                    case 3:
                        skill2CoolDown = 660;
                        Skill2Damage = (int)(baseAttackPower * 1.25);
                        break;
                    case 4:
                        skill2CoolDown = 660;
                        Skill2Damage = (int)(baseAttackPower * 1.35);
                        break;
                    case 5:
                        skill2CoolDown = 600;
                        Skill2Damage = (int)(baseAttackPower * 1.45);
                        break;
                }
                skillEvent2 = DaemonSkill2;
                void DaemonSkill2()
                {
                    goto Skip0;
                    //ステートをスタンに移行
                    void EnemyStan()
                    {
                        charactorState = CharacterState.Stan;
                    }
                    Skip0:
                    SkillEvent Stan = EnemyStan;
                    goto Skip1;
                    //攻撃力のn%の物理ダメージ(要検討)
                    void PlayerSkillAttack()
                    {
                        AddDamage(new Damage(Damage.physicsDamage, Skill2Damage));
                    }
                    Skip1:
                    SkillEvent SkillAttack = PlayerSkillAttack;
                    goto Skip2;
                    void ObjectSkill()
                    {
                        //攻撃範囲内の敵を取得
                        MainGameCharacterModel[] target = mainGame.SearchCharacter(new Vector2[] { new Vector2(0,0)}, false, true, false);
                        //ターゲット全員に対しスキルを発動
                        foreach (MainGameCharacterModel targetCharacter in target)
                        {
                            StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(mainGame, targetCharacter, 300, 1, Stan));
                            StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(mainGame, targetCharacter, 0, 1, SkillAttack));
                        }
                    }
                    Skip2:
                    SkillEvent ObjectSkillEvent = ObjectSkill;
                    mainGame.summonsobject[mainGame.summonsobject.Length] = new SummonsObject(mainGame,ObjectSkillEvent);
                }
                //最大スタック数設定
                maxSkill3Stack = 3;
                skill3Stack = maxSkill3Stack;
                //クールダウン設定
                switch (FDC.skill3level)
                {
                    case 1:
                        skill3CoolDown = 900;
                        break;
                    case 2:
                        skill3CoolDown = 900;
                        break;
                    case 3:
                        skill3CoolDown = 840;
                        break;
                    case 4:
                        skill3CoolDown = 840;
                        break;
                    case 5:
                        skill3CoolDown = 780;
                        break;
                }
                skillEvent3 = DaemonSkill3;
                void DaemonSkill3()
                {
                    double damageMagnification = 0;
                    switch (skill3Stack)
                    {
                        case 1:
                            switch (FDC.skill3level)
                            {
                                case 1:
                                    damageMagnification = 0.3;
                                    break;
                                case 2:
                                    damageMagnification = 0.4;
                                    break;
                                case 3:
                                    damageMagnification = 0.5;
                                    break;
                                case 4:
                                    damageMagnification = 0.6;
                                    break;
                                case 5:
                                    damageMagnification = 0.7;
                                    break;
                            }
                            break;
                        case 2:
                            switch (FDC.skill3level)
                            {
                                case 1:
                                    damageMagnification = 0.35;
                                    break;
                                case 2:
                                    damageMagnification = 0.45;
                                    break;
                                case 3:
                                    damageMagnification = 0.55;
                                    break;
                                case 4:
                                    damageMagnification = 0.65;
                                    break;
                                case 5:
                                    damageMagnification = 0.75;
                                    break;
                            }
                            break;
                        case 3:
                            switch (FDC.skill3level)
                            {
                                case 1:
                                    damageMagnification = 0.4;
                                    break;
                                case 2:
                                    damageMagnification = 0.5;
                                    break;
                                case 3:
                                    damageMagnification = 0.6;
                                    break;
                                case 4:
                                    damageMagnification = 0.7;
                                    break;
                                case 5:
                                    damageMagnification = 0.8;
                                    break;
                            }
                            break;
                        case 4:
                            switch (FDC.skill3level)
                            {
                                case 1:
                                    damageMagnification = 0.45;
                                    break;
                                case 2:
                                    damageMagnification = 0.55;
                                    break;
                                case 3:
                                    damageMagnification = 0.65;
                                    break;
                                case 4:
                                    damageMagnification = 0.75;
                                    break;
                                case 5:
                                    damageMagnification = 0.85;
                                    break;
                            }
                            break;
                    }
                    //攻撃力のn%の物理ダメージ(要検討)
                    void PlayerSkillAttack()
                    {
                        AddDamage(new Damage(Damage.physicsDamage, (int)(resultingAttackPower * damageMagnification)));
                    }
                    SkillEvent SkillAttack = PlayerSkillAttack;
                    //攻撃範囲内の敵を取得
                    MainGameCharacterModel[] target = mainGame.SearchCharacter(attackRange, false, true, false);
                    //ターゲット全員に対しスキルを発動
                    foreach (MainGameCharacterModel targetCharacter in target)
                    {
                        StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(mainGame, targetCharacter, 300, 72, SkillAttack));
                    }
                }
                //最大スタック数設定
                maxUltStack = 4;
                skill1Stack = maxSkill1Stack;
                switch (FDC.ultlevel)
                {
                    case 1:
                        ultCost = 50;
                        break;
                    case 2:
                        ultCost = 50;
                        break;
                    case 3:
                        ultCost = 45;
                        break;
                    case 4:
                        ultCost = 45;
                        break;
                    case 5:
                        ultCost = 40;
                        break;
                }
                ultSkillEvent = UltSkillEvent;
                void UltSkillEvent()
                {

                    //攻撃範囲内の敵を取得
                    MainGameCharacterModel[] target = mainGame.SearchCharacter(attackRange, false, true, false);
                    //ターゲット全員に対しスキルを発動
                    foreach (MainGameCharacterModel targetCharacter in target)
                    {
                        //StartCoroutine(new MainGameSkillEvent().DoSkillEvent(targetCharacter, 300, 72, ));
                    }
                }
                //最大スタック数設定
                maxPassiveStack = 4;
                passiveStack = 1;
                passiveSkill = PassiveSkill;
                void PassiveSkill()
                {
                    resultingAttackPower = baseAttackPower + (int)(baseAttackPower * (0.03 * ultStack));
                }
                break;
            case Poltergeist:

                break;
            case Gore:

                break;
            case Zashiki_warashi:

                break;
            case Ghost:

                break;
        }
    }

    void skillCoolTimeCounter()
    {
        //クールタイムが残っている
        if (skill1CoolTime > 0)
        {
            skill1CoolTime--;
            //クールダウン完了
            if (skill1CoolTime == 0)
            {
                skill1Cool = true;
                skill1Stack++;
                //まだスタック可能
                if (skill1Stack < maxSkill1Stack)
                {
                    skill1CoolTime = skill1CoolDown;
                }
            }
        }
        if (skill2CoolTime > 0)
        {
            skill2CoolTime--;
            if (skill2CoolTime == 0)
            {
                skill2Cool = true;
                skill2Stack++;
                if (skill2Stack < maxSkill2Stack)
                {
                    skill2CoolTime = skill2CoolDown;
                }
            }
        }
        if (skill3CoolTime > 0)
        {
            skill3CoolTime--;
            if (skill3CoolTime == 0)
            {
                skill3Cool = true;
                skill3Stack++;
                if (skill3Stack < maxSkill3Stack)
                {
                    skill3CoolTime = skill3CoolDown;
                }
            }
        }
    }

    void UltStackCounter()
    {
        if (ultCost <= grudgeAmount)
        {
            ultStack = 1;
        }
        if ((ultCost * 2) <= grudgeAmount)
        {
            ultStack = 2;
        }
        if ((ultCost * 3) <= grudgeAmount)
        {
            ultStack = 3;
        }
        if ((ultCost * 4) <= grudgeAmount)
        {
            ultStack = 4;
        }
    }
}
