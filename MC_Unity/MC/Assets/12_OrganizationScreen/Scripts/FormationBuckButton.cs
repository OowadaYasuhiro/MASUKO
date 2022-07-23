using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Formation
{
    public class FormationBuckButton : MonoBehaviour
    {
        [SerializeField]
        private GameObject leftWindow;
        [SerializeField]
        private GameObject rightWindow;
        [SerializeField]
        private GameObject selectWindow;

        public void OnClickBuck()
        {
            if (OrganizationScreen_Deta.isCharaSelect)
            {
                leftWindow.SetActive(true);
                rightWindow.SetActive(true);
                selectWindow.SetActive(false);
                OrganizationScreen_Deta.isCharaSelect = false;
            }
            else
            {
                Load_Deta.Nextscenename = "HomeScene";
                SceneManager.LoadScene("Yanai_TestScene");
            }
        }
    }
}
