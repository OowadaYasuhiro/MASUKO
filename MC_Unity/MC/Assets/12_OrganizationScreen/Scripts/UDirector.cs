using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UDirector : MonoBehaviour
{
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
