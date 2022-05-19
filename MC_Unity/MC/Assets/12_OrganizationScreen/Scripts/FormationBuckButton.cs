using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FormationBuckButton : MonoBehaviour
{
<<<<<<< HEAD
    /// <summary>
    /// ホームシーンへ戻るボタンの処理
    /// </summary>

    //todo: ホームシーンにつなげる
    //OnClick用メソッド
    public void OnClickBuckButton()
    {
        //現在セットされているキャラクターを保存
        switch (OrganizationScreen_Deta.leftCharacterNum)
        {
            case 0:
                Master.playerdeta.NowSelectCharactor = OrganizationScreen_Deta.CharacterName.ghost.ToString();
                break;
            case 1:
                Master.playerdeta.NowSelectCharactor = OrganizationScreen_Deta.CharacterName.zasikiwarasi.ToString();
                break;
            case 2:
                Master.playerdeta.NowSelectCharactor = OrganizationScreen_Deta.CharacterName.ogre.ToString();
                break;
            case 3:
                Master.playerdeta.NowSelectCharactor = OrganizationScreen_Deta.CharacterName.poltergeist.ToString();
                break;
            case 4:
                Master.playerdeta.NowSelectCharactor = OrganizationScreen_Deta.CharacterName.demon.ToString();
                break;
            default:
                Debug.LogError("Illegal Value");
                break;
        }

        Debug.Log("back");
        //SceneManager.LoadScene("");
=======
    //todo:
    public void OnClickBuckButton()
    {
        Debug.Log("");
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
    }
}
