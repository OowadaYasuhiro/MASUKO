using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionRewardMain : MonoBehaviour
{
    /// <summary>
    /// 報酬確認ウィンドウのOnClick用のメソッド
    /// </summary>

    //確認ボタン
    public void OnClickCheckButton()
    {
        this.gameObject.SetActive(false); //ウィンドウを閉じる
    }
}
