using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FormationCharacterButtons : MonoBehaviour
{
<<<<<<< HEAD
    /// <summary>
    /// キャラクターウィンドウにあるボタンの処理
    /// </summary>

    private GameObject director;

    private void Start()
    {
        director = GameObject.Find("UIDirector");
    }

    //キャラクターイメージのOnClick用メソッド
    public void OnClickCharacter(bool isLeft)
    {
        //左のイメージをクリックしたか保存
        OrganizationScreen_Deta.isLeftCharacter = isLeft;

        //キャラ選択ウィンドウの表示
        director.GetComponent<FormationMain>().ShowSelectWindow();
    }

    //遺物のOnClick用メソッド
    public void OnClickArmor(int posNum)
    {
        //遺物がないなら遺物選択画面には飛ばさない
        /*if (Master.playerdeta.artifacts.Length == 0)
        {
            director.GetComponent<FormationMain>().ShowAlertWindow();
            return;
        }*/

        if (Master.formationdeta.GetCharactor2() == null)
        {
            if (posNum == 3 || posNum == 4 || posNum == 5)
            {
                Debug.Log("not set charactor");
                return;
            }
        }

        //どのスロットをクリックしたかの保存
=======
    public void OnClickCharacter(bool isLeft)
    {
        GameObject director = GameObject.Find("UIDirector");
        OrganizationScreen_Deta.isLeftCharacter = isLeft;
        director.GetComponent<FormationMain>().ShowSelectWindow();
    }

    public void OnClickArmor(int posNum)
    {
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
        OrganizationScreen_Deta.armorNum = posNum;
        SceneManager.LoadScene("RecoveryOfBelongingsScreenScene");
    }
}
