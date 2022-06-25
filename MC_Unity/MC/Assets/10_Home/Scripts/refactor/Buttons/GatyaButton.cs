using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GatyaButton : MonoBehaviour
{
    public void OnClickGatya()
    {
        Load_Deta.Nextscenename = "CapsuleToyScreenScene";
        SceneManager.LoadScene("Yanai_TestScene");
    }
}
