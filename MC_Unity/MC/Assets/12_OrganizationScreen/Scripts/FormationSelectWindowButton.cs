using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormationSelectWindowButton : MonoBehaviour
{
    private GameObject director;

    private void Start()
    {
        director = GameObject.Find("UIDirector");
    }

    public void OnClickSelectCharacter(int posNum)
    {
        if (OrganizationScreen_Deta.isLeftCharacter)
        {
            if (posNum == OrganizationScreen_Deta.rightCharacterNum)
            {
                OrganizationScreen_Deta.rightCharacterNum = OrganizationScreen_Deta.leftCharacterNum;
                OrganizationScreen_Deta.isLeftCharacter = false;
                director.GetComponent<FormationMain>().DrawCharacterUITextsAndImage();
                OrganizationScreen_Deta.isLeftCharacter = true;
                OrganizationScreen_Deta.leftCharacterNum = posNum;
            }
            else if (posNum == OrganizationScreen_Deta.leftCharacterNum && OrganizationScreen_Deta.rightCharacterNum != -1)
            {
                OrganizationScreen_Deta.leftCharacterNum = OrganizationScreen_Deta.rightCharacterNum;
                OrganizationScreen_Deta.rightCharacterNum = -1;
                OrganizationScreen_Deta.isLeftCharacter = false;
                director.GetComponent<FormationMain>().DrawCharacterUITextsAndImage();
                OrganizationScreen_Deta.isLeftCharacter = true;
            }
            else
            {
                OrganizationScreen_Deta.leftCharacterNum = posNum;
            }
        }
        else
        {
            if (posNum == OrganizationScreen_Deta.leftCharacterNum)
            {
                OrganizationScreen_Deta.leftCharacterNum = OrganizationScreen_Deta.rightCharacterNum;
                OrganizationScreen_Deta.isLeftCharacter = true;
                director.GetComponent<FormationMain>().DrawCharacterUITextsAndImage();
                OrganizationScreen_Deta.isLeftCharacter = false;
                OrganizationScreen_Deta.rightCharacterNum = posNum;
            }
            else if (posNum == OrganizationScreen_Deta.rightCharacterNum)
            {
                OrganizationScreen_Deta.rightCharacterNum = -1;
            }
            else
            {
                OrganizationScreen_Deta.rightCharacterNum = posNum;
            }
        }

        director.GetComponent<FormationMain>().EraseSelectWindow();
    }
}
