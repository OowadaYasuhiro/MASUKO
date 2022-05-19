using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//必要なもの
using UnityEngine.UI;

public class Test_HomeSceneCharacter : MonoBehaviour
{
    /// <summary>
    /// ホーム画面のキャラクターイメージオブジェクトの定義
    /// </summary>

    //メッセージウィンドウの取得
    [SerializeField]
    private GameObject messageWindow;

    //編成画面で何のキャラクターがセットされているか格納する
    private int characterNum;

    private void Start()
    {
        //データからセットされているキャラクターの取得
        characterNum = Hy_Test_Data.imageNum;

        //メッセージウィンドウは隠しておく
        messageWindow.SetActive(false);

        //対応するキャラクターをセットする
        DrawCharacterImage();
    }

    //todo:
    //実際にはキャラクターの画像をセットする
    //ハードコーディング
    private void DrawCharacterImage()
    {
        switch (characterNum)
        {
            case 0:
                this.gameObject.GetComponent<Image>().color = Color.red;
                break;
            case 1:
                this.gameObject.GetComponent<Image>().color = Color.blue;
                break;
            case 2:
                this.gameObject.GetComponent<Image>().color = Color.green;
                break;
            case 3:
                this.gameObject.GetComponent<Image>().color = Color.yellow;
                break;
            case 4:
                this.gameObject.GetComponent<Image>().color = Color.magenta;
                break;
            default:
                Debug.LogError("characterNum is Illegal value");
                break;
        }
    }

    //メッセージウィンドウ表示コルーチンの呼び出し
    private void MessageCoroutine()
    {
        StartCoroutine("ShowMessageWindow");
    }

    //メッセージウィンドウの処理
    private IEnumerator ShowMessageWindow()
    {
        //対象オブジェクトの表示
        messageWindow.SetActive(true);
        //対応するキャラクター名とそのセリフをテキストにセットする
        //ハードコーディング
        switch (characterNum)
        {
            case 0:
                messageWindow.transform.GetChild(1).GetComponent<Text>().text = "character1";
                messageWindow.transform.GetChild(2).GetComponent<Text>().text = "Red";
                break;
            case 1:
                messageWindow.transform.GetChild(1).GetComponent<Text>().text = "character2";
                messageWindow.transform.GetChild(2).GetComponent<Text>().text = "Blue";
                break;
            case 2:
                messageWindow.transform.GetChild(1).GetComponent<Text>().text = "character3";
                messageWindow.transform.GetChild(2).GetComponent<Text>().text = "Green";
                break;
            case 3:
                messageWindow.transform.GetChild(1).GetComponent<Text>().text = "character4";
                messageWindow.transform.GetChild(2).GetComponent<Text>().text = "Yellow";
                break;
            case 4:
                messageWindow.transform.GetChild(1).GetComponent<Text>().text = "character5";
                messageWindow.transform.GetChild(2).GetComponent<Text>().text = "Purple";
                break;
            default:
                Debug.LogError("characterNum is Illegal value");
                break;
        }
        //少しの間メッセージウィンドウを表示する
        yield return new WaitForSeconds(3.0f);
        //メッセージウィンドウを非表示にする
        messageWindow.SetActive(false);
        //コルーチン終了
        yield break;
    }

    //キャラクターイメージのOnClick用のメソッド
    public void OnClickCharacter()
    {
        MessageCoroutine();
    }
}
