using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Formation
{
    public class FormationBuckButton : MonoBehaviour
    {
        public void OnClickBuck()
        {
            Load_Deta.Nextscenename = "HomeScene";
            SceneManager.LoadScene("Yanai_TestScene");
        }
    }
}
