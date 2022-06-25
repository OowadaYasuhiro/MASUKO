using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FightButton : MonoBehaviour
{
    public void OnClickFight()
    {
        Load_Deta.Nextscenename = "StageSelectScene";
        SceneManager.LoadScene("Yanai_TestScene");
    }
}
