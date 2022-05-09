using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NodeMain : MonoBehaviour
{
    /// <summary>
    /// 遺物を表示するオブジェクトの処理
    /// </summary>

    //識別番号
    private int nodeIndex;

    public void SetNodeIndex(int index)
    {
        this.nodeIndex = index;
    }
    public int GetNodeIndex()
    {
        return this.nodeIndex;
    }

    //todo 遺物が既に選択されているかの処理
    //OnClick用メソッド
    public void OnClickNode()
    {
        //左のキャラクターの遺物
        if (OrganizationScreen_Deta.armorNum == 0 || OrganizationScreen_Deta.armorNum == 1 || OrganizationScreen_Deta.armorNum == 2)
        {
            Master.formationdeta.SetCharactor1Artifact(OrganizationScreen_Deta.armorNum, ArmorNodeGeneretor.GetArtifact(this.nodeIndex));
        }
        else
        {

        }
        SceneManager.LoadScene("OrganizationScreenScene");
    }
}
