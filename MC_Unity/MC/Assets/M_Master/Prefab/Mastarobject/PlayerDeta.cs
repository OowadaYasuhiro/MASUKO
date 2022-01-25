using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeta
{
    //プレイヤーの名前
    public string PlayerName;
    //音量
    public float Soundvolume;
    //選択しているキャラクター
    public string NowSelectCharactor;
    //プレイヤーのレベル
    public int PlayerLevel { get{ return PlayerLevel;} set {int min = 1;int max = 100;PlayerLevel = Mathf.Clamp(PlayerLevel,min,max);} }
    //経験値
    public int PlayerExperience;
    //コイン
    public double Coin;
    //残留思念
    public double Zanryu_Sinen;
    //禍魂
    public double MagaTamashi;
    
    //デイリーミッション
    public bool DailyMission1;
    public bool DailyMission2;
    public bool DailyMission3;
    public bool DailyMission4;
    public bool DailyMission5;
    public bool DailyMission6;
    //ウィークリーミッション
    public bool WeeklyMission1;
    public bool WeeklyMission2;
    public bool WeeklyMission3;
    public bool WeeklyMission4;
    public bool WeeklyMission5;
    public bool WeeklyMission6;
    //実績
    public bool Achievements1;
    public bool Achievements2;
    public bool Achievements3;
    public bool Achievements4;
    public bool Achievements5;
    public bool Achievements6;
    public bool Achievements7;
    public bool Achievements8;
    public bool Achievements9;
    public bool Achievements10;
    public bool Achievements11;
    public bool Achievements12;
    public bool Achievements13;
    public bool Achievements14;
    public bool Achievements15;
    public bool Achievements16;
    public bool Achievements17;
    public bool Achievements18;
    public bool Achievements19;
    public bool Achievements20;

    //デーモン解放
    public bool DaemonUnLocked;
    //レベル
    private int daemonlevel;
    public int DaemonLevel { get { return daemonlevel; } set { int min = 1; int max = 2000000000; daemonlevel = Mathf.Clamp(value, min, max); } }
    //信頼度
    public int DaemonCredibility;
    //スキル１レベル
    public int daemonskill1level;
    public int DaemonSkill1Level { get { return daemonskill1level; } set { int min = 1; int max = 5; daemonskill1level = Mathf.Clamp(value, min, max); } }
    //スキル2レベル
    public int daemonskill2level;
    public int DaemonSkill2Level { get { return daemonskill2level; } set { int min = 1; int max = 5; daemonskill2level = Mathf.Clamp(value, min, max); } }
    //スキル3レベル
    public int daemonskill3level;
    public int DaemonSkill3Level { get { return daemonskill3level; } set { int min = 1; int max = 5; daemonskill3level = Mathf.Clamp(value, min, max); } }
    //怨嗟
    public int daemonultlevel;
    public int DaemonUltLevel { get { return daemonultlevel; } set { int min = 1; int max = 5; daemonultlevel = Mathf.Clamp(value, min, max); } }
    //パッシブスキル
    public int deamonpassiveskilllevel;
    public int DaemonPassiveSkillLevel { get { return deamonpassiveskilllevel; } set { int min = 1; int max = 6; deamonpassiveskilllevel = Mathf.Clamp(value, min, max); } }
    //潜在開花
    public int deamonpotentialflowering;
    public int DaemonPotentialflowering { get { return deamonpotentialflowering; } set { int min = 0; int max = 4; deamonpotentialflowering = Mathf.Clamp(value, min, max); } }
    //キャラ重複数
    public int Daemonduplication;
    //ポルターガイスト解放
    public bool PoltergeistUnLocked;
    //レベル
    public int poltergeistlevel;
    public int PoltergeistLevel { get { return poltergeistlevel; } set { int min = 1; int max = 2000000000; poltergeistlevel = Mathf.Clamp(value, min, max); } }
    //信頼度
    public int PoltergeistCredibility;
    //スキル1レベル
    public int poltergeistskill1level;
    public int PoltergeistSkill1Level { get { return poltergeistskill1level; } set { int min = 1; int max = 5; poltergeistskill1level = Mathf.Clamp(value, min, max); } }
    //スキル2レベル
    public int poltergeistskill2level;
    public int PoltergeistSkill2Level { get { return poltergeistskill2level; } set { int min = 1; int max = 5; poltergeistskill2level = Mathf.Clamp(value, min, max); } }
    //スキル3レベル
    public int poltergeistskill3level;
    public int PoltergeistSkill3Level { get { return poltergeistskill3level; } set { int min = 1; int max = 5; poltergeistskill3level = Mathf.Clamp(value, min, max); } }
    //怨嗟
    public int poltergeistultlevel;
    public int PoltergeistUltLevel { get { return poltergeistultlevel; } set { int min = 1; int max = 5; poltergeistultlevel = Mathf.Clamp(value, min, max); } }
    //パッシブスキル
    public int poltergeistpassiveskilllevel;
    public int PoltergeistPassiveSkillLevel { get { return poltergeistpassiveskilllevel; } set { int min = 1; int max = 6; poltergeistpassiveskilllevel = Mathf.Clamp(value, min, max); } }
    //潜在開花
    public int poltergeistpotentialflowering;
    public int PoltergeistPotentialflowering { get { return poltergeistpotentialflowering; } set { int min = 0; int max = 4; poltergeistpotentialflowering = Mathf.Clamp(value, min, max); } }
    //キャラ重複数
    public int Poltergeistduplication;
    //鬼開放
    public bool GoreUnLocked;
    //レベル
    public int gorelevel;
    public int GoreLevel { get { return gorelevel; } set { int min = 1; int max = 2000000000; gorelevel = Mathf.Clamp(value, min, max); } }
    //信頼度
    public int goreCredibility;
    //スキル1レベル
    public int goreskill1level;
    public int GoreSkill1Level { get { return goreskill1level; } set { int min = 1; int max = 5; goreskill1level = Mathf.Clamp(value, min, max); } }
    //スキル2レベル
    public int goreskill2level;
    public int GoreSkill2Level { get { return goreskill2level; } set { int min = 1; int max = 5; goreskill2level = Mathf.Clamp(value, min, max); } }
    //スキル3レベル
    public int goreskill3level;
    public int GoreSkill3Level { get { return goreskill3level; } set { int min = 1; int max = 5; goreskill3level = Mathf.Clamp(value, min, max); } }
    //怨嗟
    public int goreultlevel;
    public int GoreUltLevel { get { return goreultlevel; } set { int min = 1; int max = 5; goreultlevel = Mathf.Clamp(value, min, max); } }
    //パッシブスキル
    public int gorepassiveskilllevel;
    public int GorePassiveSkillLevel { get { return gorepassiveskilllevel; } set { int min = 1; int max = 6; gorepassiveskilllevel = Mathf.Clamp(value, min, max); } }
    //潜在開花
    public int gorepotentialflowering;
    public int GorePotentialflowering { get { return gorepotentialflowering; } set { int min = 0; int max = 4; gorepotentialflowering = Mathf.Clamp(value, min, max); } }
    //キャラ重複数
    public int goreduplication;
    //座敷童解放
    public bool Zashiki_warashiUnLocked;
    //レベル
    public int zashiki_warashilevel;
    public int Zashiki_warashiLevel { get { return zashiki_warashilevel; } set { int min = 1; int max = 2000000000; zashiki_warashilevel = Mathf.Clamp(value, min, max); } }
    //信頼度
    public int Zashiki_warashiCredibility;
    //スキル1レベル
    public int zashiki_warashiskill1level;
    public int Zashiki_warashiSkill1Level { get { return zashiki_warashiskill1level; } set { int min = 1; int max = 5; zashiki_warashiskill1level = Mathf.Clamp(value, min, max); } }
    //スキル2レベル
    public int zashiki_warashiskill2level;
    public int Zashiki_warashiSkill2Level { get { return zashiki_warashiskill2level; } set { int min = 1; int max = 5; zashiki_warashiskill2level = Mathf.Clamp(value, min, max); } }
    //スキル3レベル
    public int zashiki_warashiskill3level;
    public int Zashiki_warashiSkill3Level { get { return zashiki_warashiskill3level; } set { int min = 1; int max = 5; zashiki_warashiskill3level = Mathf.Clamp(value, min, max); } }
    //怨嗟
    public int zashiki_warashiultlevel;
    public int Zashiki_warashiUltLevel { get { return zashiki_warashiultlevel; } set { int min = 1; int max = 5; zashiki_warashiultlevel = Mathf.Clamp(value, min, max); } }
    //パッシブスキル
    public int zashiki_warashipassiveskilllevel;
    public int Zashiki_warashiPassiveSkillLevel { get { return zashiki_warashipassiveskilllevel; } set { int min = 1; int max = 6; zashiki_warashipassiveskilllevel = Mathf.Clamp(value, min, max); } }
    //潜在開花
    public int zashiki_warashipotentialflowering;
    public int Zashiki_warashiPotentialflowering { get { return zashiki_warashipotentialflowering; } set { int min = 0; int max = 4; zashiki_warashipotentialflowering = Mathf.Clamp(value, min, max); } }
    //キャラ重複数
    public int Zashiki_warashiduplication;
    //幽霊解放
    public bool GhostUnLocked;
    //レベル
    public int ghostlevel;
    public int GhostLevel { get { return ghostlevel; } set { int min = 1; int max = 2000000000; ghostlevel = Mathf.Clamp(value, min, max); } }
    //信頼度
    public int GhostCredibility;
    //スキル1レベル
    public int ghostskill1level;
    public int GhostSkill1Level { get { return ghostskill1level; } set { int min = 1; int max = 5; ghostskill1level = Mathf.Clamp(value, min, max); } }
    //スキル2レベル
    public int ghostskill2level;
    public int GhostSkill2Level { get { return ghostskill2level; } set { int min = 1; int max = 5; ghostskill2level = Mathf.Clamp(value, min, max); } }
    //スキル3レベル
    public int ghostskill3level;
    public int GhostSkill3Level { get { return ghostskill3level; } set { int min = 1; int max = 5; ghostskill3level = Mathf.Clamp(value, min, max); } }
    //怨嗟
    public int ghostultlevel;
    public int GhostUltLevel { get { return ghostultlevel; } set { int min = 1; int max = 5; ghostultlevel = Mathf.Clamp(value, min, max); } }
    //パッシブスキル
    public int ghostpssiveskilllevel;
    public int GhostPassiveSkillLevel { get { return ghostpssiveskilllevel; } set { int min = 1; int max = 6; ghostpssiveskilllevel = Mathf.Clamp(value, min, max); } }
    //潜在開花
    public int ghostpotentialflowering;
    public int GhostPotentialflowering { get { return ghostpotentialflowering; } set { int min = 0; int max = 4; ghostpotentialflowering = Mathf.Clamp(value, min, max); } }
    //キャラ重複数
    public int Ghostduplication;

    //霊魂
    public int Reikon;
    //希少な霊魂
    public int KisyounaReikon;
    //霊結石
    public int Reikesseki;
    //霊骨
    public int Reikotu;
    
    //古書
    public int Kosyo;
    //遺骨
    public int Ikotu;
    //人間の血
    public int Ninkennnoti;

    //進行度
    public bool Stage1_1Clear;
    public bool Stage1_1Mission1;
    public bool Stage1_1Mission2;
    public bool Stage1_1Mission3;
    public bool Stage1_2Clear;
    public bool Stage1_2Mission1;
    public bool Stage1_2Mission2;
    public bool Stage1_2Mission3;
    public bool Stage1_3Clear;
    public bool Stage1_3Mission1;
    public bool Stage1_3Mission2;
    public bool Stage1_3Mission3;
    public bool Stage1_4Clear;
    public bool Stage1_4Mission1;
    public bool Stage1_4Mission2;
    public bool Stage1_4Mission3;
    public bool Stage1_5Clear;
    public bool Stage1_5Mission1;
    public bool Stage1_5Mission2;
    public bool Stage1_5Mission3;
    public bool Stage2_1Clear;
    public bool Stage2_1Mission1;
    public bool Stage2_1Mission2;
    public bool Stage2_1Mission3;
    public bool Stage2_2Clear;
    public bool Stage2_2Mission1;
    public bool Stage2_2Mission2;
    public bool Stage2_2Mission3;
    public bool Stage2_3Clear;
    public bool Stage2_3Mission1;
    public bool Stage2_3Mission2;
    public bool Stage2_3Mission3;
    public bool Stage2_4Clear;
    public bool Stage2_4Mission1;
    public bool Stage2_4Mission2;
    public bool Stage2_4Mission3;
    public bool Stage2_5Clear;
    public bool Stage2_5Mission1;
    public bool Stage2_5Mission2;
    public bool Stage2_5Mission3;
    public bool Stage3_1Clear;
    public bool Stage3_1Mission1;
    public bool Stage3_1Mission2;
    public bool Stage3_1Mission3;
    public bool Stage3_2Clear;
    public bool Stage3_2Mission1;
    public bool Stage3_2Mission2;
    public bool Stage3_2Mission3;
    public bool Stage3_3Clear;
    public bool Stage3_3Mission1;
    public bool Stage3_3Mission2;
    public bool Stage3_3Mission3;
    public bool Stage3_4Clear;
    public bool Stage3_4Mission1;
    public bool Stage3_4Mission2;
    public bool Stage3_4Mission3;
    public bool Stage3_5Clear;
    public bool Stage3_5Mission1;
    public bool Stage3_5Mission2;
    public bool Stage3_5Mission3;
    public bool Stage4_1Clear;
    public bool Stage4_1Mission1;
    public bool Stage4_1Mission2;
    public bool Stage4_1Mission3;
    public bool Stage4_2Clear;
    public bool Stage4_2Mission1;
    public bool Stage4_2Mission2;
    public bool Stage4_2Mission3;
    public bool Stage4_3Clear;
    public bool Stage4_3Mission1;
    public bool Stage4_3Mission2;
    public bool Stage4_3Mission3;
    public bool Stage4_4Clear;
    public bool Stage4_4Mission1;
    public bool Stage4_4Mission2;
    public bool Stage4_4Mission3;
    public bool Stage4_5Clear;
    public bool Stage4_5Mission1;
    public bool Stage4_5Mission2;
    public bool Stage4_5Mission3;
    public bool Stage5_1Clear;
    public bool Stage5_1Mission1;
    public bool Stage5_1Mission2;
    public bool Stage5_1Mission3;
    public bool Stage5_2Clear;
    public bool Stage5_2Mission1;
    public bool Stage5_2Mission2;
    public bool Stage5_2Mission3;
    public bool Stage5_3Clear;
    public bool Stage5_3Mission1;
    public bool Stage5_3Mission2;
    public bool Stage5_3Mission3;
    public bool Stage5_4Clear;
    public bool Stage5_4Mission1;
    public bool Stage5_4Mission2;
    public bool Stage5_4Mission3;
    public bool Stage5_5Clear;
    public bool Stage5_5Mission1;
    public bool Stage5_5Mission2;
    public bool Stage5_5Mission3;

    public PlayerDeta()
    {

    }
    //現状これが呼ばれるのはまだ一度もセーブされたことが無い時だけ
    public PlayerDeta(string a)
    {
        PlayerLevel = 1;
        Soundvolume = 1f;
        NowSelectCharactor = "Ghost";
        MagaTamashi = 1000;
        Zanryu_Sinen = 1000;
        Coin = 10000;
        GhostUnLocked = true;
        GhostLevel = 1;
        DailyMission1 = false;
        DailyMission2 = false;
        DailyMission3 = false;
        DailyMission4 = false;
        DailyMission5 = false;
        DailyMission6 = false;
        WeeklyMission1 = false;
        WeeklyMission2 = false;
        WeeklyMission3 = false;
        WeeklyMission4 = false;
        WeeklyMission5 = false;
        WeeklyMission6 = false;
        Achievements1 = false;
        Achievements2 = false;
        Achievements3 = false;
        Achievements4 = false;
        Achievements5 = false;
        Achievements6= false;
        Achievements7 = false;
        Achievements8 = false;
        Achievements9 = false;
        Achievements10 = false;
        Achievements11 = false;
        Achievements12 = false;
        Achievements13 = false;
        Achievements14 = false;
        Achievements15 = false;
        Achievements16 = false;
        Achievements17 = false;
        Achievements18 = false;
        Achievements19 = false;
        Achievements20 = false;
        Stage1_1Clear = false;
        Stage1_1Mission1 = false;
        Stage1_1Mission2 = false;
        Stage1_1Mission3 = false;
        Stage1_2Clear = false;
        Stage1_2Mission1 = false;
        Stage1_2Mission2 = false;
        Stage1_2Mission3 = false;
        Stage1_3Clear = false;
        Stage1_3Mission1 = false;
        Stage1_3Mission2 = false;
        Stage1_3Mission3 = false;
        Stage1_4Clear = false;
        Stage1_4Mission1 = false;
        Stage1_4Mission2 = false;
        Stage1_4Mission3 = false;
        Stage1_5Clear = false;
        Stage1_5Mission1 = false;
        Stage1_5Mission2 = false;
        Stage1_5Mission3 = false;
        Stage2_1Clear = false;
        Stage2_1Mission1 = false;
        Stage2_1Mission2 = false;
        Stage2_1Mission3 = false;
        Stage2_2Clear = false;
        Stage2_2Mission1 = false;
        Stage2_2Mission2 = false;
        Stage2_2Mission3 = false;
        Stage2_3Clear = false;
        Stage2_3Mission1 = false;
        Stage2_3Mission2 = false;
        Stage2_3Mission3 = false;
        Stage2_4Clear = false;
        Stage2_4Mission1 = false;
        Stage2_4Mission2 = false;
        Stage2_4Mission3 = false;
        Stage2_5Clear = false;
        Stage2_5Mission1 = false;
        Stage2_5Mission2 = false;
        Stage2_5Mission3 = false;
        Stage3_1Clear = false;
        Stage3_1Mission1 = false;
        Stage3_1Mission2 = false;
        Stage3_1Mission3 = false;
        Stage3_2Clear = false;
        Stage3_2Mission1 = false;
        Stage3_2Mission2 = false;
        Stage3_2Mission3 = false;
        Stage3_3Clear = false;
        Stage3_3Mission1 = false;
        Stage3_3Mission2 = false;
        Stage3_3Mission3 = false;
        Stage3_4Clear = false;
        Stage3_4Mission1 = false;
        Stage3_4Mission2 = false;
        Stage3_4Mission3 = false;
        Stage3_5Clear = false;
        Stage3_5Mission1 = false;
        Stage3_5Mission2 = false;
        Stage3_5Mission3 = false;
        Stage4_1Clear = false;
        Stage4_1Mission1 = false;
        Stage4_1Mission2 = false;
        Stage4_1Mission3 = false;
        Stage4_2Clear = false;
        Stage4_2Mission1 = false;
        Stage4_2Mission2 = false;
        Stage4_2Mission3 = false;
        Stage4_3Clear = false;
        Stage4_3Mission1 = false;
        Stage4_3Mission2 = false;
        Stage4_3Mission3 = false;
        Stage4_4Clear = false;
        Stage4_4Mission1 = false;
        Stage4_4Mission2 = false;
        Stage4_4Mission3 = false;
        Stage4_5Clear = false;
        Stage4_5Mission1 = false;
        Stage4_5Mission2 = false;
        Stage4_5Mission3 = false;
        Stage5_1Clear = false;
        Stage5_1Mission1 = false;
        Stage5_1Mission2 = false;
        Stage5_1Mission3 = false;
        Stage5_2Clear = false;
        Stage5_2Mission1 = false;
        Stage5_2Mission2 = false;
        Stage5_2Mission3 = false;
        Stage5_3Clear = false;
        Stage5_3Mission1 = false;
        Stage5_3Mission2 = false;
        Stage5_3Mission3 = false;
        Stage5_4Clear = false;
        Stage5_4Mission1 = false;
        Stage5_4Mission2 = false;
        Stage5_4Mission3 = false;
        Stage5_5Clear = false;
        Stage5_5Mission1 = false;
        Stage5_5Mission2 = false;
        Stage5_5Mission3 = false;
    }
}
