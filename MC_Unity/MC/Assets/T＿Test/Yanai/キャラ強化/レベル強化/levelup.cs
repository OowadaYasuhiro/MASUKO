using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class levelup : MonoBehaviour
{
    [SerializeField] Text HP;
    [SerializeField] Text Atk;
    [SerializeField] Text Def;
    [SerializeField] Text EXPP;
    [SerializeField] Text LV;
    //変数宣言
    bool pushnow;
    bool Release;
    bool check;
    int i;
    int sumHP;
    int sumAtk;
    int sumDef;
    int sum1HP;
    int sum1Atk;
    int sum1Def;
    //レベルアップウィンドウ
    [SerializeField] GameObject levelupOB;
    [SerializeField] Text HPUP;
    [SerializeField] Text AtkUP;
    [SerializeField] Text DefUP;
    [SerializeField] Text LvUP;
    [SerializeField] Text LHP;
    [SerializeField] Text LAtk;
    [SerializeField] Text LDef;
    //ナウのレベル
    int nowlevel;
    //レベルアップの文字
    [SerializeField] GameObject LVUPText;

    //レベルアップの経験値テーブル
    int[] exp = new int[91];
    void OnEnable() {
        keikeintiTE();
        pushnow = false;
        Release = false;
        check = true;
        levelupOB.SetActive(false);
        i = 0;
        syokiti();
        EXPP.text = $"{exp[nowlevel]}/{Master.playerdeta.Zanryu_Sinen}";
        LV.text = $"Lv {nowlevel}";
    }

    // Update is called once per frame
    void Update()
    {
        
        //ボタンを押しているとき
        if (pushnow == true)
        {
            //ボタンを離すまで
            if(Release == false&&nowlevel+i<90) { 

            //レベルを上げる素材が足りているか
            if(exp[nowlevel+i]<= Master.playerdeta.Zanryu_Sinen )
            {
                if (check == true)
                {
                     GameObject lvupText = Instantiate(LVUPText) ;
                        lvupText.transform.SetParent(transform.parent,false);

                        i++;
                    //遅らせる
                    check = false;
                    if (i <= 2)
                        Invoke("Delay", 0.5f);
                    else if (i < 4)
                        Invoke("Delay", 0.25f);
                        else { 
                        Invoke("Delay", 0.15f);
                    }
                    Master.playerdeta.Zanryu_Sinen -=exp[nowlevel+i-1];
                    switch (Master.playerdeta.NowSelectCharactor)
                    {
                        case "Ghost":
                            if (Master.playerdeta.GhostLevel <= 50)
                            {
                                sumHP = i * 5;
                                sumAtk = i * 3;
                                sumDef = i;
                            }
                            else
                            {
                                sumHP = (int)(i * 6.25);
                                sumAtk = (int)(3.75 * i);
                                sumDef = i;
                            }
                            break;
                        case "Zashiki_warashi":
                            if (Master.playerdeta.Zashiki_warashiLevel <= 50)
                            {
                                sumHP = i * 12;
                                sumAtk = i;
                                sumDef = i * 2;
                            }
                            else
                            {
                                sumHP = (int)(17.5 * i);
                                sumAtk = (int)(1.25 * i);
                                sumDef = (int)(3.75 * i);
                            }
                            break;
                        case "Gore":
                            if (Master.playerdeta.GoreLevel <= 50)
                            {
                                sumHP = i * 11;
                                sumAtk = i;
                                sumDef = i * 2;
                            }
                            else
                            {
                                sumHP = (int)(32.5 * i);
                                sumAtk = (int)(3.75 * i);
                                sumDef = (int)(2.5 * i);
                            }
                            break;
                        case "Poltergeist":
                            if (Master.playerdeta.PoltergeistLevel <= 50)
                            {
                                sumHP = (int)(i * 6.6);
                                sumAtk = (int)(i * 2.6);
                                sumDef = (int)(0.5 * i);
                            }
                            else
                            {
                                sumHP = (int)(18.75 * i);
                                sumAtk = (int)(3.5 * i);
                                sumDef = (int)(1.25 * i);
                            }
                            break;
                        case "Daemon":
                            if (Master.playerdeta.DaemonLevel <= 50)
                            {
                                sumHP = i * 3;
                                sumAtk = i * 3;
                                sumDef = i * (int)(0.6 * i);
                            }
                            else
                            {
                                sumHP = (15 * i);
                                sumAtk = (int)(4.75 * i);
                                sumDef = (int)(1.25 * i);
                            }
                            break;
                    }
                }
                } else {
                    Release = true;
                }
                  HP.text = "+" + sumHP;
                  Atk.text = "+" + sumAtk;
                  Def.text = "+" + sumDef;
                  LV.text = $"Lv {nowlevel+i}";
                  EXPP.text = $"{exp[nowlevel+i]}/{Master.playerdeta.Zanryu_Sinen}";
            }
            else {
            //一回でもレベルアップしているか
               if(i >= 1) {
                    pushnow = false;
                    Release = false;
                //レベルアップのウィンドウを表示
                   levelupOB.SetActive(true);
                   HPUP.text = $"+{sumHP}";
                   AtkUP.text = $"+{sumAtk}";
                   DefUP.text = $"+{sumDef}";
                   LvUP.text = $"Lv{nowlevel}→Lv{nowlevel + i}";
                            nowlevel += i;
                   switch(Master.playerdeta.NowSelectCharactor) {
                    case "Ghost": {
                                LHP.text = $"{hairetu.GhostHP[Master.playerdeta.GhostLevel]}";
                                LAtk.text = $"{hairetu.GhostAtk[Master.playerdeta.GhostLevel]}";
                                LDef.text = $"{hairetu.GhostDef[Master.playerdeta.GhostLevel]}";
                                Master.playerdeta.GhostLevel = nowlevel;
                            break;
                        }
                    case "Zashiki_warashi": {
                                LHP.text = $"{hairetu.ZasikiHP[Master.playerdeta.Zashiki_warashiLevel]}";
                                LAtk.text = $"{hairetu.ZasikiAtk[Master.playerdeta.Zashiki_warashiLevel]}";
                                LDef.text = $"{hairetu.ZasikiDef[Master.playerdeta.Zashiki_warashiLevel]}";
                                Master.playerdeta.Zashiki_warashiLevel = nowlevel;
                            break;
                        }
                    case "Gore": {
                                LHP.text = $"{hairetu.GoreHP[Master.playerdeta.GoreLevel]}";
                                LAtk.text = $"{hairetu.GoreAtk[Master.playerdeta.GoreLevel]}";
                                LDef.text = $"{hairetu.GoreDef[Master.playerdeta.GoreLevel]}";
                                Master.playerdeta.GoreLevel = nowlevel;
                            break;
                        }
                    case "Poltergeist": {
                                LHP.text = $"{hairetu.PorutaHP[Master.playerdeta.PoltergeistLevel]}";
                                LAtk.text = $"{hairetu.PorutaAtk[Master.playerdeta.PoltergeistLevel]}";
                                LDef.text = $"{hairetu.PorutaDef[Master.playerdeta.PoltergeistLevel]}";
                                Master.playerdeta.PoltergeistLevel = nowlevel;
                            break;
                        }
                    case "Daemon": {
                                LHP.text = $"{hairetu.DEmonHP[Master.playerdeta.DaemonLevel]}";
                                LAtk.text = $"{hairetu.DEmonAtk[Master.playerdeta.DaemonLevel]}";
                                LDef.text = $"{hairetu.DEmonDef[Master.playerdeta.DaemonLevel]}";
                                Master.playerdeta.DaemonLevel = nowlevel;
                            break;
                        }
                }
                   syokiti();
                    i=0;
               }
            }
        }
    }
    //ボタンを押しているとき
    public void  IsPush()
    {
        pushnow = true;
    }
    //ボタンを離したとき
    public void IsRelease()
    {
        Release = true;
    }
    void Delay()
    {
        check = true;
    }
    /*ボタンを押せなかったときにボタンがバグるような気がします*/
    /*-----------------------------------------------------*/
        void syokiti() {
    switch(Master.playerdeta.NowSelectCharactor) {
            case "Ghost":
                nowlevel = Master.playerdeta.GhostLevel;
                if(Master.playerdeta.GhostLevel <= 50) {
                    sum1HP = 5;
                    sum1Atk = 3;
                    sum1Def = 1;
                } else {
                     sum1HP = (int)6.25;
                      sum1Atk = (int)3.75;
                       sum1Def = 1;
            }
            break;
       case "Zashiki_warashi":
            nowlevel = Master.playerdeta.Zashiki_warashiLevel;
                    if(Master.playerdeta.Zashiki_warashiLevel <= 50) {
                        sum1HP = 12;
                        sum1Atk = 1;
                        sum1Def = 2;
                    } else {
                        sum1HP = (int)17.5;
                        sum1Atk = (int)1.25;
                        sum1Def = (int)3.75;
                    }
                    break;
        case "Gore":
                                 nowlevel = Master.playerdeta.GoreLevel;
                    if(Master.playerdeta.GoreLevel <= 50) {
                        sum1HP = 11;
                        sum1Atk = 1;
                        sum1Def = 2;
                    } else {
                        sum1HP = (int)32.5;
                        sum1Atk = (int)3.75;
                        sum1Def = (int)2.5;
                    }
                    break;
       case "Poltergeist":
                                    nowlevel = Master.playerdeta.PoltergeistLevel;
                    if(Master.playerdeta.PoltergeistLevel <= 50) {
                        sum1HP = (int)6.6;
                        sum1Atk = (int)2.6;
                        sum1Def = (int)0.5;
                    } else {
                        sum1HP = (int)18.75;
                        sum1Atk = (int)3.5;
                        sum1Def = (int)1.25;
                    }
                    break;
       case "Daemon":
                                    nowlevel = Master.playerdeta.DaemonLevel;
                    if(Master.playerdeta.DaemonLevel <= 50) {
                        sum1HP = 3;
                        sum1Atk = 3;
                        sum1Def = (int)0.6;
                    } else {
                        sum1HP = 15;
                        sum1Atk = (int)4.75;
                        sum1Def = (int)1.25;
                    }
                    break;
                            }
                                 if(nowlevel == 90) {
                                HP.text = "--" ;
                                Atk.text = "--" ;
                                Def.text = "--" ;
                                sumHP = sum1HP;
                                sumAtk = sum1Atk;
                                sumDef = sum1Def;
                            } else { 
                            HP.text = "+" + sum1HP;
                            Atk.text = "+" + sum1Atk;
                            Def.text = "+" + sum1Def;
                            sumHP = sum1HP;
                            sumAtk = sum1Atk;
                            sumDef = sum1Def;
                            }
        } 
    void keikeintiTE() {
        double tmp;
        exp[1]=10;
        for (int i=1; i < 90; i++) {
            tmp =exp[i]*1.1;
            exp[1+i]=(int)Math.Round(tmp, MidpointRounding.AwayFromZero);
            
        }
    }
}
