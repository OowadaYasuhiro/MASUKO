using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeta
{
    //プレイヤーの名前
    public string PlayerName;
    //音量
    //Master
    private float mastersoundvolume;
    public float MasterSoundvolume { get { return mastersoundvolume; } set { mastersoundvolume = Mathf.Clamp01(value); } }
    //BGM
    private float bgmsoundvolume;
    public float BGMSoundvolume { get { return bgmsoundvolume; } set { bgmsoundvolume = Mathf.Clamp01(value); } }
    //VOICE
    private float voicesoundvolume;
    public float VoiceSoundvolume { get { return voicesoundvolume; } set { voicesoundvolume = Mathf.Clamp01(value); } }
    //ミュート
    public bool mute;
    //選択しているキャラクター
    public string NowSelectCharactor;
    //プレイヤーのレベル
    private int playerlevel; 
    public int PlayerLevel { get{ return playerlevel;} set {int min = 1;int max = 100;playerlevel = Mathf.Clamp(value,min,max);} }
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
    public bool isGetRewardDailyMission1;
    public bool DailyMission2;
    public bool isGetRewardDailyMission2;
    public bool DailyMission3;
    public bool isGetRewardDailyMission3;
    public bool DailyMission4;
    public bool isGetRewardDailyMission4;
    public bool DailyMission5;
    public bool isGetRewardDailyMission5;
    public bool DailyMission6;
    public bool isGetRewardDailyMission6;
    //ウィークリーミッション
    public bool WeeklyMission1;
    public bool isGetRewardWeeklyMission1;
    public bool WeeklyMission2;
    public bool isGetRewardWeeklyMission2;
    public bool WeeklyMission3;
    public bool isGetRewardWeeklyMission3;
    public bool WeeklyMission4;
    public bool isGetRewardWeeklyMission4;
    public bool WeeklyMission5;
    public bool isGetRewardWeeklyMission5;
    public bool WeeklyMission6;
    public bool isGetRewardWeeklyMission6;
    //実績
    public bool Achievements1;
    public bool isGetRewardAchievements1;
    public bool Achievements2;
    public bool isGetRewardAchievements2;
    public bool Achievements3;
    public bool isGetRewardAchievements3;
    public bool Achievements4;
    public bool isGetRewardAchievements4;
    public bool Achievements5;
    public bool isGetRewardAchievements5;
    public bool Achievements6;
    public bool isGetRewardAchievements6;
    public bool Achievements7;
    public bool isGetRewardAchievements7;
    public bool Achievements8;
    public bool isGetRewardAchievements8;
    public bool Achievements9;
    public bool isGetRewardAchievements9;
    public bool Achievements10;
    public bool isGetRewardAchievements10;
    public bool Achievements11;
    public bool isGetRewardAchievements11;
    public bool Achievements12;
    public bool isGetRewardAchievements12;
    public bool Achievements13;
    public bool isGetRewardAchievements13;
    public bool Achievements14;
    public bool isGetRewardAchievements14;
    public bool Achievements15;
    public bool isGetRewardAchievements15;
    public bool Achievements16;
    public bool isGetRewardAchievements16;
    public bool Achievements17;
    public bool isGetRewardAchievements17;
    public bool Achievements18;
    public bool isGetRewardAchievements18;
    public bool Achievements19;
    public bool isGetRewardAchievements19;
    public bool Achievements20;
    public bool isGetRewardAchievements20;

    public bool isGetRewardQuest1;
    public bool isGetRewardQuest2;
    public bool isGetRewardQuest3;
    public bool isGetRewardQuest4;
    public bool isGetRewardQuest5;

    //デーモン解放
    public bool DaemonUnLocked;
    //レベル
    private int daemonlevel;
    public int DaemonLevel { get { return daemonlevel; } set { int min = 1; int max = 2000000000; daemonlevel = Mathf.Clamp(value, min, max); } }
    //信頼度
    public int DaemonCredibility;
    //スキル１レベル
    private int daemonskill1level;
    public int DaemonSkill1Level { get { return daemonskill1level; } set { int min = 1; int max = 5; daemonskill1level = Mathf.Clamp(value, min, max); } }
    //スキル2レベル
    private int daemonskill2level;
    public int DaemonSkill2Level { get { return daemonskill2level; } set { int min = 1; int max = 5; daemonskill2level = Mathf.Clamp(value, min, max); } }
    //スキル3レベル
    private int daemonskill3level;
    public int DaemonSkill3Level { get { return daemonskill3level; } set { int min = 1; int max = 5; daemonskill3level = Mathf.Clamp(value, min, max); } }
    //怨嗟
    private int daemonultlevel;
    public int DaemonUltLevel { get { return daemonultlevel; } set { int min = 1; int max = 5; daemonultlevel = Mathf.Clamp(value, min, max); } }
    //パッシブスキル
    private int deamonpassiveskilllevel;
    public int DaemonPassiveSkillLevel { get { return deamonpassiveskilllevel; } set { int min = 1; int max = 6; deamonpassiveskilllevel = Mathf.Clamp(value, min, max); } }
    //潜在開花
    private int deamonpotentialflowering;
    public int DaemonPotentialflowering { get { return deamonpotentialflowering; } set { int min = 0; int max = 4; deamonpotentialflowering = Mathf.Clamp(value, min, max); } }
    //キャラ重複数
    public int Daemonduplication;
    //ポルターガイスト解放
    public bool PoltergeistUnLocked;
    //レベル
    private int poltergeistlevel;
    public int PoltergeistLevel { get { return poltergeistlevel; } set { int min = 1; int max = 2000000000; poltergeistlevel = Mathf.Clamp(value, min, max); } }
    //信頼度
    public int PoltergeistCredibility;
    //スキル1レベル
    private int poltergeistskill1level;
    public int PoltergeistSkill1Level { get { return poltergeistskill1level; } set { int min = 1; int max = 5; poltergeistskill1level = Mathf.Clamp(value, min, max); } }
    //スキル2レベル
    private int poltergeistskill2level;
    public int PoltergeistSkill2Level { get { return poltergeistskill2level; } set { int min = 1; int max = 5; poltergeistskill2level = Mathf.Clamp(value, min, max); } }
    //スキル3レベル
    private int poltergeistskill3level;
    public int PoltergeistSkill3Level { get { return poltergeistskill3level; } set { int min = 1; int max = 5; poltergeistskill3level = Mathf.Clamp(value, min, max); } }
    //怨嗟
    private int poltergeistultlevel;
    public int PoltergeistUltLevel { get { return poltergeistultlevel; } set { int min = 1; int max = 5; poltergeistultlevel = Mathf.Clamp(value, min, max); } }
    //パッシブスキル
    private int poltergeistpassiveskilllevel;
    public int PoltergeistPassiveSkillLevel { get { return poltergeistpassiveskilllevel; } set { int min = 1; int max = 6; poltergeistpassiveskilllevel = Mathf.Clamp(value, min, max); } }
    //潜在開花
    private int poltergeistpotentialflowering;
    public int PoltergeistPotentialflowering { get { return poltergeistpotentialflowering; } set { int min = 0; int max = 4; poltergeistpotentialflowering = Mathf.Clamp(value, min, max); } }
    //キャラ重複数
    public int Poltergeistduplication;
    //鬼開放
    public bool GoreUnLocked;
    //レベル
    private int gorelevel;
    public int GoreLevel { get { return gorelevel; } set { int min = 1; int max = 2000000000; gorelevel = Mathf.Clamp(value, min, max); } }
    //信頼度
    public int goreCredibility;
    //スキル1レベル
    private int goreskill1level;
    public int GoreSkill1Level { get { return goreskill1level; } set { int min = 1; int max = 5; goreskill1level = Mathf.Clamp(value, min, max); } }
    //スキル2レベル
    private int goreskill2level;
    public int GoreSkill2Level { get { return goreskill2level; } set { int min = 1; int max = 5; goreskill2level = Mathf.Clamp(value, min, max); } }
    //スキル3レベル
    private int goreskill3level;
    public int GoreSkill3Level { get { return goreskill3level; } set { int min = 1; int max = 5; goreskill3level = Mathf.Clamp(value, min, max); } }
    //怨嗟
    private int goreultlevel;
    public int GoreUltLevel { get { return goreultlevel; } set { int min = 1; int max = 5; goreultlevel = Mathf.Clamp(value, min, max); } }
    //パッシブスキル
    private int gorepassiveskilllevel;
    public int GorePassiveSkillLevel { get { return gorepassiveskilllevel; } set { int min = 1; int max = 6; gorepassiveskilllevel = Mathf.Clamp(value, min, max); } }
    //潜在開花
    private int gorepotentialflowering;
    public int GorePotentialflowering { get { return gorepotentialflowering; } set { int min = 0; int max = 4; gorepotentialflowering = Mathf.Clamp(value, min, max); } }
    //キャラ重複数
    public int goreduplication;
    //座敷童解放
    public bool Zashiki_warashiUnLocked;
    //レベル
    private int zashiki_warashilevel;
    public int Zashiki_warashiLevel { get { return zashiki_warashilevel; } set { int min = 1; int max = 2000000000; zashiki_warashilevel = Mathf.Clamp(value, min, max); } }
    //信頼度
    public int Zashiki_warashiCredibility;
    //スキル1レベル
    private int zashiki_warashiskill1level;
    public int Zashiki_warashiSkill1Level { get { return zashiki_warashiskill1level; } set { int min = 1; int max = 5; zashiki_warashiskill1level = Mathf.Clamp(value, min, max); } }
    //スキル2レベル
    private int zashiki_warashiskill2level;
    public int Zashiki_warashiSkill2Level { get { return zashiki_warashiskill2level; } set { int min = 1; int max = 5; zashiki_warashiskill2level = Mathf.Clamp(value, min, max); } }
    //スキル3レベル
    private int zashiki_warashiskill3level;
    public int Zashiki_warashiSkill3Level { get { return zashiki_warashiskill3level; } set { int min = 1; int max = 5; zashiki_warashiskill3level = Mathf.Clamp(value, min, max); } }
    //怨嗟
    private int zashiki_warashiultlevel;
    public int Zashiki_warashiUltLevel { get { return zashiki_warashiultlevel; } set { int min = 1; int max = 5; zashiki_warashiultlevel = Mathf.Clamp(value, min, max); } }
    //パッシブスキル
    private int zashiki_warashipassiveskilllevel;
    public int Zashiki_warashiPassiveSkillLevel { get { return zashiki_warashipassiveskilllevel; } set { int min = 1; int max = 6; zashiki_warashipassiveskilllevel = Mathf.Clamp(value, min, max); } }
    //潜在開花
    private int zashiki_warashipotentialflowering;
    public int Zashiki_warashiPotentialflowering { get { return zashiki_warashipotentialflowering; } set { int min = 0; int max = 4; zashiki_warashipotentialflowering = Mathf.Clamp(value, min, max); } }
    //キャラ重複数
    public int Zashiki_warashiduplication;
    //幽霊解放
    public bool GhostUnLocked;
    //レベル
    private int ghostlevel;
    public int GhostLevel { get { return ghostlevel; } set { int min = 1; int max = 2000000000; ghostlevel = Mathf.Clamp(value, min, max); } }
    //信頼度
    public int GhostCredibility;
    //スキル1レベル
    private int ghostskill1level;
    public int GhostSkill1Level { get { return ghostskill1level; } set { int min = 1; int max = 5; ghostskill1level = Mathf.Clamp(value, min, max); } }
    //スキル2レベル
    private int ghostskill2level;
    public int GhostSkill2Level { get { return ghostskill2level; } set { int min = 1; int max = 5; ghostskill2level = Mathf.Clamp(value, min, max); } }
    //スキル3レベル
    private int ghostskill3level;
    public int GhostSkill3Level { get { return ghostskill3level; } set { int min = 1; int max = 5; ghostskill3level = Mathf.Clamp(value, min, max); } }
    //怨嗟
    private int ghostultlevel;
    public int GhostUltLevel { get { return ghostultlevel; } set { int min = 1; int max = 5; ghostultlevel = Mathf.Clamp(value, min, max); } }
    //パッシブスキル
    private int ghostpssiveskilllevel;
    public int GhostPassiveSkillLevel { get { return ghostpssiveskilllevel; } set { int min = 1; int max = 6; ghostpssiveskilllevel = Mathf.Clamp(value, min, max); } }
    //潜在開花
    private int ghostpotentialflowering;
    public int GhostPotentialflowering { get { return ghostpotentialflowering; } set { int min = 0; int max = 4; ghostpotentialflowering = Mathf.Clamp(value, min, max); } }
    //キャラ重複数
    public int Ghostduplication;

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
    //人間の稀血
    public int Ninkennnomareti;

    //遺物
    Artifact[] artifacts;

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
        MasterSoundvolume = 1f;
        BGMSoundvolume = 1f;
        VoiceSoundvolume = 1f;
        mute = false;
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
        isGetRewardDailyMission1 = false;
        isGetRewardDailyMission2 = false;
        isGetRewardDailyMission3 = false;
        isGetRewardDailyMission4 = false;
        isGetRewardDailyMission5 = false;
        isGetRewardDailyMission6 = false;
        WeeklyMission1 = false;
        WeeklyMission2 = false;
        WeeklyMission3 = false;
        WeeklyMission4 = false;
        WeeklyMission5 = false;
        WeeklyMission6 = false;
        isGetRewardWeeklyMission1 = false;
        isGetRewardWeeklyMission2 = false;
        isGetRewardWeeklyMission3 = false;
        isGetRewardWeeklyMission4 = false;
        isGetRewardWeeklyMission5 = false;
        isGetRewardWeeklyMission6 = false;
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
        isGetRewardAchievements1 = false;
        isGetRewardAchievements2 = false;
        isGetRewardAchievements3 = false;
        isGetRewardAchievements4 = false;
        isGetRewardAchievements5 = false;
        isGetRewardAchievements6 = false;
        isGetRewardAchievements7 = false;
        isGetRewardAchievements8 = false;
        isGetRewardAchievements9 = false;
        isGetRewardAchievements10 = false;
        isGetRewardAchievements11 = false;
        isGetRewardAchievements12 = false;
        isGetRewardAchievements13 = false;
        isGetRewardAchievements14 = false;
        isGetRewardAchievements15 = false;
        isGetRewardAchievements16 = false;
        isGetRewardAchievements17 = false;
        isGetRewardAchievements18 = false;
        isGetRewardAchievements19 = false;
        isGetRewardAchievements20 = false;
        Stage1_1Clear = false;
        isGetRewardQuest1 = false;
        Stage1_1Mission1 = false;
        Stage1_1Mission2 = false;
        Stage1_1Mission3 = false;
        Stage1_2Clear = false;
        isGetRewardQuest2 = false;
        Stage1_2Mission1 = false;
        Stage1_2Mission2 = false;
        Stage1_2Mission3 = false;
        Stage1_3Clear = false;
        isGetRewardQuest3 = false;
        Stage1_3Mission1 = false;
        Stage1_3Mission2 = false;
        Stage1_3Mission3 = false;
        Stage1_4Clear = false;
        isGetRewardQuest4 = false;
        Stage1_4Mission1 = false;
        Stage1_4Mission2 = false;
        Stage1_4Mission3 = false;
        Stage1_5Clear = false;
        Stage1_5Mission1 = false;
        Stage1_5Mission2 = false;
        Stage1_5Mission3 = false;
        isGetRewardQuest5 = false;
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
