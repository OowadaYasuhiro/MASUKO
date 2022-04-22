using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//必要なもの
using UnityEngine.SceneManagement;

public class Test_HomeButton : MonoBehaviour
{
    /// <summary>
    /// ホーム画面のButtonのOnClick用のメソッド群
    /// 対応するシーンをロードする
    /// </summary>

    //ステージ選択シーンへ
    public void OnClickFight()
    {
        Debug.Log("fight");
    }

    //キャラクター編成シーンへ
    public void OnClickFormation()
    {
        SceneManager.LoadScene("Hoshiy_TestFormationScene");
    }

    //キャラクター強化シーンへ
    public void OnClickEnhance()
    {
        Debug.Log("enhance");
    }

    //ガチャシーンへ
    public void OnClickGatya()
    {
        Debug.Log("gatya");
    }

    //ショップシーンへ
    public void OnClickShop()
    {
        Debug.Log("shop");
    }

    //任務確認シーンへ
    public void OnClickMission()
    {
        SceneManager.LoadScene("Hoshiy_TestMissonScene");
    }

    //設定確認シーンへ
    public void OnClickOption()
    {
        Debug.Log("option");
    }
}
