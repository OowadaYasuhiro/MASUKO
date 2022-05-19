using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    void Start()
    {
        //データを取得
        playerLevelText.GetComponent<Text>().text = Master.playerdeta.PlayerLevel.ToString();
        playerNameText.GetComponent<Text>().text = Master.playerdeta.PlayerName;
        playerExpGauge.GetComponent<Image>().fillAmount = Master.playerdeta.PlayerExperience;
    }
}
