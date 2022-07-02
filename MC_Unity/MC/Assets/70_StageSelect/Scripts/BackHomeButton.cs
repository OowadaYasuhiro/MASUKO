using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackHomeButton : MonoBehaviour
{
    public void OnClickOption()
    {
        Load_Deta.Nextscenename = "HomeScene";
        SceneManager.LoadScene("Yanai_TestScene");
    }
}
