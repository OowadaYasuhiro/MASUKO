using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormationSelectWindowButton : MonoBehaviour
{
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
    /// <summary>
    /// キャラクター選択ウィンドウの処理
    /// </summary>

    private GameObject director;

    private void Start()
    {
        director = GameObject.Find("UIDirector");
    }

    //キャラクター選択ボタンのOnClick用メソッド
<<<<<<< HEAD
    public void OnClickSelectCharacter(int posNum)
    {
        //左のキャラクターを選択していたとき
        if (OrganizationScreen_Deta.isLeftCharacter)
        {
            //既に右のキャラクターに選ばれていたならスワッピング処理
            if (posNum == OrganizationScreen_Deta.rightCharacterNum)
            {
                OrganizationScreen_Deta.rightCharacterNum = OrganizationScreen_Deta.leftCharacterNum;
                OrganizationScreen_Deta.isLeftCharacter = false;
                director.GetComponent<FormationMain>().DrawCharacterUITextsAndImage();
                OrganizationScreen_Deta.isLeftCharacter = true;
                OrganizationScreen_Deta.leftCharacterNum = posNum;
            }
            //右のキャラクターが居てかつ今選ばれているキャラクターを選んだら、右のキャラクターを左に移動し、右のキャラクターを空にする
            else if (posNum == OrganizationScreen_Deta.leftCharacterNum && OrganizationScreen_Deta.rightCharacterNum != -1)
            {
                OrganizationScreen_Deta.leftCharacterNum = OrganizationScreen_Deta.rightCharacterNum;
                OrganizationScreen_Deta.rightCharacterNum = -1;
                OrganizationScreen_Deta.isLeftCharacter = false;
                director.GetComponent<FormationMain>().DrawCharacterUITextsAndImage();
                OrganizationScreen_Deta.isLeftCharacter = true;
            }
            else
            {
                OrganizationScreen_Deta.leftCharacterNum = posNum;
            }
        }
        //右のキャラクターを選択していたとき
        else
        {
            //スワッピング処理
            if (posNum == OrganizationScreen_Deta.leftCharacterNum)
            {
                OrganizationScreen_Deta.leftCharacterNum = OrganizationScreen_Deta.rightCharacterNum;
                OrganizationScreen_Deta.isLeftCharacter = true;
                director.GetComponent<FormationMain>().DrawCharacterUITextsAndImage();
                OrganizationScreen_Deta.isLeftCharacter = false;
                OrganizationScreen_Deta.rightCharacterNum = posNum;
            }
            //今のセットされているキャラクターを選択したら、空にする
            else if (posNum == OrganizationScreen_Deta.rightCharacterNum)
            {
                OrganizationScreen_Deta.rightCharacterNum = -1;
            }
            else
            {
                OrganizationScreen_Deta.rightCharacterNum = posNum;
            }
        }

        //ウィンドウを閉じる
        director.GetComponent<FormationMain>().EraseSelectWindow();
=======
    public void OnClickSelectCharacter(int posNum)
    {
        OrganizationScreen_Deta.selectCharacterNum = posNum;
        GameObject.Find("UIDirector").GetComponent<FormationMain>().EraseSelectWindow();
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
=======
    public void OnClickSelectCharacter(int posNum)
    {
        //左のキャラクターを選択していたとき
        if (OrganizationScreen_Deta.isLeftCharacter)
        {
            //既に右のキャラクターに選ばれていたならスワッピング処理
            if (posNum == OrganizationScreen_Deta.rightCharacterNum)
            {
                OrganizationScreen_Deta.rightCharacterNum = OrganizationScreen_Deta.leftCharacterNum;
                OrganizationScreen_Deta.isLeftCharacter = false;
                director.GetComponent<FormationMain>().DrawCharacterUITextsAndImage();
                OrganizationScreen_Deta.isLeftCharacter = true;
                OrganizationScreen_Deta.leftCharacterNum = posNum;
            }
            //右のキャラクターが居てかつ今選ばれているキャラクターを選んだら、右のキャラクターを左に移動し、右のキャラクターを空にする
            else if (posNum == OrganizationScreen_Deta.leftCharacterNum && OrganizationScreen_Deta.rightCharacterNum != -1)
            {
                OrganizationScreen_Deta.leftCharacterNum = OrganizationScreen_Deta.rightCharacterNum;
                OrganizationScreen_Deta.rightCharacterNum = -1;
                OrganizationScreen_Deta.isLeftCharacter = false;
                director.GetComponent<FormationMain>().DrawCharacterUITextsAndImage();
                OrganizationScreen_Deta.isLeftCharacter = true;
            }
            else
            {
                OrganizationScreen_Deta.leftCharacterNum = posNum;
            }
        }
        //右のキャラクターを選択していたとき
        else
        {
            //スワッピング処理
            if (posNum == OrganizationScreen_Deta.leftCharacterNum)
            {
                OrganizationScreen_Deta.leftCharacterNum = OrganizationScreen_Deta.rightCharacterNum;
                OrganizationScreen_Deta.isLeftCharacter = true;
                director.GetComponent<FormationMain>().DrawCharacterUITextsAndImage();
                OrganizationScreen_Deta.isLeftCharacter = false;
                OrganizationScreen_Deta.rightCharacterNum = posNum;
            }
            //今のセットされているキャラクターを選択したら、空にする
            else if (posNum == OrganizationScreen_Deta.rightCharacterNum)
            {
                OrganizationScreen_Deta.rightCharacterNum = -1;
            }
            else
            {
                OrganizationScreen_Deta.rightCharacterNum = posNum;
            }
        }

        //ウィンドウを閉じる
        director.GetComponent<FormationMain>().EraseSelectWindow();
>>>>>>> 24bfaa1b23e9c3e385b48701e5a3e1278d8bee4a
    }
}
