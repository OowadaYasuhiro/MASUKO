using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//必要なもの
using UnityEngine.UI;

public class Test_Mission_Daily : MonoBehaviour
{
    /// <summary>
    /// デイリーミッションに関するメソッド群
    /// </summary>

    //デイリーボタンを明るくし、それ以外を暗くする
    public static void SetButtonColors(GameObject[] buttons)
    {
        for (var i = 0; i < buttons.Length; i++)
        {
            if (i == 0)
            {
                buttons[0].GetComponent<Image>().color = Color.white;
                continue;
            }
            buttons[i].GetComponent<Image>().color = Color.gray;
        }
    }

    //デイリーミッションの詳細をテキストにセット
    public static void SetDailyMissions(GameObject[] details,GameObject title)
    {
        title.GetComponent<Text>().text = "Daily Missions";

        for (var i = 0; i < details.Length; i++)
        {
            details[i].transform.GetChild(0).GetComponent<Text>().text = Hy_Test_Data.dailyMissions[i];
            if (Hy_Test_Data.didGetRewardsDaily[i])
            {
                details[i].transform.GetChild(1).GetComponent<Text>().text = "達成";
            } else
            {
                details[i].transform.GetChild(1).GetComponent<Text>().text = "未達成";
            }
        }
    }

    //達成状況に応じて色を変える
    public static void SetDetailsColors(GameObject[] details)
    {
        for (var i = 0; i < details.Length; i++)
        {
            if (Hy_Test_Data.didGetRewardsDaily[i])　
            {
                details[i].GetComponent<Image>().color = Color.gray;
                details[i].GetComponent<Button>().enabled = false;
            } else if(Hy_Test_Data.canGetRewardsDaily[i])
            {
                details[i].GetComponent<Image>().color = Color.red;
                details[i].GetComponent<Button>().enabled = true;
            } else
            {
                details[i].GetComponent<Image>().color = Color.white;
                details[i].GetComponent<Button>().enabled = false;
            }
        }
    }
}
