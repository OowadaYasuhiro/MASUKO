﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionQuest : MonoBehaviour
{
    [SerializeField]
    private GameObject[] otherButtons;
    [SerializeField]
    private GameObject titleText;
    [SerializeField]
    private GameObject details;

    private MissionScreen_Deta data = new MissionScreen_Deta();

    public void OnClickQuestButton()
    {
        DrawButtonColors();
        DrawQuestDetails();
        DrawDetailsColor(Master.playerdeta.WeeklyMission1, Master.playerdeta.isGetRewardQuest1, 0);
        DrawDetailsColor(Master.playerdeta.WeeklyMission2, Master.playerdeta.isGetRewardQuest2, 1);
        DrawDetailsColor(Master.playerdeta.WeeklyMission3, Master.playerdeta.isGetRewardQuest3, 2);
        DrawDetailsColor(Master.playerdeta.WeeklyMission4, Master.playerdeta.isGetRewardQuest4, 3);
        DrawDetailsColor(Master.playerdeta.WeeklyMission5, Master.playerdeta.isGetRewardQuest5, 4);
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

    private void DrawQuestDetails()
    {
        titleText.GetComponent<Text>().text = "Quest Missions";

        for (var i = 0; i < data.GetQuestMissionLength(); i++)
        {
            details.transform.GetChild(i).transform.GetChild(1).GetComponent<Text>().text = data.GetWeeklyMissionData(i);
            switch (i)
            {
                case 0:
                    DrawGoalText(Master.playerdeta.Stage1_1Clear, i);
                    break;
                case 1:
                    DrawGoalText(Master.playerdeta.Stage1_2Clear, i);
                    break;
                case 2:
                    DrawGoalText(Master.playerdeta.Stage1_3Clear, i);
                    break;
                case 3:
                    DrawGoalText(Master.playerdeta.Stage1_4Clear, i);
                    break;
                case 4:
                    DrawGoalText(Master.playerdeta.Stage1_5Clear, i);
                    break;
                default:
                    Debug.LogError("Illegal value");
                    break;
            }
        }

    }

    private void DrawGoalText(bool flag, int index)
    {
        string text = flag ? "達 成" : "未達成";
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