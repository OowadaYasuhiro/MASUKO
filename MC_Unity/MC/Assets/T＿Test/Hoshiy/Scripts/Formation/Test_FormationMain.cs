using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_FormationMain : MonoBehaviour
{
    [SerializeField]
    private GameObject gatyaDetail;
    [SerializeField]
    private GameObject expDetail;
    [SerializeField]
    private GameObject moneyDetail;

    private int gatyaAmount;
    private int expAmount;
    private int moneyAmount;

    void Start()
    {
        SetItemUIs();
    }

    void Update()
    {
        
    }

    private void ReferenceItemData()
    {
        gatyaAmount = Hy_Test_Data.gatyaAmount;
        expAmount = Hy_Test_Data.expAmount;
        moneyAmount = Hy_Test_Data.moneyAmount;
    }

    private void SetItemUIs()
    {
        ReferenceItemData();
        gatyaDetail.transform.GetChild(2).GetComponent<Text>().text = gatyaAmount.ToString();
        expDetail.transform.GetChild(2).GetComponent<Text>().text = expAmount.ToString();
        moneyDetail.transform.GetChild(2).GetComponent<Text>().text = moneyAmount.ToString();
    }
}
