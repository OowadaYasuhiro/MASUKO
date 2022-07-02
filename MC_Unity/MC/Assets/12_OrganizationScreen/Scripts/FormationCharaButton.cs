using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Formation
{
    public class FormationCharaButton : MonoBehaviour
    {
        [SerializeField]
        private GameObject leftWindow;
        [SerializeField]
        private GameObject rightwindow;
        [SerializeField]
        private GameObject selectwindow;

        public void OnClickChara(bool isLeft)
        {
            OrganizationScreen_Deta.isLeftCharacter = isLeft;
            leftWindow.SetActive(false);
            rightwindow.SetActive(false);
            selectwindow.SetActive(true);
        }
    }
}