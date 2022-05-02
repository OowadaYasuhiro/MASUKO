using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButtonEvent : MonoBehaviour
{
    /// <summary>
    /// ホーム画面のボタンのOnClick用のメソッド群
    /// </summary>

    //todo: 対応するシーンに飛ばすように設定

    //戦闘ボタン
    public void OnClickFightButton()
    {
        Debug.Log("Fight");
    }

    //編成ボタン
    public void OnClickFormationButton()
    {
        Debug.Log("Formation");
    }

    //強化ボタン
    public void OnClickEnhanceButton()
    {
        Debug.Log("Enhance");
    }

    //ガチャボタン
    public void OnClickGatyaButton()
    {
        Debug.Log("Gatya");
    }

    //ショップボタン
    public void OnClickShopButton()
    {
        Debug.Log("Shop");
    }

    //任務ボタン
    public void OnClickMissionButton()
    {
        Debug.Log("Mission");
    }

    //設定ボタン
    public void OnClickOptionButton()
    {
        Debug.Log("Option");
    }
}
