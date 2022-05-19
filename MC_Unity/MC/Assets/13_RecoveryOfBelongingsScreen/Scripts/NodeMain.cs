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
        switch (OrganizationScreen_Deta.armorNum)
        {
            case 0:
                Master.formationdeta.SetCharactor1Artifact(OrganizationScreen_Deta.armorNum, ArmorNodeGeneretor.GetCrownArtifact(this.nodeIndex));
                ArmorNodeGeneretor.character1SelectedCrownNum = this.nodeIndex;
                break;
            case 1:
                Master.formationdeta.SetCharactor1Artifact(OrganizationScreen_Deta.armorNum, ArmorNodeGeneretor.GetBangleArtifact(this.nodeIndex));
                ArmorNodeGeneretor.character1SelectedBangleNum = this.nodeIndex;
                break;
            case 2:
                Master.formationdeta.SetCharactor1Artifact(OrganizationScreen_Deta.armorNum, ArmorNodeGeneretor.GetRingArtifact(this.nodeIndex));
                ArmorNodeGeneretor.character1SelectedRingNum = this.nodeIndex;
                break;
            case 3:
                Master.formationdeta.SetCharactor2Artifact(OrganizationScreen_Deta.armorNum -3, ArmorNodeGeneretor.GetCrownArtifact(this.nodeIndex));
                ArmorNodeGeneretor.character2SelectedCrownNum = this.nodeIndex;
                break;
            case 4:
                Master.formationdeta.SetCharactor2Artifact(OrganizationScreen_Deta.armorNum -3, ArmorNodeGeneretor.GetBangleArtifact(this.nodeIndex));
                ArmorNodeGeneretor.character2SelectedBangleNum = this.nodeIndex;
                break;
            case 5:
                Master.formationdeta.SetCharactor2Artifact(OrganizationScreen_Deta.armorNum -3 , ArmorNodeGeneretor.GetRingArtifact(this.nodeIndex));
                ArmorNodeGeneretor.character2SelectedRingNum = this.nodeIndex;
                break;
            default:
                Debug.LogError("Illegal Value");
                break;
        }
        SceneManager.LoadScene("OrganizationScreenScene");
    }
}
