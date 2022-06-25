using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnhanceButton : MonoBehaviour
{
    public void OnClickEnhance()
    {
        Load_Deta.Nextscenename = "EnhancementScreenScene";
        SceneManager.LoadScene("Yanai_TestScene");
    }
}
