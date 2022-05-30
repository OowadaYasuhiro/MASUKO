using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Nextscenenumber
{
    Kyouka,
    Hensei,
}
public class Load_Deta 
{
    public static Nextscenenumber nextscenenumber;
}

/*使い方
①シーン変更
//次のシーンを文字で指定
    Load_Deta.nextscenenumber = Nextscenenumber.Kyouka;
//ローディング画面に飛ばす
    SceneManager.LoadScene("Yanai_TestScene");
②上に任意の列挙型を追加
例　強化画面→Kyouka 編成画面→Hensei
③load画面で対応させる
    case Nextscenenumber.(任意の列挙型) :
               SceneManager.LoadScene("任意のシーン");
               break;
T_Test>Yanai>load>C>loadにスクリプトが入ってます。
*/


