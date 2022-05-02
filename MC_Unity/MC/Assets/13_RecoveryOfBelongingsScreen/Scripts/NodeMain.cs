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
        SceneManager.LoadScene("OrganizationScreenScene");
    }
}
