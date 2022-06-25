using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MissionKind
{
    DAILY,
    WEEKLY,
    ACHEIVEMENT,
    QUEST
}

public class MissionScreen_Deta 
{
    private readonly string[] dailyMissionData = { "ゲームにログインする", "クエストを3回クリアする", "1回遺品収集を行う", "キャラクターを1回強化する", "装備を1回強化する", "全てのデイリーミッションをクリアする"};
    private readonly string[] dailyRewards = { "禍魂×10", "禍魂×10", "禍魂×10", "禍魂×10\n残留思念×2000", "禍魂×10\n残留思念×2000", "禍魂×50" };

    private readonly string[] weeklyMissionData = { "7日間ゲームにログインする", "クエストを20回クリアする", "キャラクターを5回強化する", "装備を5回強化する", "怨嗟を20回使用する", "呪力を100回使用する"};
    private readonly string[] weeklyRewards = { "禍魂×50", "禍魂×20\n残留思念×5000", "禍魂×20\n残留思念×5000", "禍魂×20\nコイン×5000", "禍魂×20\nコイン×5000", "禍魂×20\nコイン×5000" };

    private readonly string[] acheiveMission1Data = { "1-5をクリアする", "2-5をクリアする", "3-5をクリアする", "4-5をクリアする", "5-5をクリアする" };
    private readonly string[] acheiveMission2Data = { "Hard1-5をクリアする", "Hard2-5をクリアする", "Hard3-5をクリアする", "Hard4-5をクリアする", "Hard5-5をクリアする" };
    private readonly string[] acheiveMission3Data = { "キャラクターを1体限界突破", "キャラクターを3体限界突破", "キャラクターを5体限界突破" };
    private readonly string[] acheiveMission4Data = { "キャラクターを1体Lv90にする", "キャラクターを3体Lv90にする", "キャラクターを5体Lv90にする" };
    private readonly string[] acheiveMission5Data = { "遺品を1個Lv50にする", "遺品を3個Lv50にする", "遺品を5個Lv50にする" };
    private readonly string acheiveMission6Data = "全ての実績を達成する";
    private readonly string acheiveReward = "禍魂×50";
    private readonly string acheiveAllClearReward = "禍魂×2000";

    private readonly string[] questMissiondata = { "1-1を星3条件でクリアする", "1-2を星3条件でクリアする", "1-3を星3条件でクリアする", "1-4を星3条件でクリアする", "1-5を星3条件でクリアする" };
    private readonly string questMissonReward = "禍魂×50";

    public static MissionKind kinds = MissionKind.DAILY;

    public string GetDailyMissionData(int index)
    {
        return this.dailyMissionData[index];
    }
    public string GetDailyRewards(int index)
    {
        return this.dailyRewards[index];
    }
    public int GetDailyMissionLength()
    {
        return this.dailyRewards.Length;
    }

    public string GetWeeklyMissionData(int index)
    {
        return this.weeklyMissionData[index];
    }
    public string GetWeeklyRewards(int index)
    {
        return this.weeklyRewards[index];
    }
    public int GetWeeklyMissionLength()
    {
        return this.weeklyMissionData.Length;
    }

    public string GetAcheiveMission1Data(int index)
    {
        return this.acheiveMission1Data[index];
    }
    public string GetAcheiveMission2Data(int index)
    {
        return this.acheiveMission2Data[index];
    }
    public string GetAcheiveMission3Data(int index)
    {
        return this.acheiveMission3Data[index];
    }
    public string GetAcheiveMission4Data(int index)
    {
        return this.acheiveMission4Data[index];
    }
    public string GetAcheiveMission5Data(int index)
    {
        return this.acheiveMission5Data[index];
    }
    public string GetAcheiveMission6Data()
    {
        return this.acheiveMission6Data;
    }

    public string GetAcheiveReward()
    {
        return this.acheiveReward;
    }
    public string GetAcheiveAllClearReward()
    {
        return this.acheiveAllClearReward;
    }
    public int GetAcheiveMissionLength()
    {
        return 6;
    }

    public string GetQuestMissionData(int index)
    {
        return this.questMissiondata[index];
    }
    public string GetQuestMissionReward()
    {
        return this.questMissonReward;
    }
    public int GetQuestMissionLength()
    {
        return this.questMissiondata.Length;
    }
}
