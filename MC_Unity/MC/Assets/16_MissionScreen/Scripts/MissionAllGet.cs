using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionAllGet : MonoBehaviour
{
    /// <summary>
    /// 一括取得ボタンの処理
    /// </summary>

    [SerializeField]
    private GameObject rewardWindow;

    private int gatyaAmount = 0;
    private int expAmount = 0;
    private int moneyAmount = 0;

    private void Start()
    {
        //何かしらの受け取れる報酬があればボタンを押せるようにする
        if (Master.playerdeta.isGetRewardAchievements1 || Master.playerdeta.isGetRewardAchievements2 || Master.playerdeta.isGetRewardAchievements3 || Master.playerdeta.isGetRewardAchievements4 || Master.playerdeta.isGetRewardAchievements5 || Master.playerdeta.isGetRewardAchievements6 ||
            Master.playerdeta.isGetRewardWeeklyMission1 || Master.playerdeta.isGetRewardWeeklyMission2 || Master.playerdeta.isGetRewardWeeklyMission3 || Master.playerdeta.isGetRewardWeeklyMission4 || Master.playerdeta.isGetRewardWeeklyMission5 || Master.playerdeta.isGetRewardWeeklyMission6 ||
            Master.playerdeta.isGetRewardAchievements1 || Master.playerdeta.isGetRewardAchievements2 || Master.playerdeta.isGetRewardAchievements3 || Master.playerdeta.isGetRewardAchievements4 || Master.playerdeta.isGetRewardAchievements5 || 
            Master.playerdeta.isGetRewardAchievements6 || Master.playerdeta.isGetRewardAchievements7 || Master.playerdeta.isGetRewardAchievements8 || Master.playerdeta.isGetRewardAchievements9 || Master.playerdeta.isGetRewardAchievements10 ||
            Master.playerdeta.isGetRewardAchievements11 || Master.playerdeta.isGetRewardAchievements12 || Master.playerdeta.isGetRewardAchievements13 ||
            Master.playerdeta.isGetRewardAchievements14 || Master.playerdeta.isGetRewardAchievements15 || Master.playerdeta.isGetRewardAchievements16 ||
            Master.playerdeta.isGetRewardAchievements17 || Master.playerdeta.isGetRewardAchievements18 || Master.playerdeta.isGetRewardAchievements19 ||
            Master.playerdeta.isGetRewardAchievements20 ||
            Master.playerdeta.isGetRewardQuest1 || Master.playerdeta.isGetRewardQuest2 || Master.playerdeta.isGetRewardQuest3 || Master.playerdeta.isGetRewardQuest4 || Master.playerdeta.isGetRewardQuest5)
        {
            this.gameObject.GetComponent<Button>().enabled = true;
            this.gameObject.GetComponentInChildren<Text>().color = Color.black;
            this.gameObject.GetComponent<Image>().color = Color.white;
        }
        else
        {
            this.gameObject.GetComponent<Button>().enabled = false;
            this.gameObject.GetComponentInChildren<Text>().color = Color.black;
            this.gameObject.GetComponent<Image>().color = Color.gray;
        }
    }

    //OnClick用のメソッド
    public void OnClickAllGetButton()
    {
        //受け取れる報酬を探索
        SearchDailyMission();
        SearchWeeklyMission();
        SearchAcheiveMission();
        SearchQuestMission();

        rewardWindow.SetActive(true);
        rewardWindow.transform.GetChild(2).GetComponent<Text>().text = "";

        //探索したものを表示
        if (gatyaAmount != 0)
        {
            rewardWindow.transform.GetChild(2).GetComponent<Text>().text += "禍魂×" + this.gatyaAmount.ToString() + "\n";
        }
        if (expAmount != 0)
        {
            rewardWindow.transform.GetChild(2).GetComponent<Text>().text += "残留思念×" + this.expAmount.ToString() + "\n";
        }
        if (moneyAmount != 0)
        {
            rewardWindow.transform.GetChild(2).GetComponent<Text>().text += "コイン×" + this.moneyAmount.ToString();
        }

        //状態の更新
        GameObject.Find("Daily-Button").GetComponent<MissionDaily>().OnClickDailyButton();
        GameObject.Find("Weekly-Button").GetComponent<MissionWeekly>().OnClickWeeklyButton();
        GameObject.Find("Acheive-Button").GetComponent<MissionAcheive>().OnClickAcheiveButton();
        GameObject.Find("Quest-Button").GetComponent<MissionQuest>().OnClickQuestButton();
    }

    private void SearchDailyMission()
    {
        if (Master.playerdeta.isGetRewardDailyMission1)
        {
            gatyaAmount += 10;
            Master.playerdeta.DailyMission1 = true;
        }
        if (Master.playerdeta.isGetRewardDailyMission2)
        {
            gatyaAmount += 10;
            Master.playerdeta.DailyMission2 = true;
        }
        if (Master.playerdeta.isGetRewardDailyMission3)
        {
            gatyaAmount += 10;
            Master.playerdeta.DailyMission3 = true;
        }
        if (Master.playerdeta.isGetRewardDailyMission4)
        {
            gatyaAmount += 10;
            expAmount += 2000;
            Master.playerdeta.DailyMission4 = true;
        }
        if (Master.playerdeta.isGetRewardDailyMission5)
        {
            gatyaAmount += 10;
            expAmount += 2000;
            Master.playerdeta.DailyMission5 = true;
        }
        if (Master.playerdeta.isGetRewardDailyMission6)
        {
            gatyaAmount += 50;
            Master.playerdeta.DailyMission6 = true;
        }
    }

    private void SearchWeeklyMission()
    {
        if (Master.playerdeta.isGetRewardWeeklyMission1)
        {
            gatyaAmount += 50;
            Master.playerdeta.WeeklyMission1 = true;
        }
        if (Master.playerdeta.isGetRewardWeeklyMission2)
        {
            gatyaAmount += 20;
            expAmount += 5000;
            Master.playerdeta.WeeklyMission2 = true;
        }
        if (Master.playerdeta.isGetRewardWeeklyMission3)
        {
            gatyaAmount += 20;
            expAmount += 5000;
            Master.playerdeta.WeeklyMission3 = true;
        }
        if (Master.playerdeta.isGetRewardWeeklyMission4)
        {
            gatyaAmount += 20;
            moneyAmount += 5000;
            Master.playerdeta.WeeklyMission4 = true;
        }
        if (Master.playerdeta.isGetRewardWeeklyMission5)
        {
            gatyaAmount += 20;
            moneyAmount += 5000;
            Master.playerdeta.WeeklyMission5 = true;
        }
        if (Master.playerdeta.isGetRewardWeeklyMission6)
        {
            gatyaAmount += 20;
            Master.playerdeta.WeeklyMission6 = true;
        }
    }

    private void SearchAcheiveMission()
    {
        if (Master.playerdeta.isGetRewardAchievements1)
        {
            gatyaAmount += 50;
            Master.playerdeta.Achievements1 = true;
            if (Master.playerdeta.isGetRewardAchievements2)
            {
                gatyaAmount += 50;
                Master.playerdeta.Achievements2 = true;
                if (Master.playerdeta.isGetRewardAchievements3)
                {
                    gatyaAmount += 50;
                    Master.playerdeta.Achievements3 = true;
                    if (Master.playerdeta.isGetRewardAchievements4)
                    {
                        gatyaAmount += 50;
                        Master.playerdeta.Achievements4 = true;
                        if (Master.playerdeta.isGetRewardAchievements5)
                        {
                            gatyaAmount += 50;
                            Master.playerdeta.Achievements5 = true;
                        }
                    }
                }
            }
        }
        if (Master.playerdeta.isGetRewardAchievements6)
        {
            gatyaAmount += 50;
            Master.playerdeta.Achievements6 = true;
            if (Master.playerdeta.isGetRewardAchievements7)
            {
                gatyaAmount += 50;
                Master.playerdeta.Achievements7 = true;
                if (Master.playerdeta.isGetRewardAchievements8)
                {
                    gatyaAmount += 50;
                    Master.playerdeta.Achievements8 = true;
                    if (Master.playerdeta.isGetRewardAchievements9)
                    {
                        gatyaAmount += 50;
                        Master.playerdeta.Achievements9 = true;
                        if (Master.playerdeta.isGetRewardAchievements10)
                        {
                            gatyaAmount += 50;
                            Master.playerdeta.Achievements10 = true;
                        }
                    }
                }
            }
        }
        if (Master.playerdeta.isGetRewardAchievements11)
        {
            gatyaAmount += 50;
            Master.playerdeta.Achievements11 = true;
            if (Master.playerdeta.isGetRewardAchievements12)
            {
                gatyaAmount += 50;
                Master.playerdeta.Achievements12 = true;
                if (Master.playerdeta.isGetRewardAchievements13)
                {
                    gatyaAmount += 50;
                    Master.playerdeta.Achievements13 = true;
                }
            }
        }
        if (Master.playerdeta.isGetRewardAchievements14)
        {
            gatyaAmount += 50;
            Master.playerdeta.Achievements14 = true;
            if (Master.playerdeta.isGetRewardAchievements15)
            {
                gatyaAmount += 50;
                Master.playerdeta.Achievements15 = true;
                if (Master.playerdeta.isGetRewardAchievements16)
                {
                    gatyaAmount += 50;
                    Master.playerdeta.Achievements16 = true;
                }
            }
        }
        if (Master.playerdeta.isGetRewardAchievements17)
        {
            gatyaAmount += 50;
            Master.playerdeta.Achievements17 = true;
            if (Master.playerdeta.isGetRewardAchievements18)
            {
                gatyaAmount += 50;
                Master.playerdeta.Achievements18 = true;
                if (Master.playerdeta.isGetRewardAchievements19)
                {
                    gatyaAmount += 50;
                    Master.playerdeta.Achievements19 = true;
                }
            }
        }
        if (Master.playerdeta.isGetRewardAchievements20)
        {
            gatyaAmount += 2000;
            Master.playerdeta.Achievements20 = true;
        }
    }

    private void SearchQuestMission()
    {
        if (Master.playerdeta.Stage1_1Mission1 && Master.playerdeta.Stage1_1Mission2 && Master.playerdeta.Stage1_1Mission3)
        {
            gatyaAmount += 50;
            Master.playerdeta.isGetRewardQuest1 = true;
        }
        if (Master.playerdeta.Stage1_2Mission1 && Master.playerdeta.Stage1_2Mission2 && Master.playerdeta.Stage1_2Mission3)
        {
            gatyaAmount += 50;
            Master.playerdeta.isGetRewardQuest2 = true;
        }
        if (Master.playerdeta.Stage1_3Mission1 && Master.playerdeta.Stage1_3Mission2 && Master.playerdeta.Stage1_3Mission3)
        {
            gatyaAmount += 50;
            Master.playerdeta.isGetRewardQuest3 = true;
        }
        if (Master.playerdeta.Stage1_4Mission1 && Master.playerdeta.Stage1_4Mission2 && Master.playerdeta.Stage1_4Mission3)
        {
            gatyaAmount += 50;
            Master.playerdeta.isGetRewardQuest4 = true;
        }
        if (Master.playerdeta.Stage1_5Mission1 && Master.playerdeta.Stage1_5Mission2 && Master.playerdeta.Stage1_5Mission3)
        {
            gatyaAmount += 50;
            Master.playerdeta.isGetRewardQuest5 = true;
        }
    }
}
