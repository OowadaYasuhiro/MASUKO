using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZanryuDetailMain : MonoBehaviour
{
    /// <summary>
    /// プレイヤーが現在所持している残留思念の量を取得する
    /// </summary>

    //デバッグ用
    //private PlayerDeta p = new PlayerDeta("a");

    void Start()
    {
        //デバッグ用
        //this.gameObject.GetComponentInChildren<Text>().text = p.Zanryu_Sinen.ToString();

        this.gameObject.GetComponentInChildren<Text>().text = Master.playerdeta.Zanryu_Sinen.ToString();
    }
}
