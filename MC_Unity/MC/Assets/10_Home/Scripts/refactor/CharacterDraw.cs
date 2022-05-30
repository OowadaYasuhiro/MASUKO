﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HomeScene
{
    sealed class CharacterDraw : MonoBehaviour
    {
        [SerializeField]
        private GameObject messageWindow;
        [SerializeField]
        private Sprite[] characterImages = new Sprite[5]; 
        [SerializeField]
        private bool isDebug = true;

        private string characterName;
        private string characterSpeech;
        private Sprite characterImage;

        private CharacterDraw() { }

        private void Start()
        {
            if (isDebug)
            {
                TestUI(1);
            }
            else
            {
                ReferenceCharacterData();
                DrawMessageText();
                DrawCharacterImage();
            }

            messageWindow.SetActive(false);
        }

        public void OnClickCharacter()
        {
            StartCoroutine("ShowMessageWindow");
        }

        private void ReferenceCharacterData()
        {
            if (Master.playerdeta.NowSelectCharactor == "Ghost")
            {
                this.characterName = "Ghost";
                this.characterSpeech = HomeScene_Deta.ghostSpeechText;
                this.characterImage = characterImages[0];
                return;
            }
            if (Master.playerdeta.NowSelectCharactor == "Zasikiwarasi")
            {
                this.characterName = "Zasikiwarasi";
                this.characterSpeech = HomeScene_Deta.zasikiwarasiSpeechText;
                this.characterImage = characterImages[1];
                return;
            }
            if (Master.playerdeta.NowSelectCharactor == "Oni")
            {
                this.characterName = "Oni";
                this.characterSpeech = HomeScene_Deta.oniSpeechText;
                this.characterImage = characterImages[2];
                return;
            }
            if (Master.playerdeta.NowSelectCharactor == "PolterGeist")
            {
                this.characterName = "polterGeist";
                this.characterSpeech = HomeScene_Deta.poltergeistSpeechText;
                this.characterImage = characterImages[3];
                return;
            }
            if (Master.playerdeta.NowSelectCharactor == "Demon")
            {
                this.characterName = "Demon";
                this.characterSpeech = HomeScene_Deta.demonSpeechText;
                this.characterImage = characterImages[4];
                return;
            }
        }

        private void DrawMessageText()
        {
            messageWindow.transform.GetChild(1).GetComponent<Text>().text = this.characterName;
            messageWindow.transform.GetChild(2).GetComponent<Text>().text = this.characterSpeech;
        }

        private void DrawCharacterImage()
        {
            this.gameObject.GetComponent<Image>().sprite = characterImage;
        }

        private IEnumerator ShowMessageWindow()
        {
            messageWindow.SetActive(true);
            yield return new WaitForSeconds(3.0f);
            messageWindow.SetActive(false);
            yield break;
        }

        private void TestUI(int characterNum)
        {
            switch (characterNum)
            {
                case 0:
                    messageWindow.transform.GetChild(1).GetComponent<Text>().text = "Ghost";
                    messageWindow.transform.GetChild(2).GetComponent<Text>().text = "A";
                    this.gameObject.GetComponent<Image>().sprite = characterImages[0];
                    break;
                case 1:
                    messageWindow.transform.GetChild(1).GetComponent<Text>().text = "Zasikiwarasi";
                    messageWindow.transform.GetChild(2).GetComponent<Text>().text = "B";
                    this.gameObject.GetComponent<Image>().sprite = characterImages[1];
                    break;
                case 2:
                    messageWindow.transform.GetChild(1).GetComponent<Text>().text = "Oni";
                    messageWindow.transform.GetChild(2).GetComponent<Text>().text = "C";
                    this.gameObject.GetComponent<Image>().sprite = characterImages[2];
                    break;
                case 3:
                    messageWindow.transform.GetChild(1).GetComponent<Text>().text = "Poltergeist";
                    messageWindow.transform.GetChild(2).GetComponent<Text>().text = "D";
                    this.gameObject.GetComponent<Image>().sprite = characterImages[3];
                    break;
                case 4:
                    messageWindow.transform.GetChild(1).GetComponent<Text>().text = "Demon";
                    messageWindow.transform.GetChild(2).GetComponent<Text>().text = "E";
                    this.gameObject.GetComponent<Image>().sprite = characterImages[4];
                    break;
            }
        }
    }
}