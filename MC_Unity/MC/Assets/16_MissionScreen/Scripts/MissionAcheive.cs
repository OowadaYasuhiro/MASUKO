using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionAcheive : MonoBehaviour
{
    [SerializeField]
    private GameObject[] otherButtons;
    [SerializeField]
    private GameObject titleText;
    [SerializeField]
    private GameObject details;

    private MissionScreen_Deta data = new MissionScreen_Deta();

    public void OnClickAcheiveButton()
    {
        DrawButtonColors();
        DrawAchieveDetails();
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

    private void DrawAchieveDetails()
    {
        titleText.GetComponent<Text>().text = "Achieve Missions";

        if (Master.playerdeta.Achievements4)
        {
            details.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission1Data(4);
            DrawGoalText(Master.playerdeta.Achievements5,0);
            DrawDetailsColor(Master.playerdeta.Achievements5,Master.playerdeta.isGetRewardAchievements5,0);
        } 
        else if (Master.playerdeta.Achievements3)
        {
            details.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission1Data(3);
            DrawGoalText(Master.playerdeta.Achievements4, 0);
            DrawDetailsColor(Master.playerdeta.Achievements4, Master.playerdeta.isGetRewardAchievements4, 0);
        }
        else if (Master.playerdeta.Achievements2)
        {
            details.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission1Data(2);
            DrawGoalText(Master.playerdeta.Achievements3, 0);
            DrawDetailsColor(Master.playerdeta.Achievements3, Master.playerdeta.isGetRewardAchievements3, 0);
        }
        else if (Master.playerdeta.Achievements1)
        {
            details.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission1Data(1);
            DrawGoalText(Master.playerdeta.Achievements2, 0);
            DrawDetailsColor(Master.playerdeta.Achievements2, Master.playerdeta.isGetRewardAchievements2, 0);
        }
        else
        {
            details.transform.GetChild(0).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission1Data(0);
            DrawGoalText(Master.playerdeta.Achievements1, 0);
            DrawDetailsColor(Master.playerdeta.Achievements1, Master.playerdeta.isGetRewardAchievements1, 0);
        }

        if (Master.playerdeta.Achievements9)
        {
            details.transform.GetChild(1).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission2Data(4);
            DrawGoalText(Master.playerdeta.Achievements10, 1);
            DrawDetailsColor(Master.playerdeta.Achievements10, Master.playerdeta.isGetRewardAchievements10, 1);
        }
        else if (Master.playerdeta.Achievements8)
        {
            details.transform.GetChild(1).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission2Data(3);
            DrawGoalText(Master.playerdeta.Achievements9, 1);
            DrawDetailsColor(Master.playerdeta.Achievements9, Master.playerdeta.isGetRewardAchievements9, 1);
        }
        else if (Master.playerdeta.Achievements7)
        {
            details.transform.GetChild(1).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission2Data(2);
            DrawGoalText(Master.playerdeta.Achievements8, 1);
            DrawDetailsColor(Master.playerdeta.Achievements8, Master.playerdeta.isGetRewardAchievements8, 1);
        }
        else if (Master.playerdeta.Achievements6)
        {
            details.transform.GetChild(1).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission2Data(1);
            DrawGoalText(Master.playerdeta.Achievements7, 1);
            DrawDetailsColor(Master.playerdeta.Achievements7, Master.playerdeta.isGetRewardAchievements7, 1);
        }
        else
        {
            details.transform.GetChild(1).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission2Data(0);
            DrawGoalText(Master.playerdeta.Achievements6, 1);
            DrawDetailsColor(Master.playerdeta.Achievements6, Master.playerdeta.isGetRewardAchievements6, 1);
        }

        if (Master.playerdeta.Achievements12)
        {
            details.transform.GetChild(2).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission3Data(2);
            DrawGoalText(Master.playerdeta.Achievements13, 2);
            DrawDetailsColor(Master.playerdeta.Achievements13, Master.playerdeta.isGetRewardAchievements13, 2);
        }
        else if (Master.playerdeta.Achievements11)
        {
            details.transform.GetChild(2).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission1Data(1);
            DrawGoalText(Master.playerdeta.Achievements12, 2);
            DrawDetailsColor(Master.playerdeta.Achievements12, Master.playerdeta.isGetRewardAchievements12, 2);
        }
        else
        {
            details.transform.GetChild(2).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission1Data(0);
            DrawGoalText(Master.playerdeta.Achievements11, 2);
            DrawDetailsColor(Master.playerdeta.Achievements11, Master.playerdeta.isGetRewardAchievements11, 2);
        }

        if (Master.playerdeta.Achievements15)
        {
            details.transform.GetChild(3).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission4Data(2);
            DrawGoalText(Master.playerdeta.Achievements16, 3);
            DrawDetailsColor(Master.playerdeta.Achievements16, Master.playerdeta.isGetRewardAchievements16, 3);
        }
        else if (Master.playerdeta.Achievements14)
        {
            details.transform.GetChild(3).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission4Data(1);
            DrawGoalText(Master.playerdeta.Achievements15, 3);
            DrawDetailsColor(Master.playerdeta.Achievements15, Master.playerdeta.isGetRewardAchievements15, 3);
        }
        else
        {
            details.transform.GetChild(3).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission4Data(0);
            DrawGoalText(Master.playerdeta.Achievements14, 3);
            DrawDetailsColor(Master.playerdeta.Achievements14, Master.playerdeta.isGetRewardAchievements14, 3);
        }

        if (Master.playerdeta.Achievements18)
        {
            details.transform.GetChild(4).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission5Data(2);
            DrawGoalText(Master.playerdeta.Achievements19, 4);
            DrawDetailsColor(Master.playerdeta.Achievements19, Master.playerdeta.isGetRewardAchievements19, 4);
        }
        else if (Master.playerdeta.Achievements17)
        {
            details.transform.GetChild(4).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission5Data(1);
            DrawGoalText(Master.playerdeta.Achievements18, 4);
            DrawDetailsColor(Master.playerdeta.Achievements18, Master.playerdeta.isGetRewardAchievements18, 4);
        }
        else
        {
            details.transform.GetChild(4).transform.GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission5Data(0);
            DrawGoalText(Master.playerdeta.Achievements17, 4);
            DrawDetailsColor(Master.playerdeta.Achievements17, Master.playerdeta.isGetRewardAchievements17, 4);
        }

        details.transform.GetChild(5).GetChild(1).GetComponent<Text>().text = data.GetAcheiveMission6Data();
        DrawGoalText(Master.playerdeta.Achievements20, 5);
        DrawDetailsColor(Master.playerdeta.Achievements20, Master.playerdeta.isGetRewardAchievements20, 5);
    }

    private void DrawGoalText(bool flag, int index)
    {
        string text;
        if (flag)
        {
            text = "達 成";
        }
        else
        {
            text = "未達成";
        }
        details.transform.GetChild(index).transform.GetChild(0).GetComponent<Text>().text = text;
    }

    private void DrawDetailsColor(bool didMissionClearFlag, bool isGetRewardFlag, int index)
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
