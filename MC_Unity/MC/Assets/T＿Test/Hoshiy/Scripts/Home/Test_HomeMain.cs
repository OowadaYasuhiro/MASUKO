using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//必要なもの
using UnityEngine.UI;

public class Test_HomeMain : MonoBehaviour
{
    /// <summary>
    /// ホーム画面のUIにデータを反映する
    /// </summary>

    //対象UIの取得
    [SerializeField]
    private GameObject playerLevel;
    [SerializeField]
    private GameObject playerName;
    [SerializeField]
    private GameObject playerGauge;
    [SerializeField]
    private GameObject gatyaText;
    [SerializeField]
    private GameObject expText;
    [SerializeField]
    private GameObject moneyText;

    void Start()
    {
        DrawHomeUI();
    }

    //データを取得してテキストに反映する
    private void DrawHomeUI()
    {
        playerLevel.GetComponent<Text>().text = Hy_Test_Data.playerLevel.ToString();
        playerName.GetComponent<Text>().text = Hy_Test_Data.playerName;
        playerGauge.GetComponent<Image>().fillAmount = Hy_Test_Data.playerGauge;
        gatyaText.GetComponent<Text>().text = Hy_Test_Data.gatyaAmount.ToString();
        expText.GetComponent<Text>().text = Hy_Test_Data.expAmount.ToString();
        moneyText.GetComponent<Text>().text = Hy_Test_Data.moneyAmount.ToString();
    }
}
