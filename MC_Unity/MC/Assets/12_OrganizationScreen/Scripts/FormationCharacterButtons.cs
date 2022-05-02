using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FormationCharacterButtons : MonoBehaviour
{
    public void OnClickCharacter(bool isLeft)
    {
        GameObject director = GameObject.Find("UIDirector");
        OrganizationScreen_Deta.isLeftCharacter = isLeft;
        director.GetComponent<FormationMain>().ShowSelectWindow();
    }

    public void OnClickArmor(int posNum)
    {
        OrganizationScreen_Deta.armorNum = posNum;
        SceneManager.LoadScene("RecoveryOfBelongingsScreenScene");
    }
}
