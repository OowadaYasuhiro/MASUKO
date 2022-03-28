using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_Mission_Acheive : MonoBehaviour
{
    public static void SetButtonColors(GameObject[] buttons)
    {
        for (var i = 0; i < buttons.Length; i++)
        {
            if (i == 2)
            {
                buttons[2].GetComponent<Image>().color = Color.white;
                continue;
            }
            buttons[i].GetComponent<Image>().color = Color.gray;
        }
    }

    public static void SetAcheiveMissions(GameObject[] details, GameObject title)
    {
        title.GetComponent<Text>().text = "Acheivement Missions";

        details[0].transform.GetChild(0).GetComponent<Text>().text = Hy_Test_Data.acheiveMission1.Peek();
        details[1].transform.GetChild(0).GetComponent<Text>().text = Hy_Test_Data.acheiveMission2.Peek();
        details[2].transform.GetChild(0).GetComponent<Text>().text = Hy_Test_Data.acheiveMission3.Peek();
        details[3].transform.GetChild(0).GetComponent<Text>().text = Hy_Test_Data.acheiveMission4.Peek();
        details[4].transform.GetChild(0).GetComponent<Text>().text = Hy_Test_Data.acheiveMission5.Peek();
        details[5].transform.GetChild(0).GetComponent<Text>().text = Hy_Test_Data.acheiveMission6.Peek();

        for (var i = 0; i < details.Length; i++)
        {
            if (Hy_Test_Data.didAllClearMissions[i])
            {
                details[i].transform.GetChild(1).GetComponent<Text>().text = "達成";
            } else
            {
                details[i].transform.GetChild(1).GetComponent<Text>().text = "未達成";
            }
        }
    }

    public static void SetDetailsColors(GameObject[] details)
    {
        for (var i = 0; i < details.Length; i++)
        {
            if (Hy_Test_Data.didAllClearMissions[i])
            {
                details[i].GetComponent<Image>().color = Color.gray;
                details[i].GetComponent<Button>().enabled = false;
            }
            else if (Hy_Test_Data.canGetRewardsAceheive[i])
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
