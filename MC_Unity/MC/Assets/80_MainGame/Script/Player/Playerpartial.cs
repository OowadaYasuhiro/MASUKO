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

                List<Artifact> artifacts = new List<Artifact>();
                artifacts.Add(artifact1);
                artifacts.Add(artifact2);
                artifacts.Add(artifact3);
                string seriesName = "";
                int seriesStack = 0;
                foreach (Artifact artifact in artifacts)
                {
                    switch (artifact.name)
                    {
                        case Huanokan:
                        case Onnnennokan:
                            if (artifact.level >= 15)
                            {
                                resultingAttackPower += 12;
                            }
                            else if (artifact.level >= 10)
                            {
                                resultingAttackPower += 8;
                            }
                            else
                            {
                                resultingAttackPower += 2;
                            }
                            goto SeriesCheck;
                            break;
                        case Rekisennokan:
                        case Yujyounokan:
                            if (artifact.level >= 20)
                            {
                                resultingAttackPower += 26;
                            }
                            else if (artifact.level >= 10)
                            {
                                resultingAttackPower += 15;
                            }
                            else
                            {
                                resultingAttackPower += 5;
                            }
                            goto SeriesCheck;
                            break;
                        case Akatukinokan:
                            if (artifact.level >= 25)
                            {
                                resultingAttackPower += 38;
                            }
                            else if (artifact.level >= 20)
                            {
                                resultingAttackPower += 32;
                            }
                            else if (artifact.level >= 10)
                            {
                                resultingAttackPower += 23;
                            }
                            else
                            {
                                resultingAttackPower += 10;
                            }
                            goto SeriesCheck;
                            break;
                        case Huanoudewa:
                        case Onnnennoudewa:
                            if (artifact.level >= 15)
                            {
                                physicsDamageResistance += 12;
                            }
                            else if (artifact.level >= 10)
                            {
                                physicsDamageResistance += 8;
                            }
                            else
                            {
                                physicsDamageResistance += 2;
                            }
                            goto SeriesCheck;
                            break;
                        case Rekisennoudewa:
                        case Yujyounoudewa:
                            if (artifact.level >= 20)
                            {
                                physicsDamageResistance += 26;
                            }
                            else if (artifact.level >= 10)
                            {
                                physicsDamageResistance += 15;
                            }
                            else
                            {
                                physicsDamageResistance += 5;
                            }
                            goto SeriesCheck;
                            break;
                        case Akatukinoudewa:
                            if (artifact.level >= 25)
                            {
                                physicsDamageResistance += 38;
                            }
                            else if (artifact.level >= 20)
                            {
                                physicsDamageResistance += 32;
                            }
                            else if (artifact.level >= 10)
                            {
                                physicsDamageResistance += 23;
                            }
                            else
                            {
                                physicsDamageResistance += 10;
                            }
                            goto SeriesCheck;
                            break;
                        case Huanoyubiwa:
                        case Onnnennoyubiwa:
                            if (artifact.level >= 15)
                            {
                                hp = 45;
                                maxHp = 45;
                            }
                            else if (artifact.level >= 10)
                            {
                                hp = 35;
                                maxHp = 35;
                            }
                            else
                            {
                                hp = 25;
                                maxHp = 25;
                            }
                            goto SeriesCheck;
                            break;
                        case Rekisennoyubiwa:
                        case Yujyounoyubiwa:
                            if (artifact.level >= 20)
                            {
                                hp = 58;
                                maxHp = 58;
                            }
                            else if (artifact.level >= 10)
                            {
                                hp = 48;
                                maxHp = 48;
                            }
                            else
                            {
                                hp = 30;
                                maxHp = 30;
                            }
                            goto SeriesCheck;
                            break;
                        case Akatukinoyubiwa:
                            if (artifact.level >= 25)
                            {
                                hp = 72;
                                maxHp = 72;
                            }
                            else if (artifact.level >= 20)
                            {
                                hp = 63;
                                maxHp = 63;
                            }
                            else if (artifact.level >= 10)
                            {
                                hp = 52;
                                maxHp = 52;
                            }
                            else
                            {
                                hp = 35;
                                maxHp = 35;
                            }
                            goto SeriesCheck;
                            break;
                        SeriesCheck:
                            string tmpSeriesName = "";
                            if (artifact.name.EndsWith("冠"))
                            {
                                tmpSeriesName = artifact.name.Substring(0, artifact.name.Length - 6);
                            }
                            if (artifact.name.EndsWith("腕輪"))
                            {
                                tmpSeriesName = artifact.name.Substring(0, artifact.name.Length - 8);
                            }
                            if (artifact.name.EndsWith("指輪"))
                            {
                                tmpSeriesName = artifact.name.Substring(0, artifact.name.Length - 9);
                            }
                            if (seriesName == "")
                            {
                                seriesName = tmpSeriesName;
                            }
                            else if (seriesName == tmpSeriesName)
                            {
                                seriesStack++;
                                if (seriesStack == 2)
                                {
                                    switch (seriesName)
                                    {
                                        case "Hua":
                                            relocationFrame -= 120;
                                            break;
                                        case "Onnnen":
                                            resultingAttackPower += 5;
                                            break;
                                        case "Rekisen":
                                            skill1CoolDown -= 60;
                                            skill2CoolDown -= 60;
                                            skill3CoolDown -= 60;
                                            break;
                                        case "Yujyou":
                                            physicsDamageResistance += 13;
                                            break;
                                        case "Akatuki":
                                            skill1CoolDown -= 60;
                                            skill2CoolDown -= 60;
                                            skill3CoolDown -= 60;
                                            int useSkillCount = 0;
                                            void bonusSeriesSkill()
                                            {
                                                if ((skill1 == true && skill1Cool == true) || (skill2 == true && skill2Cool == true) || (skill3 == true && skill3Cool == true))
                                                {
                                                    useSkillCount++;
                                                    if (useSkillCount == 3)
                                                    {
                                                        resultingAttackPower = (int)(resultingAttackPower * 1.2);
                                                    }
                                                }
                                            }
                                            relicSkill = bonusSeriesSkill;
                                            break;
                                    }
                                }
                            }
                            break;
                    }
                }
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
