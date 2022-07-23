using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Formation
{
    public class UDirector : MonoBehaviour
    {
        [SerializeField]
        private GameObject charaSelect;

        private void Start()
        {
            Charactor leftChara;
            Charactor rightChara;

            if (Master.formationdeta.selectcharactor1 != null)
            {
                leftChara = (Charactor)Master.formationdeta.selectcharactor1;
                SetCharacterNum(leftChara, true);
            }
            if (Master.formationdeta.selectcharactor2 != null)
            {
                rightChara = (Charactor)Master.formationdeta.selectcharactor2;
                SetCharacterNum(rightChara, false);
            }

            if (Master.formationdeta.selectcharactor1 == null)
            {
                OrganizationScreen_Deta.leftCharacterNum = -1;
            }
            if (Master.formationdeta.selectcharactor2 == null)
            {
                OrganizationScreen_Deta.rightCharacterNum = -1;
            }

            charaSelect.transform.GetChild(0).transform.GetChild(2).GetComponent<Text>().text = "Lv" + PlayerPrefs.GetString("ghostLv");
            charaSelect.transform.GetChild(1).transform.GetChild(2).GetComponent<Text>().text = "Lv" + PlayerPrefs.GetString("zasikiwarasiLv");
            charaSelect.transform.GetChild(2).transform.GetChild(2).GetComponent<Text>().text = "Lv" + PlayerPrefs.GetString("orgaLv");
            charaSelect.transform.GetChild(3).transform.GetChild(2).GetComponent<Text>().text = "Lv" + PlayerPrefs.GetString("poltergeistLv");
            charaSelect.transform.GetChild(4).transform.GetChild(2).GetComponent<Text>().text = "Lv" + PlayerPrefs.GetString("demonLv");
        }

        private void SetCharacterNum(Charactor charactor, bool isleft)
        {
            switch (charactor.name)
            {
                case "幽霊":
                    if (isleft)
                    {
                        OrganizationScreen_Deta.leftCharacterNum = 0;
                    }
                    else
                    {
                        OrganizationScreen_Deta.rightCharacterNum = 0;
                    }
                    break;
                case "座敷童":
                    if (isleft)
                    {
                        OrganizationScreen_Deta.leftCharacterNum = 1;
                    }
                    else
                    {
                        OrganizationScreen_Deta.rightCharacterNum = 1;
                    }
                    break;
                case "鬼":
                    if (isleft)
                    {
                        OrganizationScreen_Deta.leftCharacterNum = 2;
                    }
                    else
                    {
                        OrganizationScreen_Deta.rightCharacterNum = 2;
                    }
                    break;
                case "ポルターガイスト":
                    if (isleft)
                    {
                        OrganizationScreen_Deta.leftCharacterNum = 3;
                    }
                    else
                    {
                        OrganizationScreen_Deta.rightCharacterNum = 3;
                    }
                    break;
                case "悪魔":
                    if (isleft)
                    {
                        OrganizationScreen_Deta.leftCharacterNum = 4;
                    }
                    else
                    {
                        OrganizationScreen_Deta.rightCharacterNum = 4;
                    }
                    break;
                default:
                    Debug.LogError("");
                    break;
            }
        }

    }
}