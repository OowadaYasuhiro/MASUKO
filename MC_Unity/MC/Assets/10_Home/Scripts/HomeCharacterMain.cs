using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeCharacterMain : MonoBehaviour
{
    /// <summary>
    /// ホームのキャラクターに関するスクリプト
    /// </summary>

    [SerializeField]
    private GameObject messageWindow; //メッセージウインドウ

    [SerializeField]
    private Sprite[] characterImages; //キャラクターの画像の配列

    void Start()
    {
        //キャラクターデータの取得
        ReferenceCharacterData();

        //メッセージウインドウは非表示にする
        messageWindow.SetActive(false);
    }

    //OnClick用のメソッド
    public void OnClickCharacter()
    {
        StartCoroutine("ShowMessageWindow");
    }

    //キャラクターをクリックするとメッセージウインドウを表示
    private IEnumerator ShowMessageWindow()
    {
        messageWindow.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        messageWindow.SetActive(false);
        yield break;
    }

    //データ取得
    private void ReferenceCharacterData()
    {
        //現在編成しているキャラクターの名前をセット
        messageWindow.transform.GetChild(1).GetComponent<Text>().text = Master.playerdeta.NowSelectCharactor;

        //todo: キャラクターデータの設定(セリフとスプライト)
        //編成しているキャラクターに応じてセリフと画像をセット
        switch (Master.playerdeta.NowSelectCharactor)
        {
            case "Ghost":
                this.gameObject.GetComponent<Image>().sprite = characterImages[0];
                messageWindow.transform.GetChild(2).GetComponent<Text>().text = "Ghost";
                break;
            default:
                Debug.LogError("error");
                break;
        }
    }
}
