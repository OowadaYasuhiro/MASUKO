using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FormationArmorButton : MonoBehaviour
{
    public void OnClickArmor(int posNum)
    {
        OrganizationScreen_Deta.armorNum = posNum;
        SceneManager.LoadScene("RecoveryOfBelongingsScreenScene");
    }
}
