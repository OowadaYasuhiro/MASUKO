using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Test_Mission_Main : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>

    [SerializeField]
    private GameObject rewardWindow;
    [SerializeField]
    private GameObject allGetButton;

    private bool canGetReward = false;

    void Start()
    {
        //報酬表示画面は消しておく
        rewardWindow.SetActive(false);

        //デイリーミッションを最初に表示する
        this.gameObject.GetComponent<Test_Misson_ButtonEvents>().OnClickDailyButton();

        SetAllGetButtonState();
    }

    public void SetAllGetButtonState()
    {
        for (var i = 0; i < Hy_Test_Data.canGetRewardsDaily.Length; i++)
        {
            if (Hy_Test_Data.canGetRewardsDaily[i])
            {
                canGetReward = true;
                break;
            }
        }

        for (var i = 0; i < Hy_Test_Data.canGetRewardsWeekly.Length; i++)
        {
            if (Hy_Test_Data.canGetRewardsWeekly[i])
            {
                canGetReward = true;
                break;
            }
        }

        for (var i = 0; i < Hy_Test_Data.canGetRewardsAceheive.Length; i++)
        {
            if (Hy_Test_Data.canGetRewardsAceheive[i])
            {
                canGetReward = true;
                break;
            }
        }

        for (var i = 0; i < Hy_Test_Data.canGetRewardsQuest.Length; i++)
        {
            if (Hy_Test_Data.canGetRewardsQuest[i])
            {
                canGetReward = true;
            }
        }

        if (canGetReward)
        {
            allGetButton.GetComponent<Image>().color = Color.white;
            allGetButton.GetComponentInChildren<Text>().color = Color.black;
            allGetButton.GetComponent<Button>().enabled = true;
        }
        else
        {
            allGetButton.GetComponent<Image>().color = Color.gray;
            allGetButton.GetComponentInChildren<Text>().color = Color.white;
            allGetButton.GetComponent<Button>().enabled = false;
        }
    }

    public void SetCanGetReward(bool b)
    {
        this.canGetReward = b;
    }
}
