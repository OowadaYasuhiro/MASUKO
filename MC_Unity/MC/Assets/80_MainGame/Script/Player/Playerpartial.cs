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
        player = true;
        if (number == 1)
        {
            Charactor FDC1 = (Charactor)Master.formationdeta.selectcharactor1;
            Charactorname = FDC1.name;
            artifact1 = Master.formationdeta.charactor1Artifacts[0];
            artifact2 = Master.formationdeta.charactor1Artifacts[1];
            artifact3 = Master.formationdeta.charactor1Artifacts[2];
            switch (name)
            {
                case Daemon:
                    skillEvent1 = DaemonSkill1;
                    void DaemonSkill1()
                    {
                        SkillEvent Stan = EnemyStan;
                        //ステートをスタンに移行
                        void EnemyStan()
                        {
                            charactorState = CharactorState.Stan;
                        }
                        SkillEvent SkillAttack = PlayerSkillAttack;
                        //攻撃力の10%の物理ダメージ(要検討)
                        void PlayerSkillAttack()
                        {
                            AddDamage(new Damage(Damage.physicsDamage,(int)(resultingAttackPower * 0.1)));
                        }
                        //攻撃範囲内の敵を取得
                        MainGameCharactorModel[] target = mainGame.SearchCharactor(attackRange,false,true,false);
                        //ターゲット全員に対しスキルを発動
                        foreach (MainGameCharactorModel targetCharactor in target)
                        {
                            StartCoroutine(DoSkillEvent( targetCharactor, 180, 1, Stan));
                            StartCoroutine(DoSkillEvent( targetCharactor, 300, 72,SkillAttack));
                        }

                        
                    }
                    skillEvent2 = DaemonSkill2;
                    void DaemonSkill2()
                    {

                    }
                    skillEvent3 = DaemonSkill3;
                    void DaemonSkill3()
                    {

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
        if (number == 2)
        {
            Charactor FDC2 = (Charactor)Master.formationdeta.selectcharactor2;
            Charactorname = FDC2.name;
            artifact1 = Master.formationdeta.charactor2Artifacts[0];
            artifact2 = Master.formationdeta.charactor2Artifacts[1];
            artifact3 = Master.formationdeta.charactor2Artifacts[2];
        }
    }

}
