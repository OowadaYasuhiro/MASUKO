using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FormationCharacterButtons : MonoBehaviour
{
    /// <summary>
    /// キャラクターウィンドウにあるボタンの処理
    /// </summary>

    //キャラクターイメージのOnClick用メソッド
    public void OnClickCharacter(bool isLeft)
    {
        //左のイメージをクリックしたか保存
        OrganizationScreen_Deta.isLeftCharacter = isLeft;

        //キャラ選択ウィンドウの表示
        GameObject director = GameObject.Find("UIDirector");
        director.GetComponent<FormationMain>().ShowSelectWindow();
    }

    //遺物のOnClick用メソッド
    public void OnClickArmor(int posNum)
    {
        //todo 遺物を持っていないことを示すuiの作成
        //遺物がないなら遺物選択画面には飛ばさない
        /*if (Master.playerdeta.artifacts.Length == 0)
        {
            Debug.Log("遺物を持ってない");
            return;
        }*/

        //どのスロットをクリックしたかの保存
        OrganizationScreen_Deta.armorNum = posNum;
        SceneManager.LoadScene("RecoveryOfBelongingsScreenScene");
    }
}
