using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NodeMain : MonoBehaviour
{
    private int nodeIndex;

    public void SetNodeIndex(int index)
    {
        this.nodeIndex = index;
    }
    public int GetNodeIndex()
    {
        return this.nodeIndex;
    }

    public void OnClickNode()
    {
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
