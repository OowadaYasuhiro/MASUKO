using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Test_Misson_ButtonEvents : MonoBehaviour
{
    [SerializeField]
    private GameObject[] buttons;
    [SerializeField]
    private GameObject[] details;
    [SerializeField]
    private GameObject title;
    [SerializeField]
    private GameObject rewardWindow;
    [SerializeField]
    private GameObject allGetButton;

    private int num = 0;

    private int kakon = 0;
    private int charaExp = 0;
    private int money = 0;

    private bool[] canGetReward = {false,false,false,false };

    void Start()
    {
        rewardWindow.SetActive(false);
        setAllGetButtonState();
    }

    public void OnClickBuckButton()
    {
        SceneManager.LoadScene("Hoshiy_TestScene");
    }

    public void OnClickDailyButton()
    {
        Test_Mission_Daily.SetButtonColors(buttons);
        Test_Mission_Daily.SetDailyMissions(details,title);
        Test_Mission_Daily.SetDetailsColors(details);
        num = 0;
    }

    public void OnClickWeeklyButton()
    {
        Test_Mission_Weekly.SetButtonColors(buttons);
        Test_Mission_Weekly.SetWeeklyMissions(details, title);
        Test_Mission_Weekly.SetDetailsColors(details);
        num = 1;
    }

    public void OnClickAcheiveButton()
    {
        Test_Mission_Acheive.SetButtonColors(buttons);
        Test_Mission_Acheive.SetAcheiveMissions(details, title);
        Test_Mission_Acheive.SetDetailsColors(details);
        num = 2;
    }

    public void OnClickQuestButton()
    {
        Test_Mission_Quest.SetButtonColors(buttons);
        Test_Mission_Quest.SetQuestMissions(details, title);
        Test_Mission_Quest.SetDetailsColors(details);
        num = 3;
    }

    public void OnClickDetailButton(int index)
    {
        rewardWindow.SetActive(true);
        switch (num)
        {
            case 0:
                if (index == 0 || index == 1 || index == 2) {
                    rewardWindow.transform.GetChild(2).GetComponent<Text>().text = Hy_Test_Data.missionRewardKakon10;
                    Hy_Test_Data.gatyaAmount += 10;
                } else if (index == 3 || index == 4)
                {
                    rewardWindow.transform.GetChild(2).GetComponent<Text>().text = Hy_Test_Data.missionRewardKakonAndSinenSmall;
                    Hy_Test_Data.gatyaAmount += 10;
                    Hy_Test_Data.expAmount += 2000;
                } else
                {
                    rewardWindow.transform.GetChild(2).GetComponent<Text>().text = Hy_Test_Data.missionRewardKakon50;
                    Hy_Test_Data.gatyaAmount += 50;
                }
                Hy_Test_Data.canGetRewardsDaily[index] = false;
                break;
            case 1:
                if (index == 0)
                {
                    rewardWindow.transform.GetChild(2).GetComponent<Text>().text = Hy_Test_Data.missionRewardKakon50;
                    Hy_Test_Data.gatyaAmount += 50;
                } else if (index == 1 || index == 2)
                {
                    rewardWindow.transform.GetChild(2).GetComponent<Text>().text = Hy_Test_Data.missionRewardKakonAndSinenLarge;
                    Hy_Test_Data.gatyaAmount += 20;
                    Hy_Test_Data.expAmount += 5000;
                } else
                {
                    rewardWindow.transform.GetChild(2).GetComponent<Text>().text = Hy_Test_Data.missionRewardKakonAndMoney;
                    Hy_Test_Data.gatyaAmount += 20;
                    Hy_Test_Data.moneyAmount += 5000;
                }
                Hy_Test_Data.canGetRewardsWeekly[index] = false;
                break;
            case 2:
                if (index == 6)
                {
                    rewardWindow.transform.GetChild(2).GetComponent<Text>().text = Hy_Test_Data.missionRewardKakon2000;
                    Hy_Test_Data.gatyaAmount += 2000;
                } else
                {
                    rewardWindow.transform.GetChild(2).GetComponent<Text>().text = Hy_Test_Data.missionRewardKakon50;
                    Hy_Test_Data.gatyaAmount += 50;
                }
                break;
            case 3:
                rewardWindow.transform.GetChild(2).GetComponent<Text>().text = Hy_Test_Data.missionRewardKakon50;
                Hy_Test_Data.gatyaAmount += 50;
                Hy_Test_Data.canGetRewardsQuest[index] = false;
                break;
            default:
                Debug.Log("Error:");
                break;
        }

        switch (num)
        {
            case 0:
                Hy_Test_Data.didGetRewardsDaily[index] = true;
                OnClickDailyButton();
                break;
            case 1:
                Hy_Test_Data.didGetRewardsWeekly[index] = true;
                OnClickWeeklyButton();
                break;
            case 2:
                if (index == 0 && Hy_Test_Data.acheiveMission1.Count != 1)
                {
                    Hy_Test_Data.acheiveMission1.Dequeue();
                    Hy_Test_Data.canGetRewardsAceheive[0] = false;
                } else if (index == 1 && Hy_Test_Data.acheiveMission2.Count != 1)
                {
                    Hy_Test_Data.acheiveMission2.Dequeue();
                    Hy_Test_Data.canGetRewardsAceheive[1] = false;
                } else if (index == 2 && Hy_Test_Data.acheiveMission3.Count != 1)
                {
                    Hy_Test_Data.acheiveMission3.Dequeue();
                    Hy_Test_Data.canGetRewardsAceheive[2] = false;
                } else if (index == 3 && Hy_Test_Data.acheiveMission4.Count != 1)
                {
                    Hy_Test_Data.acheiveMission4.Dequeue();
                    Hy_Test_Data.canGetRewardsAceheive[3] = false;
                } else if (index == 4 && Hy_Test_Data.acheiveMission5.Count != 1)
                {
                    Hy_Test_Data.acheiveMission5.Dequeue();
                    Hy_Test_Data.canGetRewardsAceheive[4] = false;
                } else if (index == 5 && Hy_Test_Data.acheiveMission6.Count != 1)
                {
                    Hy_Test_Data.acheiveMission6.Dequeue();
                    Hy_Test_Data.canGetRewardsAceheive[5] = false;
                }

                if (Hy_Test_Data.acheiveMission1.Count == 1)
                {
                    Hy_Test_Data.didAllClearMissions[0] = true;
                } else if (Hy_Test_Data.acheiveMission2.Count == 1)
                {
                    Hy_Test_Data.didAllClearMissions[1] = true;
                } else if (Hy_Test_Data.acheiveMission3.Count == 1)
                {
                    Hy_Test_Data.didAllClearMissions[2] = true;
                } else if (Hy_Test_Data.acheiveMission4.Count == 1)
                {
                    Hy_Test_Data.didAllClearMissions[3] = true;
                } else if (Hy_Test_Data.acheiveMission5.Count == 1)
                {
                    Hy_Test_Data.didAllClearMissions[4] = true;
                } else if (Hy_Test_Data.acheiveMission6.Count == 1)
                {
                    Hy_Test_Data.didAllClearMissions[5] = true;
                }
                OnClickAcheiveButton();
                break;
            case 3:
                Hy_Test_Data.didGetRewardsQuest[index] = true;
                OnClickQuestButton();
                break;
            default:
                Debug.Log("Error:");
                break;
        }
    }

    public void OnClickCloseRewardWindowButton()
    {
        rewardWindow.SetActive(false);
        setAllGetButtonState();
    }

    public void OnClickAllGetButton()
    {
        int stateNum = num;
        rewardWindow.SetActive(true);
        for (var i = 0; i < Hy_Test_Data.canGetRewardsDaily.Length; i++)
        {
            if (Hy_Test_Data.canGetRewardsDaily[i])
            {
                if (i == 0 || i == 1 || i == 2)
                {
                    kakon += 10;
                } 
                else if (i == 3 || i == 4)
                {
                    kakon += 10;
                    charaExp += 2000;
                }
                else
                {
                    kakon += 50;
                }
                Hy_Test_Data.didGetRewardsDaily[i] = true;
                Hy_Test_Data.canGetRewardsDaily[i] = false;
            }
            OnClickDailyButton();
        }

        for (var i = 0; i < Hy_Test_Data.canGetRewardsWeekly.Length; i++)
        {
            if (Hy_Test_Data.canGetRewardsWeekly[i])
            {
                if (i == 0)
                {
                    kakon += 50;
                } 
                else if (i == 1 || i == 2)
                {
                    kakon += 20;
                    charaExp += 5000;
                }
                else
                {
                    kakon += 20;
                    money += 5000;
                }
                Hy_Test_Data.didGetRewardsWeekly[i] = true;
                Hy_Test_Data.canGetRewardsWeekly[i] = false;
            }
            OnClickWeeklyButton();
        }

        for (var i = 0; i < Hy_Test_Data.canGetRewardsQuest.Length; i++)
        {
            if (Hy_Test_Data.canGetRewardsQuest[i])
            {
                kakon += 50;
                Hy_Test_Data.didGetRewardsQuest[i] = true;
                Hy_Test_Data.canGetRewardsQuest[i] = false;
            }
            OnClickQuestButton();
        }

        for (var i = 0; i < Hy_Test_Data.canGetRewardsAceheive.Length; i++)
        {
            if (Hy_Test_Data.canGetRewardsAceheive[i])
            {
                if (i == 6)
                {
                    kakon += 2000;
                }
                else
                {
                    kakon += 50;
                }

                if (i == 0 && Hy_Test_Data.acheiveMission1.Count != 1)
                {
                    Hy_Test_Data.acheiveMission1.Dequeue();
                    Hy_Test_Data.canGetRewardsAceheive[0] = false;
                }
                else if (i == 1 && Hy_Test_Data.acheiveMission2.Count != 1)
                {
                    Hy_Test_Data.acheiveMission2.Dequeue();
                    Hy_Test_Data.canGetRewardsAceheive[1] = false;
                }
                else if (i == 2 && Hy_Test_Data.acheiveMission3.Count != 1)
                {
                    Hy_Test_Data.acheiveMission3.Dequeue();
                    Hy_Test_Data.canGetRewardsAceheive[2] = false;
                }
                else if (i == 3 && Hy_Test_Data.acheiveMission4.Count != 1)
                {
                    Hy_Test_Data.acheiveMission4.Dequeue();
                    Hy_Test_Data.canGetRewardsAceheive[3] = false;
                }
                else if (i == 4 && Hy_Test_Data.acheiveMission5.Count != 1)
                {
                    Hy_Test_Data.acheiveMission5.Dequeue();
                    Hy_Test_Data.canGetRewardsAceheive[4] = false;
                }
                else if (i == 5 && Hy_Test_Data.acheiveMission6.Count != 1)
                {
                    Hy_Test_Data.acheiveMission6.Dequeue();
                    Hy_Test_Data.canGetRewardsAceheive[5] = false;
                }

                if (Hy_Test_Data.acheiveMission1.Count == 1)
                {
                    Hy_Test_Data.didAllClearMissions[0] = true;
                }
                else if (Hy_Test_Data.acheiveMission2.Count == 1)
                {
                    Hy_Test_Data.didAllClearMissions[1] = true;
                }
                else if (Hy_Test_Data.acheiveMission3.Count == 1)
                {
                    Hy_Test_Data.didAllClearMissions[2] = true;
                }
                else if (Hy_Test_Data.acheiveMission4.Count == 1)
                {
                    Hy_Test_Data.didAllClearMissions[3] = true;
                }
                else if (Hy_Test_Data.acheiveMission5.Count == 1)
                {
                    Hy_Test_Data.didAllClearMissions[4] = true;
                }
                else if (Hy_Test_Data.acheiveMission6.Count == 1)
                {
                    Hy_Test_Data.didAllClearMissions[5] = true;
                }
                OnClickAcheiveButton();
            }
        }

        switch (stateNum)
        {
            case 0:
                OnClickDailyButton();
                break;
            case 1:
                OnClickWeeklyButton();
                break;
            case 2:
                OnClickAcheiveButton();
                break;
            case 3:
                OnClickQuestButton();
                break;
            default:
                Debug.Log("error");
                break;
        }

        rewardWindow.transform.GetChild(2).GetComponent<Text>().text = "";
        if (kakon != 0)
        {
            rewardWindow.transform.GetChild(2).GetComponent<Text>().text += "禍根　" + kakon.ToString() + "\n";
        }
        if (charaExp != 0)
        {
            rewardWindow.transform.GetChild(2).GetComponent<Text>().text += "残留思念　" + charaExp.ToString() + "\n";
        }
        if (money != 0)
        {
            rewardWindow.transform.GetChild(2).GetComponent<Text>().text = "コイン　" + money.ToString() + "\n";
        }

        for (var i = 0; i < canGetReward.Length; i++)
        {
            canGetReward[i] = false;
        }
    }

    private void setAllGetButtonState()
    {
        for (var i = 0; i < Hy_Test_Data.canGetRewardsDaily.Length; i++)
        {
            if (Hy_Test_Data.canGetRewardsDaily[i])
            {
                canGetReward[0] = true;
                break;
            }
        }

        for (var i = 0; i < Hy_Test_Data.canGetRewardsWeekly.Length; i++)
        {
            if (Hy_Test_Data.canGetRewardsWeekly[i])
            {
                canGetReward[1] = true;
                break;
            }
        }

        for (var i = 0; i < Hy_Test_Data.canGetRewardsAceheive.Length; i++)
        {
            if (Hy_Test_Data.canGetRewardsAceheive[i])
            {
                canGetReward[2] = true;
                break;
            }
        }

        for (var i = 0; i < Hy_Test_Data.canGetRewardsQuest.Length; i++)
        {
            if (Hy_Test_Data.canGetRewardsQuest[i])
            {
                canGetReward[3] = true;
            }
        }

        for (var i = 0; i < canGetReward.Length; i++)
        {
            if (canGetReward[i])
            {
                allGetButton.GetComponent<Image>().color = Color.white;
                allGetButton.GetComponentInChildren<Text>().color = Color.black;
                allGetButton.GetComponent<Button>().enabled = true;
                break;
            }
            allGetButton.GetComponent<Image>().color = Color.gray;
            allGetButton.GetComponentInChildren<Text>().color = Color.white;
            allGetButton.GetComponent<Button>().enabled = false;
        }
    }
}
