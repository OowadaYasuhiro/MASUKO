using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionDaily : MonoBehaviour
{
    [SerializeField]
    private GameObject[] otherButtons;
    [SerializeField]
    private GameObject titleText;
    [SerializeField]
    private GameObject details;

    private MissionScreen_Deta data = new MissionScreen_Deta();

    public void OnClickDailyButton()
    {
        DrawButtonColors();
        DrawDailyDetails();
        DrawDetailsColor(Master.playerdeta.DailyMission1, Master.playerdeta.isGetRewardDailyMission1, 0);
        DrawDetailsColor(Master.playerdeta.DailyMission2, Master.playerdeta.isGetRewardDailyMission2, 1);
        DrawDetailsColor(Master.playerdeta.DailyMission3, Master.playerdeta.isGetRewardDailyMission3, 2);
        DrawDetailsColor(Master.playerdeta.DailyMission4, Master.playerdeta.isGetRewardDailyMission4, 3);
        DrawDetailsColor(Master.playerdeta.DailyMission5, Master.playerdeta.isGetRewardDailyMission5, 4);
        DrawDetailsColor(Master.playerdeta.DailyMission6, Master.playerdeta.isGetRewardDailyMission6, 5);
    }

    private void DrawButtonColors()
    {
        this.gameObject.GetComponent<Image>().color = Color.white;
        this.gameObject.GetComponentInChildren<Text>().color = Color.black;
        foreach (var other in otherButtons)
        {
            other.GetComponent<Image>().color = Color.black;
            other.GetComponentInChildren<Text>().color = Color.white;
        }
    }

    private void DrawDailyDetails()
    {
        titleText.GetComponent<Text>().text = "Daily Missions";

        for (var i = 0; i < data.GetDailyMissionLength(); i++)
        {
            details.transform.GetChild(i).transform.GetChild(1).GetComponent<Text>().text = data.GetDailyMissionData(i);
            switch (i)
            {
                case 0:
                    DrawGoalText(Master.playerdeta.DailyMission1, i);
                    break;
                case 1:
                    DrawGoalText(Master.playerdeta.DailyMission2, i);
                    break;
                case 2:
                    DrawGoalText(Master.playerdeta.DailyMission3,i);
                    break;
                case 3:
                    DrawGoalText(Master.playerdeta.DailyMission4,i);
                    break;
                case 4:
                    DrawGoalText(Master.playerdeta.DailyMission5,i);
                    break;
                case 5:
                    DrawGoalText(Master.playerdeta.DailyMission6,i);
                    break;
                default:
                    Debug.LogError("Illegal value");
                    break;
            }
        }

    }

    private void DrawGoalText(bool flag,int index)
    {
        string text = flag ? "達 成" : "未達成";
        details.transform.GetChild(index).transform.GetChild(0).GetComponent<Text>().text = text;
    }

    private void DrawDetailsColor(bool didMissionClearFlag,bool isGetRewardFlag,int index)
    {
        if (didMissionClearFlag)
        {
            details.transform.GetChild(index).GetComponent<Image>().color = Color.gray;
            details.transform.GetChild(index).GetComponent<Button>().enabled = false;
        } 
        else if (isGetRewardFlag)
        {
            details.transform.GetChild(index).GetComponent<Image>().color = Color.red;
            details.transform.GetChild(index).GetComponent<Button>().enabled = true;
        }
        else
        {
            details.transform.GetChild(index).GetComponent<Image>().color = Color.white;
            details.transform.GetChild(index).GetComponent<Button>().enabled = false;
        }
    }
}
