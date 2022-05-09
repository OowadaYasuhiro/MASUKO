using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalConfirmationScreen : MonoBehaviour
{
    [SerializeField]
    public GameObject[] source;
    [SerializeField]
    public GameObject[] star;
    [SerializeField]
    public GameObject[] back;
    [SerializeField]
    public Image[] stageimages;
    [SerializeField]
    public Image[] caractorimages;
    [SerializeField]
    public Image[] doropimages;
    [SerializeField]
    public Text FCSQtext;
    [SerializeField]
    public Text FCRLtext;
    [SerializeField]
    public Text FCStext;
    public int[] ep;
    EP epScript;


    // Start is called before the first frame update
    void Start()
    {
        source[0].SetActive(false);
        epScript = GetComponent<EP>();
        for (int i = 0; i < ep.Length; i++)
        {
            ep[i] = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EP()
    {
        epScript.SelectOnClick(epScript.SelectOn_num);
        epScript.SelectStagestageB_num(epScript.SelectStagestageB_num_num);
        switch (epScript.sNumber)
        {
            case 0:
                switch (epScript.SelectOn_num)
                {
                    case 1:
                        switch (epScript.SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[0] += 1;
                                if(ep[0] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 2:
                                ep[1] += 1;
                                if (ep[1] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 3:
                                ep[2] += 1;
                                if (ep[2] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 4:
                                ep[3] += 1;
                                if (ep[3] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;

                        }
                        break;
                    case 2:
                        switch (epScript.SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[4] += 1;
                                if (ep[4] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 2:
                                ep[5] += 1;
                                if (ep[5] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 3:
                                ep[6] += 1;
                                if (ep[6] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 4:
                                ep[7] += 1;
                                if (ep[7] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;

                        }
                        break;
                    case 3:
                        switch (epScript.SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[8] += 1;
                                if (ep[8] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 2:
                                ep[9] += 1;
                                if (ep[9] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 3:
                                ep[10] += 1;
                                if (ep[10] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 4:
                                ep[11] += 1;
                                if (ep[11] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                        }
                        break;
                    case 4:
                        switch (epScript.SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[12] += 1;
                                if (ep[12] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 2:
                                ep[13] += 1;
                                if (ep[13] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 3:
                                ep[14] += 1;
                                if (ep[14] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 4:
                                ep[15] += 1;
                                if (ep[15] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;

                        }
                        break;
                    case 5:
                        switch (epScript.SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[16] += 1;
                                if (ep[16] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 2:
                                ep[17] += 1;
                                if (ep[17] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 3:
                                ep[18] += 1;
                                if (ep[18] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 4:
                                ep[19] += 1;
                                if (ep[19] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;

                        }
                        break;
                }
                break;
            case 1:
                switch (epScript.SelectOn_num)
                {
                    case 1:
                        switch (epScript.SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[20] += 1;
                                if (ep[20] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 2:
                                ep[21] += 1;
                                if (ep[21] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 3:
                                ep[22] += 1;
                                if (ep[22] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 4:
                                ep[23] += 1;
                                if (ep[23] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;

                        }
                        break;
                    case 2:
                        switch (epScript.SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[24] += 1;
                                if (ep[24] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 2:
                                ep[25] += 1;
                                if (ep[25] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 3:
                                ep[26] += 1;
                                if (ep[26] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 4:
                                ep[27] += 1;
                                if (ep[27] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;

                        }
                        break;
                    case 3:
                        switch (epScript.SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[28] += 1;
                                if (ep[28] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 2:
                                ep[29] += 1;
                                if (ep[29] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 3:
                                ep[30] += 1;
                                if (ep[30] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 4:
                                ep[31] += 1;
                                if (ep[31] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                        }
                        break;
                    case 4:
                        switch (epScript.SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[32] += 1;
                                if (ep[32] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 2:
                                ep[33] += 1;
                                if (ep[33] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 3:
                                ep[34] += 1;
                                if (ep[34] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 4:
                                ep[35] += 1;
                                if (ep[35] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                        }
                        break;
                    case 5:
                        switch (epScript.SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[36] += 1;
                                if (ep[36] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 2:
                                ep[37] += 1;
                                if (ep[37] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 3:
                                ep[38] += 1;
                                if (ep[38] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 4:
                                ep[39] += 1;
                                if (ep[39] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;

                        }
                        break;
                }
                break;
            case 2:

                switch (epScript.SelectOn_num)
                {
                    case 1:
                        switch (epScript.SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[40] += 1;
                                if (ep[40] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 2:
                                ep[41] += 1;
                                if (ep[41] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 3:
                                ep[42] += 1;
                                if (ep[42] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 4:
                                ep[43] += 1;
                                if (ep[43] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;

                        }
                        break;
                    case 2:
                        switch (epScript.SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[44] += 1;
                                if (ep[44] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 2:
                                ep[45] += 1;
                                if (ep[45] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 3:
                                ep[46] += 1;
                                if (ep[46] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 4:
                                ep[47] += 1;
                                if (ep[47] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;

                        }
                        break;
                    case 3:
                        switch (epScript.SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[48] += 1;
                                if (ep[48] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 2:
                                ep[49] += 1;
                                if (ep[49] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 3:
                                ep[50] += 1;
                                if (ep[50] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 4:
                                ep[51] += 1;
                                if (ep[51] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                        }
                        break;
                    case 4:
                        switch (epScript.SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[52] += 1;
                                if (ep[52] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 2:
                                ep[53] += 1;
                                if (ep[53] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 3:
                                ep[54] += 1;
                                if (ep[54] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 4:
                                ep[55] += 1;
                                if (ep[55] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;

                        }
                        break;
                    case 5:
                        switch (epScript.SelectStagestageB_num_num)
                        {
                            case 1:
                                ep[56] += 1;
                                if (ep[56] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 2:
                                ep[57] += 1;
                                if (ep[57] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 3:
                                ep[58] += 1;
                                if (ep[58] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                            case 4:
                                ep[59] += 1;
                                if (ep[59] == 1)
                                {
                                    epScript.stage_num[epScript.sNumber]++;
                                }
                                break;
                        }
                        break;
                }
                break;
        }
        Debug.Log(epScript.stage_num[epScript.sNumber] + "成功！！");
        if (epScript.stage_num[epScript.sNumber] % 5 == 0)
        {
            epScript.lstage_num[epScript.lsNumber]++;
            epScript.stage_num[epScript.sNumber] = 1;
        }
        Debug.Log(epScript.lstage_num[epScript.lsNumber]);

        Debug.Log(epScript.difficulty_num);

        Debug.Log(epScript.Difdifficulty);

        Debug.Log(epScript.SelectOn);

        Debug.Log(epScript.QuestOn);
    }
}
