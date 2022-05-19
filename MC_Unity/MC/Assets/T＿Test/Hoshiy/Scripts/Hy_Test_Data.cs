using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hy_Test_Data : MonoBehaviour
{
    //ホームシーンで参照するもの 
    public static int playerLevel = 1;                      //プレイヤーの現在のレベル
    public static string playerName = "Void";        //プレイヤーの現在の名前
    public static float playerGauge = 0.2f;            //プレイヤーの経験値ゲージの量
    public static int gatyaAmount = 0;                  //現在所持している禍根の量
    public static int expAmount = 0;                     //現在所持している残留思念の量
    public static int moneyAmount = 0;                //現在所持しているコインの量
    public static int imageNum = 0;                      //現在セットされているキャラクターを示すもの

    public static readonly string[] dailyMissions = { "DailyA", "DailyB", "DailyC", "DailyD", "DailyE", "DailyF" };
    public static bool[] didGetRewardsDaily = { true, true, false, false, false, false };
    public static bool[] canGetRewardsDaily = { true, true, true, false, false, false };

    public static readonly string[] weeklyMissions = { "WeeklyA", "WeeklyB", "WeeklyC", "WeeklyD", "WeeklyE", "WeeklyF" };
    public static bool[] didGetRewardsWeekly = { false, false, true, true, false, false };
    public static bool[] canGetRewardsWeekly = { true, true, false, false, false, false };

    public static Queue<string> acheiveMission1 = new Queue<string>();
    public static Queue<string> acheiveMission2 = new Queue<string>();
    public static Queue<string> acheiveMission3 = new Queue<string>();
    public static Queue<string> acheiveMission4 = new Queue<string>();
    public static Queue<string> acheiveMission5 = new Queue<string>();
    public static Queue<string> acheiveMission6 = new Queue<string>();
    public static bool[] didAllClearMissions = { false, false, false, false, false, false };
    public static bool[] canGetRewardsAceheive = { true, true, false, false, false, false };

    public static readonly string[] questMissions = { "QuestA", "QuestB", "QuestC", "QuestD", "QuestE", "QuestF" };
    public static bool[] didGetRewardsQuest = { false, false, false, false, true, true };
    public static bool[] canGetRewardsQuest = { false, false, true, true, true, true };

    public static readonly string missionRewardKakon10 = "禍根×10";
    public static readonly string missionRewardKakon50 = "禍根×50";
    public static readonly string missionRewardKakon2000 = "禍根×2000";
    public static readonly string missionRewardKakonAndSinenSmall = "禍根×10\n残留思念×2000";
    public static readonly string missionRewardKakonAndSinenLarge = "禍根×20\n残留思念×5000";
    public static readonly string missionRewardKakonAndMoney = "禍根×20\nコイン×5000";

    public static int window1CharacterNum = 0;
    public static int window2CharacterNum = 1;

    public static readonly int character1Level = 1;
    public static readonly string character1Name = "Red";
    public static readonly int character1Hp = 10;
    public static readonly int character1Atk = 10;
    public static readonly int character1Def = 10;
    public static readonly string character1PassiveSkill = "RedSkill  Lv1";
    public static readonly string character1PassiveEffect = "Atk+1\nDef+1";

    public static readonly int character2Level = 2;
    public static readonly string character2Name = "Blue";
    public static readonly int character2Hp = 20;
    public static readonly int character2Atk = 20;
    public static readonly int character2Def = 20;
    public static readonly string character2PassiveSkill = "BlueSkill  Lv1";
    public static readonly string character2PassiveEffect = "Atk+1\nHp+1";

    public static readonly int character3Level = 3;
    public static readonly string character3Name = "Green";
    public static readonly int character3Hp = 30;
    public static readonly int character3Atk = 30;
    public static readonly int character3Def = 30;
    public static readonly string character3PassiveSkill = "GreenSkill  Lv1";
    public static readonly string character3PassiveEffect = "Hp+1\nDef+1";

    public static readonly int character4Level = 4;
    public static readonly string character4Name = "Yellow";
    public static readonly int character4Hp = 40;
    public static readonly int character4Atk = 40;
    public static readonly int character4Def = 40;
    public static readonly string character4PassiveSkill = "YellowSkill  Lv1";
    public static readonly string character4PassiveEffect = "Atk+1\nDef+1";

    public static readonly int character5Level = 5;
    public static readonly string character5Name = "Purple";
    public static readonly int character5Hp = 50;
    public static readonly int character5Atk = 50;
    public static readonly int character5Def = 50;
    public static readonly string character5PassiveSkill = "PurpleSkill  Lv1";
    public static readonly string character5PassiveEffect = "Atk+1\nDef+1";

    public static readonly string synagy1and2 = "Red\nBlue";
    public static readonly string synagy1and3 = "Red\nGreen";
    public static readonly string synagy1and4 = "Red\nYellow";
    public static readonly string synagy1and5 = "Red\nPurple";
    public static readonly string synagy2and3 = "Blue\nGreen";
    public static readonly string synagy2and4 = "Blue\nYellow";
    public static readonly string synagy2and5 = "Blue\nPurple";
    public static readonly string synagy3and4 = "Green\nYellow";
    public static readonly string synagy3and5 = "Green\nPurple";
    public static readonly string synagy4and5 = "Yellow\nPurple";

    public static readonly Color[] armorColors = { Color.blue, Color.cyan, Color.gray, Color.green, Color.magenta, Color.red,Color.yellow,Color.white};
    public static readonly int[] armorLevels = { 1, 2, 4, 4, 7, 10,6,6 };

    void Start()
    {
        //デフォルト値

        acheiveMission1.Enqueue("AcheiveA1");
        acheiveMission1.Enqueue("AcheiveA2");
        acheiveMission1.Enqueue("AcheiveA3");
        acheiveMission1.Enqueue("AcheiveA4");
        acheiveMission1.Enqueue("AcheiveA5");
        acheiveMission1.Enqueue("AcheiveA5");

        acheiveMission2.Enqueue("AcheiveB1");
        acheiveMission2.Enqueue("AcheiveB2");
        acheiveMission2.Enqueue("AcheiveB3");
        acheiveMission2.Enqueue("AcheiveB4");
        acheiveMission2.Enqueue("AcheiveB5");
        acheiveMission2.Enqueue("AcheiveB5");

        acheiveMission3.Enqueue("AcheiveC1");
        acheiveMission3.Enqueue("AcheiveC2");
        acheiveMission3.Enqueue("AcheiveC3");
        acheiveMission3.Enqueue("AcheiveC3");

        acheiveMission4.Enqueue("AcheiveD1");
        acheiveMission4.Enqueue("AcheiveD2");
        acheiveMission4.Enqueue("AcheiveD3");
        acheiveMission4.Enqueue("AcheiveD3");

        acheiveMission5.Enqueue("AcheiveE1");
        acheiveMission5.Enqueue("AcheiveE2");
        acheiveMission5.Enqueue("AcheiveE3");
        acheiveMission5.Enqueue("AcheiveE3");

        acheiveMission6.Enqueue("AcheiveF1");
        acheiveMission6.Enqueue("AcheiveF1");
    }
}
