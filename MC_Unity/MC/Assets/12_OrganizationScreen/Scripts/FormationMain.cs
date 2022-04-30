using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormationMain : MonoBehaviour
{
    [SerializeField]
    private GameObject characterWindowLeft;
    [SerializeField]
    private GameObject characterWindowRight;
    [SerializeField]
    private GameObject selectWindow;

    void Start()
    {
        characterWindowLeft.SetActive(true);
        characterWindowRight.SetActive(true);
        selectWindow.SetActive(false);
    }
}
