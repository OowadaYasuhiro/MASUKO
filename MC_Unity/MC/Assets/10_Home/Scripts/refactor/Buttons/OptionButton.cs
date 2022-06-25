using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionButton : MonoBehaviour
{
    public void OnClickOption()
    {
        Load_Deta.Nextscenename = "SettingsScreenScene";
        SceneManager.LoadScene("Yanai_TestScene");
    }
}
