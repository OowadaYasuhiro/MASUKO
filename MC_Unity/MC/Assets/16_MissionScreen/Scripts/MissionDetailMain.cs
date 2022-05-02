using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionDetailMain : MonoBehaviour
{
    /// <summary>
    /// 任務詳細の処理
    /// </summary>

    private int num; //押した詳細を区別する番号

    [SerializeField]
    private GameObject rewardWindow;

    private MissionScreen_Deta data = new MissionScreen_Deta();

    private void Start()
    {
        rewardWindow.SetActive(false);
    }

    //OnClick用のメソッド
    public void OnClickDetailButton(int value)
    {
        this.num = value; //押されたディテールを保存
        rewardWindow.SetActive(true);

        GameObject obj;

        switch (MissionScreen_Deta.stateNum) //対応する報酬の表示とフラグの更新
        {
            case 0:
                DrawRewardDaily(this.num);
                obj =  GameObject.Find("Daily-Button");
                obj.GetComponent<MissionDaily>().OnClickDailyButton();
                break;
            case 1:
                DrawRewardWeekly(this.num);
                obj = GameObject.Find("Weekly-Button");
                obj.GetComponent<MissionWeekly>().OnClickWeeklyButton();
                break;
            case 2:
                DrawRewardAcheive(this.num);
                obj = GameObject.Find("Acheive-Button");
                obj.GetComponent<MissionAcheive>().OnClickAcheiveButton();
                break;
            case 3:
                DrawRewardQuest(this.num);
                obj = GameObject.Find("Quest-Button");
                obj.GetComponent<MissionQuest>().OnClickQuestButton();
                break;
            default:
                Debug.LogError("Illegal value");
                break;
        }
    }

    private void DrawRewardDaily(int posNum)
    {
        rewardWindow.transform.GetChild(2).GetComponent<Text>().text = data.GetDailyRewards(posNum);

        switch (posNum)
        {
            case 0:
                Master.playerdeta.DailyMission1 = true;
                break;
            case 1:
                Master.playerdeta.DailyMission2 = true;
                break;
            case 2:
                Master.playerdeta.DailyMission3 = true;
                break;
            case 3:
                Master.playerdeta.DailyMission4 = true;
                break;
            case 4:
                Master.playerdeta.DailyMission5 = true;
                break;
            case 5:
                Master.playerdeta.DailyMission6 = true;
                break;
            default:
                Debug.LogError("Illegal value");
                break;
        }
    }

    private void DrawRewardWeekly(int posNum)
    {
        rewardWindow.transform.GetChild(2).GetComponent<Text>().text = data.GetWeeklyRewards(posNum);

        switch (posNum)
        {
            case 0:
                Master.playerdeta.WeeklyMission1 = true;
                break;
            case 1:
                Master.playerdeta.WeeklyMission2 = true;
                break;
            case 2:
                Master.playerdeta.WeeklyMission3 = true;
                break;
            case 3:
                Master.playerdeta.WeeklyMission4 = true;
                break;
            case 4:
                Master.playerdeta.WeeklyMission5 = true;
                break;
            case 5:
                Master.playerdeta.WeeklyMission6 = true;
                break;
            default:
                Debug.LogError("Illegal value");
                break;
        }
    }

    private void DrawRewardAcheive(int posNum)
    {
        if (posNum == 5)
        {
            rewardWindow.transform.GetChild(2).GetComponent<Text>().text = data.GetAcheiveAllClearReward();
        }
        else
        {
            rewardWindow.transform.GetChild(2).GetComponent<Text>().text = data.GetAcheiveReward();
        }

        switch (posNum)
        {
            case 0:
                if (Master.playerdeta.Achievements4)
                {
                    Master.playerdeta.Achievements5 = true;
                } 
                else if (Master.playerdeta.Achievements3)
                {
                    Master.playerdeta.Achievements4 = true;
                }
                else if (Master.playerdeta.Achievements2)
                {
                    Master.playerdeta.Achievements3 = true;
                }
                else if (Master.playerdeta.Achievements1)
                {
                    Master.playerdeta.Achievements2 = true;
                }
                else
                {
                    Master.playerdeta.Achievements1 = true;
                }
                break;
            case 1:
                if (Master.playerdeta.Achievements9)
                {
                    Master.playerdeta.Achievements10 = true;
                }
                else if (Master.playerdeta.Achievements8)
                {
                    Master.playerdeta.Achievements9 = true;
                }
                else if (Master.playerdeta.Achievements7)
                {
                    Master.playerdeta.Achievements8 = true;
                }
                else if (Master.playerdeta.Achievements6)
                {
                    Master.playerdeta.Achievements7 = true;
                }
                else
                {
                    Master.playerdeta.Achievements5 = true;
                }
                break;
            case 2:
                if (Master.playerdeta.Achievements12)
                {
                    Master.playerdeta.Achievements13 = true;
                }
                else if (Master.playerdeta.Achievements11)
                {
                    Master.playerdeta.Achievements12 = true;
                }
                else
                {
                    Master.playerdeta.Achievements11 = true;
                }
                break;
            case 3:
                if (Master.playerdeta.Achievements15)
                {
                    Master.playerdeta.Achievements16 = true;
                }
                else if (Master.playerdeta.Achievements14)
                {
                    Master.playerdeta.Achievements15 = true;
                }
                else
                {
                    Master.playerdeta.Achievements14 = true;
                }
                break;
            case 4:
                if (Master.playerdeta.Achievements18)
                {
                    Master.playerdeta.Achievements19 = true;
                }
                else if (Master.playerdeta.Achievements17)
                {
                    Master.playerdeta.Achievements18 = true;
                }
                else
                {
                    Master.playerdeta.Achievements17 = true;
                }
                break;
            case 5:
                Master.playerdeta.Achievements20 = true;
                break;
            default:
                Debug.LogError("Illegal value");
                break;
        }
    }

    private void DrawRewardQuest(int posNum)
    {
        rewardWindow.transform.GetChild(2).GetComponent<Text>().text = data.GetQuestMissionReward();

        switch (posNum)
        {
            case 0:
                Master.playerdeta.isGetRewardQuest1 = true;
                break;
            case 1:
                Master.playerdeta.isGetRewardQuest2 = true;
                break;
            case 2:
                Master.playerdeta.isGetRewardQuest3 = true;
                break;
            case 3:
                Master.playerdeta.isGetRewardQuest4 = true;
                break;
            case 4:
                Master.playerdeta.isGetRewardQuest5 = true;
                break;
            case 5:
                break;
            default:
                Debug.LogError("Illegal value");
                break;
        }
    }
}
