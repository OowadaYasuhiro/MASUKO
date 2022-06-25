using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FormationButton : MonoBehaviour
{
    public void OnClickFormation()
    {
        Load_Deta.Nextscenename = "OrganizationScreenScene";
        SceneManager.LoadScene("Yanai_TestScene");
    }
}
