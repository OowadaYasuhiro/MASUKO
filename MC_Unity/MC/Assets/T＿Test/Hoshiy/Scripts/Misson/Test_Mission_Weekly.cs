using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_Mission_Weekly : MonoBehaviour
{
    public static void SetButtonColors(GameObject[] buttons)
    {
        for (var i = 0; i < buttons.Length; i++)
        {
            if (i == 1)
            {
                buttons[1].GetComponent<Image>().color = Color.white;
                continue;
            }
            buttons[i].GetComponent<Image>().color = Color.gray;
        }
    }

    public static void SetWeeklyMissions(GameObject[] details, GameObject title)
    {
        title.GetComponent<Text>().text = "Weekly Missions";

        for (var i = 0; i < details.Length; i++)
        {
            details[i].transform.GetChild(0).GetComponent<Text>().text = Hy_Test_Data.weeklyMissions[i];
            if (Hy_Test_Data.didGetRewardsWeekly[i])
            {
                details[i].transform.GetChild(1).GetComponent<Text>().text = "達成";
            }
            else
            {
                details[i].transform.GetChild(1).GetComponent<Text>().text = "未達成";
            }
        }
    }

    public static void SetDetailsColors(GameObject[] details)
    {
        for (var i = 0; i < details.Length; i++)
        {
            if (Hy_Test_Data.didGetRewardsWeekly[i])
            {
                details[i].GetComponent<Image>().color = Color.gray;
                details[i].GetComponent<Button>().enabled = false;
            }
            else if (Hy_Test_Data.canGetRewardsWeekly[i])
            {
                details[i].GetComponent<Image>().color = Color.red;
                details[i].GetComponent<Button>().enabled = true;
            }
            else
            {
                details[i].GetComponent<Image>().color = Color.white;
                details[i].GetComponent<Button>().enabled = false;
            }
        }
    }
}
