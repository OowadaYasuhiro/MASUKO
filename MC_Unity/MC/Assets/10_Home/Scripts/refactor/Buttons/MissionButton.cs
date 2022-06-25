using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionButton : MonoBehaviour
{
    public void OnClickMission()
    {
        Load_Deta.Nextscenename = "MissionScreenScene";
        SceneManager.LoadScene("Yanai_TestScene");
    }
}
