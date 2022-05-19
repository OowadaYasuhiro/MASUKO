using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionWeekly : MonoBehaviour
{
    /// <summary>
    /// ウィークリーに関する処理
    /// </summary>


    [SerializeField]
    private GameObject[] otherButtons; //ウィークリー以外のボタン
    [SerializeField]
    private GameObject titleText; //タイトル
    [SerializeField]
    private GameObject details; //ミッションを示すオブジェクト

    private MissionScreen_Deta data = new MissionScreen_Deta(); //ミッションのデータ

    //OnClick用のメソッド
    public void OnClickWeeklyButton()
    {
        DrawButtonColors();
        DrawWeeklyDetails();
        DrawDetailsColor(Master.playerdeta.WeeklyMission1, Master.playerdeta.isGetRewardWeeklyMission1, 0);
        DrawDetailsColor(Master.playerdeta.WeeklyMission2, Master.playerdeta.isGetRewardWeeklyMission2, 1);
        DrawDetailsColor(Master.playerdeta.WeeklyMission3, Master.playerdeta.isGetRewardWeeklyMission3, 2);
        DrawDetailsColor(Master.playerdeta.WeeklyMission4, Master.playerdeta.isGetRewardWeeklyMission4, 3);
        DrawDetailsColor(Master.playerdeta.WeeklyMission5, Master.playerdeta.isGetRewardWeeklyMission5, 4);
        DrawDetailsColor(Master.playerdeta.WeeklyMission6, Master.playerdeta.isGetRewardWeeklyMission6, 5);

        MissionScreen_Deta.stateNum = 1;
    }

    //ウィークリーボタンを明るくし、それ以外のボタンを暗くする
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

    //ウィークリーミッション内容の取得
    private void DrawWeeklyDetails()
    {
        titleText.GetComponent<Text>().text = "Weekly Missions";

        for (var i = 0; i < data.GetWeeklyMissionLength(); i++)
        {
            details.transform.GetChild(i).transform.GetChild(1).GetComponent<Text>().text = data.GetWeeklyMissionData(i);
            switch (i)
            {
                case 0:
                    DrawGoalText(Master.playerdeta.WeeklyMission1, i);
                    break;
                case 1:
                    DrawGoalText(Master.playerdeta.WeeklyMission2, i);
                    break;
                case 2:
                    DrawGoalText(Master.playerdeta.WeeklyMission3, i);
                    break;
                case 3:
                    DrawGoalText(Master.playerdeta.WeeklyMission4, i);
                    break;
                case 4:
                    DrawGoalText(Master.playerdeta.WeeklyMission5, i);
                    break;
                case 5:
                    DrawGoalText(Master.playerdeta.WeeklyMission6, i);
                    break;
                default:
                    Debug.LogError("Illegal value");
                    break;
            }
        }

    }

    //達成状況の反映（テキスト）
    private void DrawGoalText(bool flag, int index)
    {
        string text = flag ? "達 成" : "未達成";
        details.transform.GetChild(index).transform.GetChild(0).GetComponent<Text>().text = text;
    }
    //達成状況の反映（色）
    private void DrawDetailsColor(bool didMissionClearFlag, bool isGetRewardFlag, int index)
    {
        if (didMissionClearFlag) //達成済みで報酬も受け取っている
        {
            details.transform.GetChild(index).GetComponent<Image>().color = Color.gray;
            details.transform.GetChild(index).GetComponent<Button>().enabled = false;
        }
        else if (isGetRewardFlag) //達成済みだが報酬をまだ受け取っていない
        {
            details.transform.GetChild(index).GetComponent<Image>().color = Color.red;
            details.transform.GetChild(index).GetComponent<Button>().enabled = true;
        }
        else //達成していない
        {
            details.transform.GetChild(index).GetComponent<Image>().color = Color.white;
            details.transform.GetChild(index).GetComponent<Button>().enabled = false;
        }
    }
}
