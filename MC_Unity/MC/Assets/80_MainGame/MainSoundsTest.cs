using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSoundsTest : MonoBehaviour
{
    GameObject sm;
    [SerializeField]
    GameObject tti;
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("SoundManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            sm.SendMessage("PlaySeByName", "あんたが私を誘ったんでしょ");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            sm.SendMessage("PlayBgmByName", "StageSelect");
        }
        if (TakesantestInput.Touchbegan)
        {

        }
    }
}
