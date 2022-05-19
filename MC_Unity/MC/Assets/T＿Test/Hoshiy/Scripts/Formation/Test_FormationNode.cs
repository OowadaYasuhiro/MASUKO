using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_FormationNode : MonoBehaviour
{
    private GameObject uiDirector;

    private int nodeNum;

    private void Start()
    {
        uiDirector = GameObject.Find("UIDirector");
    }

    public void SetNodeNum(int index)
    {
        this.nodeNum = index;
    }

    public int GetNodeNum()
    {
        return nodeNum;
    }

    public void OnSelectArmorButton()
    {
        uiDirector.GetComponent<Test_FormationButtonEvent>().OnClickSelectArmor(this.nodeNum);
    }
}
