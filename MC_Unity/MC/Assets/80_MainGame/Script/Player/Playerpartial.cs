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
                //攻撃頻度
                attackFrequency = 72;
                //再配置
                relocationFrame = 1200;
                //レベルで変動するステータス
                if (FDC.level > 90)
                {
                    baseAttackPower = 480;
                    hp = 1200;
                    physicsDamageResistance = 140 / 20;
                }
                else if(FDC.level > 50)
                {
                    baseAttackPower = 290;
                    hp = 600;
                    physicsDamageResistance = 90 / 20;
                }
                else
                {
                    baseAttackPower = 140;
                    hp = 450;
                    physicsDamageResistance = 60 / 20;
                }
                if (FDC.credibility >= 200)
                {
                    hp += 45;
                    baseAttackPower += 20;
                    physicsDamageResistance += 20;
                }
                else if (FDC.credibility >= 150)
                {
                    hp += 15;
                    baseAttackPower += 10;
                    physicsDamageResistance += 10;
                }
                else if (FDC.credibility >= 100)
                {
                    hp += 15;
                    baseAttackPower += 10;
                    physicsDamageResistance += 10;
                }
                else if (FDC.credibility >= 50)
                {
                    hp += 15;
                    baseAttackPower += 10;
                    physicsDamageResistance += 10;
                }
                maxHp = hp;
                //視野範囲
                viewRange = new Vector2[]
                {
                    new Vector2(0,0),
                    new Vector2(0,1),
                    new Vector2(0,-1),
                    new Vector2(1,0),
                    new Vector2(1,1),
                    new Vector2(1,-1),
                    new Vector2(-1,0),
                    new Vector2(-1,1),
                    new Vector2(-1,-1),
                    new Vector2(0,2),
                    new Vector2(0,-2),
                    new Vector2(2,0),
                    new Vector2(-2,0)
                };
                //攻撃範囲
                if (Master.playerdeta.DaemonbreakingThrough2 == true)
                {
                    attackRange = new Vector2[]
                    {
                        new Vector2(0,0),
                        new Vector2(0,1),
                        new Vector2(0,-1),
                        new Vector2(1,0),
                        new Vector2(1,1),
                        new Vector2(1,-1),
                        new Vector2(-1,0),
                        new Vector2(-1,1),
                        new Vector2(-1,-1),
                        new Vector2(0,2),
                        new Vector2(0,-2),
                        new Vector2(2,0),
                        new Vector2(-2,0)
                    };
                }
                else if (Master.playerdeta.DaemonbreakingThrough1 == true)
                {
                    attackRange = new Vector2[]
                    {
                        new Vector2(0,0),
                        new Vector2(0,1),
                        new Vector2(0,-1),
                        new Vector2(1,0),
                        new Vector2(1,1),
                        new Vector2(1,-1),
                        new Vector2(-1,0),
                        new Vector2(-1,1),
                        new Vector2(-1,-1),
                        new Vector2(0,2),
                        new Vector2(0,-2),
                    };
                }
                else
                {
                    attackRange = new Vector2[]
                    {
                        new Vector2(0,0),
                        new Vector2(0,1),
                        new Vector2(0,-1),
                        new Vector2(1,0),
                        new Vector2(1,1),
                        new Vector2(1,-1),
                        new Vector2(-1,0),
                        new Vector2(-1,1),
                        new Vector2(-1,-1)
                    };
                }
                //最大スタック数設定
                maxSkill1Stack = 1;
                skill1Stack = maxSkill1Stack;
                //クールダウン設定
                switch (FDC.skill1level)
                {
                    case 1:
                    case 2:
                        skill1CoolDown = 600;
                        break;
                    case 3:
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
                    //攻撃範囲内の敵を取得
                    MainGameCharacterModel[] target = mainGame.SearchCharacter(position, attackRange, false, true, false);
                    //ターゲット全員に対しスキルを発動
                    foreach (MainGameCharacterModel targetCharacter in target)
                    {
                        //ステートをスタンに移行
                        void EnemyStan()
                        {
                            targetCharacter.charactorState = CharacterState.Stan;
                        }
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
                        //攻撃力のn%の物理ダメージ(要検討)
                        void PlayerSkillAttack()
                        {
                            targetCharacter.AddDamage(new Damage(Damage.physicsDamage, (int)(resultingAttackPower * damageMagnification)));
                        }
                        SkillEvent SkillAttack = PlayerSkillAttack;
                        StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(mainGame, targetCharacter, 180, 1, Stan));
                        StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(mainGame, targetCharacter, 300, attackFrequency, SkillAttack));
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
                    /*
                    //ステートをスタンに移行
                    void EnemyStan()
                    {
                        charactorState = CharacterState.Stan;
                    }
                    SkillEvent Stan = EnemyStan;
                    //攻撃力のn%の物理ダメージ(要検討)
                    void PlayerSkillAttack()
                    {
                        AddDamage(new Damage(Damage.physicsDamage, Skill2Damage));
                    }
                    SkillEvent SkillAttack = PlayerSkillAttack;
                    void ObjectSkill()
                    {
                        //攻撃範囲内の敵を取得
                        MainGameCharacterModel[] target = mainGame.SearchCharacter(position, new Vector2[] { new Vector2(0,0)}, false, true, false);
                        //ターゲット全員に対しスキルを発動
                        foreach (MainGameCharacterModel targetCharacter in target)
                        {
                            StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(mainGame, targetCharacter, 300, 1, Stan));
                            StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(mainGame, targetCharacter, 0, 1, SkillAttack));
                        }
                    }
                    SkillEvent ObjectSkillEvent = ObjectSkill;
                    for (int i = 0; i < mainGame.summonsobject.Length; i++)
                    {
                        if (mainGame.summonsobject[i] != null)
                        {
                            mainGame.summonsobject[i] = gameObject.AddComponent<SummonsObject>();
                            mainGame.summonsobject[i].Initialized(mainGame,ObjectSkillEvent);
                            break;
                        }   
                    }
                    */
                }
                //最大スタック数設定
                maxSkill3Stack = 1;
                skill3Stack = maxSkill3Stack;
                //クールダウン設定
                switch (FDC.skill3level)
                {
                    case 1:
                    case 2:
                        skill3CoolDown = 900;
                        break;
                    case 3:
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
                    //攻撃範囲内の敵を取得
                    MainGameCharacterModel[] target = mainGame.SearchCharacter(position, attackRange, false, true, false);
                    //ターゲット全員に対しスキルを発動
                    foreach (MainGameCharacterModel targetCharacter in target)
                    {
                        double damageMagnification = 0;
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
                        //攻撃力のn%の物理ダメージ(要検討)
                        void PlayerSkillAttack()
                        {
                            targetCharacter.AddDamage(new Damage(Damage.physicsDamage, (int)(resultingAttackPower * damageMagnification)));
                        }
                        SkillEvent SkillAttack = PlayerSkillAttack;
                        StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(mainGame, targetCharacter, 300, 72, SkillAttack));
                    }
                }
                //最大スタック数設定
                maxUltStack = 4;
                ultStack = maxUltStack;
                switch (FDC.ultlevel)
                {
                    case 1:
                    case 2:
                        ultCost = 50;
                        break;
                    case 3:
                    case 4:
                        ultCost = 45;
                        break;
                    case 5:
                        ultCost = 40;
                        break;
                }
                ultSkillEvent = DaemonUltSkillEvent;
                void DaemonUltSkillEvent()
                {

                    //攻撃範囲内の敵を取得
                    MainGameCharacterModel[] target = mainGame.SearchCharacter(position, attackRange, false, true, false);
                    //ターゲット全員に対しスキルを発動
                    foreach (MainGameCharacterModel targetCharacter in target)
                    {
                        //StartCoroutine(new MainGameSkillEvent().DoSkillEvent(targetCharacter, 300, 72, ));
                    }
                }
                //最大スタック数設定
                maxPassiveStack = 4;
                passiveStack = 1;
                passiveSkill = DaemonPassiveSkill;
                void DaemonPassiveSkill()
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
                //攻撃頻度
                attackFrequency = 60;
                //再配置
                relocationFrame = 0;
                //レベルで変動するステータス
                if (FDC.level > 90)
                {
                    baseAttackPower = 420;
                    hp = 1000;
                    physicsDamageResistance = 160 / 20;
                }
                else if (FDC.level > 50)
                {
                    baseAttackPower = 270;
                    hp = 750;
                    physicsDamageResistance = 120 / 20;
                }
                else
                {
                    baseAttackPower = 120;
                    hp = 500;
                    physicsDamageResistance = 70 / 20;
                }
                if (FDC.credibility >= 200)
                {
                    hp += 45;
                    baseAttackPower += 20;
                    physicsDamageResistance += 20;
                }
                else if (FDC.credibility >= 150)
                {
                    hp += 15;
                    baseAttackPower += 10;
                    physicsDamageResistance += 10;
                }
                else if (FDC.credibility >= 100)
                {
                    hp += 15;
                    baseAttackPower += 10;
                    physicsDamageResistance += 10;
                }
                else if (FDC.credibility >= 50)
                {
                    hp += 15;
                    baseAttackPower += 10;
                    physicsDamageResistance += 10;
                }
                maxHp = hp;
                //視野範囲
                viewRange = new Vector2[]
                {
                    new Vector2(0,0),
                    new Vector2(0,1),
                    new Vector2(0,-1),
                    new Vector2(1,0),
                    new Vector2(1,1),
                    new Vector2(1,-1),
                    new Vector2(-1,0),
                    new Vector2(-1,1),
                    new Vector2(-1,-1),
                    new Vector2(0,2),
                    new Vector2(0,-2),
                    new Vector2(2,0),
                    new Vector2(-2,0)
                };
                //攻撃範囲
                if (Master.playerdeta.DaemonbreakingThrough2 == true)
                {
                    attackRange = new Vector2[]
                    {
                        new Vector2(0,0),
                        new Vector2(0,-1),
                        new Vector2(0,1),
                        new Vector2(1,-1),
                        new Vector2(1,0),
                        new Vector2(1,1),
                        new Vector2(2,-1),
                        new Vector2(2,0),
                        new Vector2(2,1),
                        new Vector2(3,-1),
                        new Vector2(3,0),
                        new Vector2(3,1),
                    };
                }
                else if (Master.playerdeta.DaemonbreakingThrough1 == true)
                {
                    attackRange = new Vector2[]
                    {
                        new Vector2(0,0),
                        new Vector2(0,-1),
                        new Vector2(0,1),
                        new Vector2(1,-1),
                        new Vector2(1,0),
                        new Vector2(1,1),
                        new Vector2(2,-1),
                        new Vector2(2,0),
                        new Vector2(2,1),
                    };
                }
                else
                {
                    attackRange = new Vector2[]
                    {
                        new Vector2(0,0),
                        new Vector2(1,-1),
                        new Vector2(1,0),
                        new Vector2(1,1),
                        new Vector2(2,-1),
                        new Vector2(2,0),
                        new Vector2(2,1),
                    };
                }
                //最大スタック数設定
                maxSkill1Stack = 1;
                skill1Stack = maxSkill1Stack;
                //クールダウン設定
                switch (FDC.skill1level)
                {
                    case 1:
                    case 2:
                        skill1CoolDown = 840;
                        break;
                    case 3:
                    case 4:
                        skill1CoolDown = 780;
                        break;
                    case 5:
                        skill1CoolDown = 720;
                        break;
                }
                skillEvent1 = GhostSkill1;
                void GhostSkill1()
                {
                    //攻撃範囲内の敵を取得
                    MainGameCharacterModel[] target = mainGame.SearchCharacter(position, attackRange, false, true, false);
                    //ターゲット全員に対しスキルを発動
                    foreach (MainGameCharacterModel targetCharacter in target)
                    {
                        Debug.Log(targetCharacter + "にskill1");
                        //ステートをスタンに移行
                        void EnemyStan()
                        {
                            targetCharacter.charactorState = CharacterState.Stan;
                        }
                        SkillEvent Stan = EnemyStan;
                        double damageMagnification = 0;
                        switch (FDC.skill1level)
                        {
                            case 1:
                                damageMagnification = 1.15;
                                break;
                            case 2:
                                damageMagnification = 1.2;
                                break;
                            case 3:
                                damageMagnification = 1.25;
                                break;
                            case 4:
                                damageMagnification = 1.3;
                                break;
                            case 5:
                                damageMagnification = 1.35;
                                break;
                        }
                        //攻撃力のn%の物理ダメージ(要検討)
                        void PlayerSkillAttack()
                        {
                            targetCharacter.AddDamage(new Damage(Damage.physicsDamage, (int)(baseAttackPower * damageMagnification)));
                        }
                        SkillEvent SkillAttack = PlayerSkillAttack;
                        StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(mainGame, targetCharacter, 600, 1, Stan));
                        StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(mainGame, targetCharacter, 600, attackFrequency, SkillAttack));
                    }
                }
                //最大スタック数設定
                maxSkill2Stack = 1;
                skill2Stack = maxSkill2Stack;
                switch (FDC.skill2level)
                {
                    case 1:
                    case 2:
                        skill2CoolDown = 720;
                        break;
                    case 3:
                    case 4:
                        skill2CoolDown = 360;
                        break;
                    case 5:
                        skill2CoolDown = 300;
                        break;
                }
                skillEvent2 = GhostSkill2;
                void GhostSkill2()
                {
                    //攻撃範囲内の敵を取得
                    MainGameCharacterModel[] target = mainGame.SearchCharacter(position, attackRange, false, true, false);
                    //ターゲット全員に対しスキルを発動
                    foreach (MainGameCharacterModel targetCharacter in target)
                    {
                        double damageMagnification = 0;
                        switch (FDC.skill1level)
                        {
                            case 1:
                                damageMagnification = 1.3;
                                break;
                            case 2:
                                damageMagnification = 1.5;
                                break;
                            case 3:
                                damageMagnification = 1.7;
                                break;
                            case 4:
                                damageMagnification = 1.9;
                                break;
                            case 5:
                                damageMagnification = 2.1;
                                break;
                        }
                        //攻撃力のn%の物理ダメージ(要検討)
                        void PlayerSkillAttack()
                        {
                            targetCharacter.AddDamage(new Damage(Damage.physicsDamage, (int)(baseAttackPower * damageMagnification)));
                        }
                        SkillEvent SkillAttack = PlayerSkillAttack;
                        StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(mainGame, targetCharacter, 0, 1, SkillAttack));
                    }
                }
                //最大スタック数設定
                maxSkill3Stack = 1;
                skill3Stack = maxSkill3Stack;
                switch (FDC.skill3level)
                {
                    case 1:
                    case 2:
                        skill3CoolDown = 600;
                        break;
                    case 3:
                    case 4:
                        skill3CoolDown = 540;
                        break;
                    case 5:
                        skill3CoolDown = 480;
                        break;
                }
                skillEvent3 = GhostSkill3;
                void GhostSkill3()
                {
                    //攻撃範囲内の敵を取得
                    MainGameCharacterModel[] target = mainGame.SearchCharacter(position, attackRange, false, true, false);
                    //ターゲット全員に対しスキルを発動
                    foreach (MainGameCharacterModel targetCharacter in target)
                    {
                        double damageMagnification = 0;
                        switch (FDC.skill1level)
                        {
                            case 1:
                                damageMagnification = 0.05;
                                break;
                            case 2:
                                damageMagnification = 0.07;
                                break;
                            case 3:
                                damageMagnification = 0.09;
                                break;
                            case 4:
                                damageMagnification = 0.11;
                                break;
                            case 5:
                                damageMagnification = 0.13;
                                break;
                        }
                        //攻撃力のn%の物理ダメージ(要検討)
                        void PlayerSkillAttack()
                        {
                            targetCharacter.AddDamage(new Damage(Damage.physicsDamage, (int)(baseAttackPower * damageMagnification)));
                        }
                        SkillEvent SkillAttack = PlayerSkillAttack;
                        StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(mainGame, targetCharacter, 300, attackFrequency, SkillAttack));
                    }
                }
                //最大スタック数設定
                maxUltStack = 1;
                ultStack = maxUltStack;
                switch (FDC.ultlevel)
                {
                    case 1:
                    case 2:
                        ultCost = 40;
                        break;
                    case 3:
                    case 4:
                        ultCost = 35;
                        break;
                    case 5:
                        ultCost = 30;
                        break;
                }
                ultSkillEvent = GhostUltSkillEvent;
                void GhostUltSkillEvent()
                {
                    //攻撃範囲内の敵を取得
                    MainGameCharacterModel[] target = mainGame.SearchCharacter(position,attackRange, false, true, false);
                    //ターゲット全員に対しスキルを発動
                    foreach (MainGameCharacterModel targetCharacter in target)
                    {
                        double damageMagnification1 = 0;
                        switch (FDC.skill1level)
                        {
                            case 1:
                                damageMagnification1 = 5;
                                break;
                            case 2:
                                damageMagnification1 = 6;
                                break;
                            case 3:
                                damageMagnification1 = 7;
                                break;
                            case 4:
                                damageMagnification1 = 8;
                                break;
                            case 5:
                                damageMagnification1 = 9;
                                break;
                        }
                        //攻撃力のn%の物理ダメージ(要検討)
                        void PlayerSkillAttack1()
                        {
                            targetCharacter.AddDamage(new Damage(Damage.physicsDamage, (int)(baseAttackPower * damageMagnification1)));
                        }
                        SkillEvent SkillAttack1 = PlayerSkillAttack1;
                        double damageMagnification2 = 0;
                        switch (FDC.skill1level)
                        {
                            case 1:
                                damageMagnification2 = 0.10;
                                break;
                            case 2:
                                damageMagnification2 = 0.15;
                                break;
                            case 3:
                                damageMagnification2 = 0.20;
                                break;
                            case 4:
                                damageMagnification2 = 0.25;
                                break;
                            case 5:
                                damageMagnification2 = 0.30;
                                break;
                        }
                        //攻撃力のn%の物理ダメージ(要検討)
                        void PlayerSkillAttack2()
                        {
                            targetCharacter.AddDamage(new Damage(Damage.physicsDamage, (int)(baseAttackPower * damageMagnification2)));
                        }
                        SkillEvent SkillAttack2 = PlayerSkillAttack2;
                        StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(mainGame, targetCharacter, 0, 1, SkillAttack1));
                        StartCoroutine(gameObject.AddComponent<MainGameSkillEvent>().DoSkillEvent(mainGame, targetCharacter, 600, attackFrequency, SkillAttack2));
                    }
                }
                //最大スタック数設定
                maxPassiveStack = 4;
                passiveStack = 1;
                passiveSkill = GhostPassiveSkill;
                void GhostPassiveSkill()
                {
                    grudgeAmountIncreasePercentage = 1.1f;
                }
                break;
                switch (artifact1.)
        }
    }

    void SkillButtonEnable()
    {

        if (myNumber == 1)
        {
            if (skill1Cool == true && lateSkill1Cool == false)
            {
                mainGame.buttonManager.ButtoEnableByName("Character1Skill1");
            }
            if (skill2Cool == true && lateSkill2Cool == false)
            {
                mainGame.buttonManager.ButtoEnableByName("Character1Skill2");
            }
            if (skill3Cool == true && lateSkill3Cool == false)
            {
                mainGame.buttonManager.ButtoEnableByName("Character1Skill3");
            }
        }
        if (myNumber == 2)
        {
            if (skill1Cool == true)
            {
                mainGame.buttonManager.ButtoEnableByName("Character2Skill1");
            }
            if (skill2Cool == true)
            {
                mainGame.buttonManager.ButtoEnableByName("Character2Skill2");
            }
            if (skill3Cool == true)
            {
                mainGame.buttonManager.ButtoEnableByName("Character2Skill3");
            }
        }
        lateSkill1Cool = skill1Cool;
        lateSkill2Cool = skill2Cool;
        lateSkill3Cool = skill3Cool;
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
