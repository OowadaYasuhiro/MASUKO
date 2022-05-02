using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormationSelectWindowButton : MonoBehaviour
{
    public void OnClickSelectCharacter(int posNum)
    {
        OrganizationScreen_Deta.selectCharacterNum = posNum;
        GameObject.Find("UIDirector").GetComponent<FormationMain>().EraseSelectWindow();
    }
}
