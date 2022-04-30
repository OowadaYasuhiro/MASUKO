using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionMain : MonoBehaviour
{
    /// <summary>
    /// ミッション画面の初期状態を設定する
    /// </summary>

    private GameObject obj;

    private void Start()
    {
        //初期状態はデイリーミッションを表示するように設定
        obj = GameObject.Find("Daily-Button");
        obj.GetComponent<MissionDaily>().OnClickDailyButton();
    }
}
