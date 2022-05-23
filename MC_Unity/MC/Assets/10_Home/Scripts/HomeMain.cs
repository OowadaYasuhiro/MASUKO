using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace HomeScene
{
    public class HomeMain : MonoBehaviour
    {
        /// <summary>
        /// プレイヤーのデータを取得し反映する
        /// </summary>

        [SerializeField]
        private GameObject playerLevelText; //プレイヤーレベル
        [SerializeField]
        private GameObject playerNameText; //プレイヤー名
        [SerializeField]
        private GameObject playerExpGauge; //プレイヤーゲージ
        [SerializeField]
        private GameObject messageWindow;
        [SerializeField]
        private Sprite[] characterImages;

        private void Start()
        {
            InitializePlayerData();

            messageWindow.SetActive(false);
        }

        private void InitializePlayerData()
        {
            //データを取得
            playerLevelText.GetComponent<Text>().text = Master.playerdeta.PlayerLevel.ToString();
            playerNameText.GetComponent<Text>().text = Master.playerdeta.PlayerName;
            playerExpGauge.GetComponent<Image>().fillAmount = Master.playerdeta.PlayerExperience;
        }

        private void ReferenceCharacterData()
        {
            //現在編成しているキャラクターの名前をセット
            messageWindow.transform.GetChild(1).GetComponent<Text>().text = Master.playerdeta.NowSelectCharactor;

            //todo: キャラクターデータの設定(セリフとスプライト)
            //編成しているキャラクターに応じてセリフと画像をセット
            switch (Master.playerdeta.NowSelectCharactor)
            {
                case "Ghost": //幽霊
                    this.gameObject.GetComponent<Image>().sprite = characterImages[0];
                    messageWindow.transform.GetChild(2).GetComponent<Text>().text = "Ghost";
                    break;
                case "Zasikiwarasi": //座敷童
                    this.gameObject.GetComponent<Image>().sprite = characterImages[1];
                    messageWindow.transform.GetChild(2).GetComponent<Text>().text = "Zasikiwarasi";
                    break;
                case "Oni": //鬼
                    this.gameObject.GetComponent<Image>().sprite = characterImages[2];
                    messageWindow.transform.GetChild(2).GetComponent<Text>().text = "Zasikiwarasi";
                    break;
                case "Demon": //デーモン
                    this.gameObject.GetComponent<Image>().sprite = characterImages[3];
                    messageWindow.transform.GetChild(2).GetComponent<Text>().text = "Zasikiwarasi";
                    break;
                case "Poltergeist": //ポルターガイスト
                    this.gameObject.GetComponent<Image>().sprite = characterImages[4];
                    messageWindow.transform.GetChild(2).GetComponent<Text>().text = "Zasikiwarasi";
                    break;
                default:
                    Debug.LogError("error");
                    break;
            }
        }

        private IEnumerator ShowMessageWindow()
        {
            messageWindow.SetActive(true);
            yield return new WaitForSeconds(3.0f);
            messageWindow.SetActive(false);
            yield break;
        }

        public void ShowMessage()
        {
            StartCoroutine("ShowMessageWindow");
        }
    }
}
