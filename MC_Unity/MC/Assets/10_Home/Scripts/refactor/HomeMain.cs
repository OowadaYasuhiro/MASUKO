using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeMain : MonoBehaviour
{
    [SerializeField]
    private GameObject soundManager;

    void Start()
    {
        soundManager.GetComponent<SoundManager>().Initialize();
        soundManager.GetComponent<SoundManager>().PlayBgmByName("HomeBgm");
    }
}
