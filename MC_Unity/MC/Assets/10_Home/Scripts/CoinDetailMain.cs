using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDetailMain : MonoBehaviour
{
    /// <summary>
    /// プレイヤーが現在所持しているコインの量を取得する
    /// </summary>

    //デバッグ用
    //private PlayerDeta p = new PlayerDeta("a");

    void Start()
    {
        //デバッグ用
        //this.gameObject.GetComponentInChildren<Text>().text = p.Coin.ToString();

        this.gameObject.GetComponentInChildren<Text>().text = Master.playerdeta.Coin.ToString();
    }
}
