using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagatamaDetailMain : MonoBehaviour
{
    /// <summary>
    /// プレイヤーが現在所持している禍魂の量を取得する
    /// </summary>

    //デバッグ用
    //private PlayerDeta p = new PlayerDeta("a");

    void Start()
    {
        //デバッグ用
        //this.gameObject.GetComponentInChildren<Text>().text = p.MagaTamashi.ToString();

        this.gameObject.GetComponentInChildren<Text>().text = Master.playerdeta.MagaTamashi.ToString();
    }
}
