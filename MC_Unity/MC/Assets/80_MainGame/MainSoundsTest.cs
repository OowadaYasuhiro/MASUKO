using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSoundsTest : MonoBehaviour
{
    GameObject sm;
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
            sm.SendMessage("PlaySeByName", "ぴえきん_出撃時");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            sm.SendMessage("PlayBgmByName", "StageSelect");
        }
    }
}
