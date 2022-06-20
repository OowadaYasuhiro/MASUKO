using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillmanager : MonoBehaviour
{
    [SerializeField] GameObject material1;
    [SerializeField] GameObject material1t;
    [SerializeField] GameObject material2;
    [SerializeField] GameObject material2t;
    [SerializeField] GameObject material3;
    [SerializeField] GameObject material3t;
    [SerializeField] GameObject skill_low;
    [SerializeField] GameObject skill_up;
    [SerializeField] GameObject Coin;
    [SerializeField] Text skilltext;
    //強化素材パネルの大本
    [SerializeField] GameObject panel;
    //レベルマックスの時に表示するやつ
    [SerializeField]Text levelmaxtext;
    //レベルマックスを知らせるやつ
    [SerializeField]Text LM;

    //skillup変数用宣言
    [SerializeField] Text skilllevel;
    [SerializeField] Text cooldown;
    [SerializeField] Text kyouka_mae;
    [SerializeField] Text kyouka_go;
    //end
    int NowSkilllevel;
    Text CoinCom;
    int selectskill;
    // Start is called before the first frame update
    void OnEnable()
    {
        // material1t.GetComponent<Text>();
        material1.gameObject.SetActive(true);
        CoinCom = Coin.gameObject.GetComponent<Text>();
        selectskill = 1;
        switch (Master.playerdeta.NowSelectCharactor)
        {
            case "Ghost":
                lv(Master.playerdeta.GhostSkill1Level);
                skilltext.text = "金縛り";
                break;
            case "Zashiki_warashi":
                lv(Master.playerdeta.Zashiki_warashiSkill1Level);
                skilltext.text = "人間の分際で";
                break;
            case "Gore":
                lv(Master.playerdeta.GoreSkill1Level);
                skilltext.text = "鬼の型";
                break;
            case "Poltergeist":
                lv(Master.playerdeta.PoltergeistSkill1Level);
                skilltext.text = "癒してあげる";
                break;
            case "Daemon":
                lv(Master.playerdeta.DaemonSkill1Level);
                skilltext.text = "百足の虫　死して僵れず";
                break;
        }
    }

    // Update is called once per frame
    public void skill1()
    {
        selectskill = 1;
        selectname(selectskill);
        switch (Master.playerdeta.NowSelectCharactor)
        {
            case "Ghost":
                lv(Master.playerdeta.GhostSkill1Level);
                break;
            case "Zashiki_warashi":
                lv(Master.playerdeta.Zashiki_warashiSkill1Level);
                break;
            case "Gore":
                lv(Master.playerdeta.GoreSkill1Level);
                break;
            case "Poltergeist":
                lv(Master.playerdeta.PoltergeistSkill1Level);
                break;
            case "Daemon":
                lv(Master.playerdeta.DaemonSkill1Level);
                break;
        }
    }
    public void skill2()
    {
        selectskill = 2;
        selectname(selectskill);
        switch (Master.playerdeta.NowSelectCharactor)
        {
            case "Ghost":
                lv(Master.playerdeta.GhostSkill2Level);
                break;
            case "Zashiki_warashi":
                lv(Master.playerdeta.Zashiki_warashiSkill2Level);
                break;
            case "Gore":
                lv(Master.playerdeta.GoreSkill2Level);
                break;
            case "Poltergeist":
                lv(Master.playerdeta.PoltergeistSkill2Level);
                break;
            case "Daemon":
                lv(Master.playerdeta.DaemonSkill2Level);
                break;
        }

    }
    public void skill3()
    {
        selectskill = 3;
        selectname(selectskill);
        switch (Master.playerdeta.NowSelectCharactor)
        {
            case "Ghost":
                lv(Master.playerdeta.GhostSkill3Level);
                break;
            case "Zashiki_warashi":
                lv(Master.playerdeta.Zashiki_warashiSkill3Level);
                break;
            case "Gore":
                lv(Master.playerdeta.GoreSkill3Level);
                break;
            case "Poltergeist":
                lv(Master.playerdeta.PoltergeistSkill3Level);
                break;
            case "Daemon":
                lv(Master.playerdeta.DaemonSkill3Level);
                break;
        }

    }
    public void skill4()
    {
        selectskill = 4;
        selectname(selectskill);
        switch (Master.playerdeta.NowSelectCharactor)
        {
            case "Ghost":
                lv(Master.playerdeta.GhostUltLevel);
                break;
            case "Zashiki_warashi":
                lv(Master.playerdeta.Zashiki_warashiUltLevel);
                break;
            case "Gore":
                lv(Master.playerdeta.GoreUltLevel);
                break;
            case "Poltergeist":
                lv(Master.playerdeta.PoltergeistUltLevel);
                break;
            case "Daemon":
                lv(Master.playerdeta.DaemonUltLevel);
                break;
        }

    }


    void lv(int i)
        {
        NowSkilllevel = i;
            switch (i)
            {
                case 1:
                    {
                    panel.gameObject.SetActive(true);
                    levelmaxtext.gameObject.SetActive(false);
                    material1.gameObject.SetActive(true);
                        Text text1 = material1t.gameObject.GetComponent<Text>();
                        text1.text = $"{Master.playerdeta.Kosyo}/3";
                        material2.gameObject.SetActive(false);
                        material3.gameObject.SetActive(false);
                        CoinCom.text = "2500";
                      break;
                    }
                case 2:
                    {
                    panel.gameObject.SetActive(true);
                    levelmaxtext.gameObject.SetActive(false);
                    material1.gameObject.SetActive(true);
                        Text text2 = material1t.gameObject.GetComponent<Text>();
                        text2.text = $"{Master.playerdeta.Kosyo}/6";
                    material2.gameObject.SetActive(false);
                        material3.gameObject.SetActive(false);
                        CoinCom.text = "5000";
                          break;
                    }
                case 3:
                    {
                    panel.gameObject.SetActive(true);
                    levelmaxtext.gameObject.SetActive(false);
                    material1.gameObject.SetActive(true);
                        Text text3 = material1t.gameObject.GetComponent<Text>();
                        text3.text = $"{Master.playerdeta.Kosyo}/6";
                        material2.gameObject.SetActive(true);
                        Text text4 = material2t.gameObject.GetComponent<Text>();
                        text4.text = $"{ Master.playerdeta.Ikotu}/2";
                        material3.gameObject.SetActive(false);
                        CoinCom.text = "10000";
                       break;
                    }
                case 4:
                    {
                    panel.gameObject.SetActive(true);
                    levelmaxtext.gameObject.SetActive(false);
                    material1.gameObject.SetActive(true);
                        Text text31 = material1t.gameObject.GetComponent<Text>();
                        text31.text = $"{Master.playerdeta.Kosyo}/6";
                    material2.gameObject.SetActive(true);
                        Text text41 = material2t.gameObject.GetComponent<Text>();
                        text41.text = $"{Master.playerdeta.Ikotu}/4";
                        material3.gameObject.SetActive(false);
                        CoinCom.text = "20000";
                        break;
                    }
                case 5:
                    {
                    panel.gameObject.SetActive(true);
                    levelmaxtext.gameObject.SetActive(false);
                    material1.gameObject.SetActive(true);
                        Text text32 = material1t.gameObject.GetComponent<Text>();
                        text32.text = $"{Master.playerdeta.Kosyo}/6";
                    material2.gameObject.SetActive(true);
                        Text text42 = material2t.gameObject.GetComponent<Text>();
                        text42.text = $"{Master.playerdeta.Ikotu}/4";
                    material3.gameObject.SetActive(true);
                        Text text43 = material3t.gameObject.GetComponent<Text>();
                        text43.text = $"{Master.playerdeta.Ningennnoti}/1";
                    CoinCom.text = "35000";
                        break;
                    }
                case 6: 
                {
                    panel.gameObject.SetActive(false);
                    CoinCom.text = "----";
                    levelmaxtext.gameObject.SetActive(true);
                    break;
                }
            }
    }

    void selectname(int i) {
        switch(i) {
            case 1:{
                    switch(Master.playerdeta.NowSelectCharactor) {
                        case "Ghost":
                            skilltext.text = "金縛り";
                            break;
                        case "Zashiki_warashi":
                            skilltext.text = "人間の分際で";
                            break;
                        case "Gore":
                            skilltext.text = "鬼の型";
                            break;
                        case "Poltergeist":
                            skilltext.text = "癒してあげる";
                            break;
                        case "Daemon":
                            skilltext.text = "百足の虫　死して僵れず";
                            break;
                    }
                    break;
            }
            case 2: {
                    switch(Master.playerdeta.NowSelectCharactor) {
                        case "Ghost":
                            skilltext.text = "人魂";
                            break;
                        case "Zashiki_warashi":
                            skilltext.text = "意外ともろいのね？";
                            break;
                        case "Gore":
                            skilltext.text = "虎の型";
                            break;
                        case "Poltergeist":
                            skilltext.text = "近づかないで";
                            break;
                        case "Daemon":
                            skilltext.text = "蜘蛛糸牢";
                            break;
                    }
                    break;
            }
            case 3: {
                    switch(Master.playerdeta.NowSelectCharactor) {
                        case "Ghost":
                            skilltext.text = "呪言";
                            break;
                        case "Zashiki_warashi":
                            skilltext.text = "何がしたいの？";
                            break;
                        case "Gore":
                            skilltext.text = "龍の型";
                            break;
                        case "Poltergeist":
                            skilltext.text = "熊さん行って";
                            break;
                        case "Daemon":
                            skilltext.text = "毒如蛇蠍";
                            break;
                    }
                    break;
            }
            case 4: {
                    switch(Master.playerdeta.NowSelectCharactor) {
                        case "Ghost":
                            skilltext.text = "魂蝕";
                            break;
                        case "Zashiki_warashi":
                            skilltext.text = "もう帰って頂戴";
                            break;
                        case "Gore":
                            skilltext.text = "怪力乱神";
                            break;
                        case "Poltergeist":
                            skilltext.text = "やっちゃえ";
                            break;
                        case "Daemon":
                            skilltext.text = "蟲の戯れ　百足牢材";
                            break;
                    }
                    break;
                }

        }
    }
    bool kyoukaseikou(int i) {
        switch(i) {
            case 1: {
                    if(Master.playerdeta.Kosyo >= 3&& Master.playerdeta.Coin >= 2500 &&genkai(1) ) {
                        Master.playerdeta.Kosyo -=3;
                        Master.playerdeta.Coin -=2500;
                        return true;
                    } else {
                        return false;
                    }
            }
            case 2: {
                    if(Master.playerdeta.Kosyo >= 6 && Master.playerdeta.Coin >= 5000 && genkai(2)) {
                        Master.playerdeta.Kosyo -= 6;
                        Master.playerdeta.Coin -= 5000;
                        return true;
                    }
                    break;
            }
            case 3: {
                    if(Master.playerdeta.Kosyo >= 6 && Master.playerdeta.Ikotu >= 2 && Master.playerdeta.Coin >= 10000 && genkai(3)) {
                        Master.playerdeta.Kosyo -= 6;
                        Master.playerdeta.Ikotu -= 2;
                        Master.playerdeta.Coin -= 10000;
                        return true;
                    } else {
                        return false;
                    }
            }
            case 4: {
                    if(Master.playerdeta.Kosyo >= 6 && Master.playerdeta.Ikotu >= 4 && Master.playerdeta.Coin >= 20000 && genkai(4)) {
                        Master.playerdeta.Kosyo -= 6;
                        Master.playerdeta.Ikotu -= 4;
                        Master.playerdeta.Coin -= 20000;
                        return true;
                    } else {
                        return false;
                    }
            }
            case 5: {
                    if(Master.playerdeta.Kosyo >= 6 && Master.playerdeta.Ikotu >= 4 && Master.playerdeta.Ningennnoti >= 1 && Master.playerdeta.Coin >= 35000 && genkai(5)) {
                        Master.playerdeta.Kosyo -= 6;
                        Master.playerdeta.Ikotu -= 4;
                        Master.playerdeta.Ningennnoti -= 1;
                        Master.playerdeta.Coin -= 35000;
                        return true;
                    } else {
                        return false;
                    }
                }
            default:

                    return false;
        }
        return false;
    }
    public void kyouka() {
        switch(Master.playerdeta.NowSelectCharactor) {
            case "Ghost": {
                    if(kyoukaseikou(NowSkilllevel) == true) {
                        skillup(NowSkilllevel,selectskill);
                        skill_up.gameObject.SetActive(true);
                        NowSkilllevel++;
                    } else {
                        skill_low.gameObject.SetActive(true);
                        if(NowSkilllevel == 6) {
                            LM.text = "レベルがマックスです。";
                        } else {
                            LM.text = "素材が足りません。";
                        }
                }
                    break;    
            }
            case "Zashiki_warashi": { 
                if(kyoukaseikou(NowSkilllevel) == true) {
                        skillup(NowSkilllevel, selectskill);
                        skill_up.gameObject.SetActive(true);
                        NowSkilllevel++;
                    } else {
                    skill_low.gameObject.SetActive(true);
                        if(NowSkilllevel == 6) {
                            LM.text = "レベルがマックスです。";
                        } else {
                            LM.text = "素材が足りません。";
                        }
                    }
                    break;
            }
            case "Gore": { 
                if(kyoukaseikou(NowSkilllevel) == true) {
                        skillup(NowSkilllevel, selectskill);
                        skill_up.gameObject.SetActive(true);
                        NowSkilllevel++;
                    } else {
                    skill_low.gameObject.SetActive(true);
                        if(NowSkilllevel == 6) {
                            LM.text = "レベルがマックスです。";
                        } else {
                            LM.text = "素材が足りません。";
                        }
                    }
                    break;
            }
            case "Poltergeist": { 
                if(kyoukaseikou(NowSkilllevel) == true) {
                        skillup(NowSkilllevel, selectskill);
                        skill_up.gameObject.SetActive(true);
                        NowSkilllevel++;
                    } else {
                    skill_low.gameObject.SetActive(true);
                        if(NowSkilllevel == 6) {
                            LM.text = "レベルがマックスです。";
                        } else {
                            LM.text = "素材が足りません。";
                        }
                    }
                break;
            }
            case "Daemon": { 
                if(kyoukaseikou(NowSkilllevel) == true) {
                        skillup(NowSkilllevel, selectskill);
                        skill_up.gameObject.SetActive(true);
                        NowSkilllevel++;
                    } else {
                    skill_low.gameObject.SetActive(true);
                        if(NowSkilllevel == 6) {
                            LM.text = "レベルがマックスです。";
                        } else {
                            LM.text = "素材が足りません。";
                        }
                }
                break;
            }
        }
        lv(NowSkilllevel);
    }
    //iがnowskilllevel jがselectskill
    void skillup(int i,int j) {
        skilllevel.text = $"LV{i}→{i + 1}";
        switch(Master.playerdeta.NowSelectCharactor) {
            case "Ghost":
                int[,] Gcool = new int[,] {{14,14,13,13,12},{ 7,7,6,6,5},{ 10,10,9,9,8},{ 40,40,35,35,30} };
                cooldown.text = $"{Gcool[j-1,i-1]}S";
                switch(j) {
                    case 1:
                        kyouka_mae.text = $"10秒間拘束して拘束する。攻撃力の{110 + i * 5}%のダメージを与える";
                        kyouka_go.text = $"10秒間拘束して拘束する。攻撃力の{115 + i * 5}%のダメージを与える";
                        Master.playerdeta.GhostSkill1Level++;
                        break;
                    case 2:
                        kyouka_mae.text =$"範囲内にいる敵に対して攻撃力{110+i*20}%ダメージを与える";
                        kyouka_go.text = $"範囲内にいる敵に対して攻撃力{130+i*20}%ダメージを与える";
                        Master.playerdeta.GhostSkill2Level++;
                        break;
                    case 3:
                        int[] GS = new int[] { 5, 7, 9, 10, 12 };
                        kyouka_mae.text = $"範囲内の敵に5秒間{GS[i-1]}%ダメージを与える";
                        kyouka_go.text = $"範囲内の敵に5秒間{GS[i]}%ダメージを与える";
                        Master.playerdeta.GhostSkill3Level++;
                        break;
                    case 4:
                        kyouka_mae.text = $"{400+i*100}%ダメージを与えて継続で攻撃力の{5+i*5}%ダメージを10秒間与える";
                        kyouka_go.text = $"{500 + i * 100}%ダメージを与えて継続で攻撃力の{10 + i * 5}%ダメージを10秒間与える";
                        Master.playerdeta.GhostUltLevel++;
                        break;
                }
                break;
            case "Zashiki_warashi":
                int[,] Zcool = new int[,] { { 4, 4, 3, 3, 2 }, { 20, 20, 19, 19,18 }, { 25, 25, 24, 24, 23 }, { 50, 50, 40, 40, 30 } };
                cooldown.text = $"{Zcool[j - 1, i - 1]}S";
                switch(j) {
                    case 1:
                        kyouka_mae.text = $"自身の防御力の{125+i*5}%のダメージを与える。";
                        kyouka_go.text = $"自身の防御力の{130+i*5}%のダメージを与える。";
                        Master.playerdeta.Zashiki_warashiSkill1Level++;
                        break;
                    case 2:
                        kyouka_mae.text = $"5秒間継続で敵の移動速度、防御力、攻撃力を自分の防御力の{25+i*5}％ダウンさせる。";
                        kyouka_go.text = $"5秒間継続で敵の移動速度、防御力、攻撃力を自分の防御力の{30+i*5}％ダウンさせる。";
                        Master.playerdeta.Zashiki_warashiSkill2Level++;
                        break;
                    case 3:
                        kyouka_mae.text = $"{4+i}秒間攻撃力が40％になるが防御力が+40%";
                        kyouka_go.text = $"{5+i}秒間攻撃力が40％になるが防御力が+40%";
                        Master.playerdeta.Zashiki_warashiSkill3Level++;
                        break;
                    case 4:
                        kyouka_mae.text = $"自分の攻撃力の{150+i*50}％と防御力の{500+i*100}％を合わせたダメージを与える。";
                        kyouka_go.text = $"自分の攻撃力の{200 + i * 50}％と防御力の{600 + i * 100}％を合わせたダメージを与える。";
                        Master.playerdeta.Zashiki_warashiUltLevel++;
                        break;
                }
                break;
            case "Gore":
                int[,] Gocool = new int[,] { { 20, 20, 19, 19, 18 }, { 15, 15, 14, 14, 13 }, { 7, 7, 6, 6, 5 }, { 50, 50, 45, 45, 40 } };
                cooldown.text = $"{Gocool[j - 1, i - 1]}S";
                switch(j) {
                    case 1:
                        kyouka_mae.text = $"10秒間攻撃力の{25+i*5}％攻撃上昇する。最大HPの{20+i*5}％を10秒間かけて回復。";
                        kyouka_go.text = $"10秒間攻撃力の{30 + i * 5}％攻撃上昇する。最大HPの{25 + i * 5}％を10秒間かけて回復。";
                        Master.playerdeta.GoreSkill1Level++;
                        break;
                    case 2:
                        int[] GoS = new int[] {5,6,7,8,10};
                        kyouka_mae.text = $"{GoS[i-1]}秒間通常攻撃速度を2倍速くなる。攻撃を行うと敵の足の速度が1秒間{25+i*5}％ダウン。";
                        kyouka_go.text = $"{GoS[i]}秒間通常攻撃速度を2倍速くなる。攻撃を行うと敵の足の速度が1秒間{30 + i * 5}％ダウン";
                        Master.playerdeta.GoreSkill2Level++;
                        break;
                    case 3:
                        kyouka_mae.text = $"攻撃範囲内に敵がいる場合、次の攻撃に{130+i*20}％の追加ダメージを与える。";
                        kyouka_go.text = $"攻撃範囲内に敵がいる場合、次の攻撃に{150 + i * 20}％の追加ダメージを与える。";
                        Master.playerdeta.GoreSkill3Level++;
                        break;
                    case 4:
                        kyouka_mae.text = $"敵に攻撃力の{700+i*100}％ダメージを与える。1マスノックバックさせる。";
                        kyouka_go.text = $"敵に攻撃力の{800 + i * 100}％ダメージを与える。1マスノックバックさせる。";
                        Master.playerdeta.GoreUltLevel++;
                        break;
                }
                break;
            case "Poltergeist":
                int[,] Pcool = new int[,] { { 30, 30, 29, 29, 28 }, { 10, 10, 9, 9, 8 }, { 15, 15, 14, 14, 13 }, { 40, 40, 35, 35, 30 } };
                cooldown.text = $"{Pcool[j - 1, i - 1]}S";
                switch(j) {
                    case 1:
                        int[] PS = new int[] { 15, 20, 20, 20, 20 };
                        kyouka_mae.text = $"自分の攻撃範囲内にいる味方に自分の体力の{PS[i-1]}％分を回復させる。\n味方に自分の攻撃力の{8+i*2}％分の攻撃力を上昇。";
                        kyouka_go.text = $"自分の攻撃範囲内にいる味方に自分の体力の{PS[i]}％分を回復させる。\n味方に自分の攻撃力の{10 + i * 2}％分の攻撃力を上昇。";
                        Master.playerdeta.PoltergeistSkill1Level++;
                        break;
                    case 2:
                        kyouka_mae.text = $"{140+i*10}％ダメージを与える。敵を後ろ1マスノックバックさせる。";
                        kyouka_go.text = $"{150 + i * 10}％ダメージを与える。敵を後ろ1マスノックバックさせる。";
                        Master.playerdeta.PoltergeistSkill2Level++;
                        break;
                    case 3:
                        kyouka_mae.text = $"熊の人形を設置する。10秒間設置した熊は攻撃力の{25+i*5}％の通常攻撃を行う。";
                        kyouka_go.text = $"熊の人形を設置する。10秒間設置した熊は攻撃力の{30+i*5}％の通常攻撃を行う。";
                        Master.playerdeta.PoltergeistSkill3Level++;
                        break;
                    case 4:
                        kyouka_mae.text = $"15秒間キャラクターの攻撃力を自分の攻撃力の{30+i*10}％上昇させる。";
                        kyouka_go.text = $"15秒間キャラクターの攻撃力を自分の攻撃力の{40+i*10}％上昇させる。";
                        Master.playerdeta.PoltergeistUltLevel++;
                        break;
                }
                break;
            case "Daemon":
                int[,] Dcool = new int[,] { { 10, 10, 9, 9, 8 }, { 12, 12, 11, 11, 10 }, { 15, 15, 14, 14, 13 }, { 50, 50, 45, 45, 40 } };
                cooldown.text = $"{Dcool[j - 1, i - 1]}S";
                switch(j) {
                    case 1:
                        kyouka_mae.text = $"敵を3秒間拘束し、5秒間の間攻撃力の{5+i*5}％のダメージを与える。";
                        kyouka_go.text = $"敵を3秒間拘束し、5秒間の間攻撃力の{10 + i * 5}％のダメージを与える。";
                        Master.playerdeta.DaemonSkill1Level++;
                        break;
                    case 2:
                        kyouka_mae.text = $"蜘蛛の巣をマップに設置する。設置した糸に接触すると\n攻撃力の{95+i*10}％ダメージを与え、その場に敵を5秒間拘束する。";
                        kyouka_go.text = $"蜘蛛の巣をマップに設置する。設置した糸に接触すると\n攻撃力の{105 + i * 10}％ダメージを与え、その場に敵を5秒間拘束する。";
                        Master.playerdeta.DaemonSkill2Level++;
                        break;
                    case 3:
                        kyouka_mae.text = $"5秒間の間攻撃力の{20+i*10}％のダメージを与える。";
                        kyouka_go.text = $"5秒間の間攻撃力の{30 + i * 10}％のダメージを与える。";
                        Master.playerdeta.DaemonSkill3Level++;
                        break;
                    case 4:
                        kyouka_mae.text = $"5秒間の間敵を拘束して攻撃力の{60+i*10}％のダメージ10秒間継続で与える。";
                        kyouka_go.text = $"5秒間の間敵を拘束して攻撃力の{70 + i * 10}％のダメージ10秒間継続で与える。";
                        Master.playerdeta.DaemonUltLevel++;
                        break;
                }
                break;
        }
    }
    bool genkai(int i) {
        int g;
        g = 0;
        switch(Master.playerdeta.NowSelectCharactor) {
            case "Ghost":
                if(Master.playerdeta.GhostbreakingThrough1 == false) {
                    g= 1;
                } else if(Master.playerdeta.GhostbreakingThrough2 == false) {
                    g = 3;
                } else {
                    g = 5;
                }
                break;
            case "Zashiki_warashi":
                if(Master.playerdeta.Zashiki_warashibreakingThrough1 == false) {
                    g = 1;
                } else if(Master.playerdeta.Zashiki_warashibreakingThrough2 == false) {
                    g = 3;
                } else {
                    g = 5;
                }
                break;
            case "Gore":
                if(Master.playerdeta.GorebreakingThrough1 == false) {
                    g = 1;
                } else if(Master.playerdeta.GorebreakingThrough2 == false) {
                    g = 3;
                } else {
                    g = 5;
                }
                break;
            case "Poltergeist":
                if(Master.playerdeta.PoltergeistbreakingThrough1 == false) {
                    g = 1;
                } else if(Master.playerdeta.PoltergeistbreakingThrough2 == false) {
                    g = 3;
                } else {
                    g = 5;
                }
                break;
            case "Daemon":
                if(Master.playerdeta.DaemonbreakingThrough1 == false) {
                    g = 1;
                } else if(Master.playerdeta.DaemonbreakingThrough2 == false) {
                    g = 3;
                } else {
                    g = 5;
                }
                break;
        }
        if(i <g) {
            return true;
        } else {
            return false;
        }
    }
}
