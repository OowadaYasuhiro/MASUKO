using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Mission_Main : MonoBehaviour
{
    void Start()
    {
        this.gameObject.GetComponent<Test_Misson_ButtonEvents>().OnClickDailyButton();
    }
}
