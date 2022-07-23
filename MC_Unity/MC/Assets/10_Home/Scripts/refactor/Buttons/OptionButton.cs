using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionButton : MonoBehaviour
{
    [SerializeField]GameObject settings;
    public void OnClickOption()
    {
        settings.SetActive(true);
        //Load_Deta.Nextscenename = "SettingsScreenScene";
        //SceneManager.LoadScene("Yanai_TestScene");
    }
}
