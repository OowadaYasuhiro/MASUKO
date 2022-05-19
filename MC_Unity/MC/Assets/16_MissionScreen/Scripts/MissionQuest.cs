using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionQuest : MonoBehaviour
{
    /// <summary>
    /// クエストミッションの処理
    /// </summary>
    //todo: フラグ作成


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
        DrawDetailsColor(Master.playerdeta.isGetRewardQuest1, 0,Master.playerdeta.Stage1_1Mission1, Master.playerdeta.Stage1_1Mission2, Master.playerdeta.Stage1_1Mission3);
        DrawDetailsColor(Master.playerdeta.isGetRewardQuest2, 1,Master.playerdeta.Stage1_2Mission1, Master.playerdeta.Stage1_2Mission2, Master.playerdeta.Stage1_2Mission3);
        DrawDetailsColor(Master.playerdeta.isGetRewardQuest3, 2,Master.playerdeta.Stage1_3Mission1, Master.playerdeta.Stage1_3Mission2, Master.playerdeta.Stage1_3Mission3);
        DrawDetailsColor(Master.playerdeta.isGetRewardQuest4, 3,Master.playerdeta.Stage1_4Mission1, Master.playerdeta.Stage1_4Mission2, Master.playerdeta.Stage1_4Mission3);
        DrawDetailsColor(Master.playerdeta.isGetRewardQuest5, 4,Master.playerdeta.Stage1_5Mission1, Master.playerdeta.Stage1_5Mission2, Master.playerdeta.Stage1_5Mission3);

        MissionScreen_Deta.stateNum = 3;
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
            details.transform.GetChild(i).transform.GetChild(1).GetComponent<Text>().text = data.GetQuestMissionData(i);
            switch (i)
            {
                case 0:
                    DrawGoalText(Master.playerdeta.isGetRewardQuest1, i);
                    break;
                case 1:
                    DrawGoalText(Master.playerdeta.isGetRewardQuest2, i);
                    break;
                case 2:
                    DrawGoalText(Master.playerdeta.isGetRewardQuest3, i);
                    break;
                case 3:
                    DrawGoalText(Master.playerdeta.isGetRewardQuest4, i);
                    break;
                case 4:
                    DrawGoalText(Master.playerdeta.isGetRewardQuest5, i);
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

    private void DrawDetailsColor(bool isGetRewardFlag, int index,bool flag1,bool flag2,bool flag3)
    {
        if (isGetRewardFlag)
        {
            details.transform.GetChild(index).GetComponent<Image>().color = Color.gray;
            details.transform.GetChild(index).GetComponent<Button>().enabled = false;
        }
        else if (flag1 && flag2 && flag3)
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
