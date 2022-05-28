using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HomeScene
{
    sealed class HeaderDrawText : MonoBehaviour
    {
        [SerializeField]
        private GameObject playerLevelUI;
        [SerializeField]
        private GameObject playerNameUI;
        [SerializeField]
        private GameObject playerExpUI;
        [SerializeField]
        private bool isDebug;

        private string playerLevel;
        private string playerName;
        private int playerExp;

        private HeaderDrawText() { }

        void Start()
        {
            if (isDebug)
            {
                TestDrawHeader();
            }
            else
            {
                ReferencePlayerHeaderData();
                DrawHeaderUI();
            }
        }

        private void ReferencePlayerHeaderData()
        {
            this.playerLevel = Master.playerdeta.PlayerLevel.ToString();
            this.playerLevel = Master.playerdeta.PlayerName;
            this.playerExp = Master.playerdeta.PlayerExperience;
        }

        private void DrawHeaderUI()
        {
            playerLevelUI.GetComponent<Text>().text = playerLevel;
            playerNameUI.GetComponent<Text>().text = playerName;
            playerExpUI.GetComponent<Image>().fillAmount = playerExp;
        }

        private void TestDrawHeader()
        {
            playerLevelUI.GetComponent<Text>().text = "99";
            playerNameUI.GetComponent<Text>().text = "playerName";
            playerExpUI.GetComponent<Image>().fillAmount = 0.5f;
        }
    }
}
