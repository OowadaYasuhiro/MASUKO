using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takesantestmaster : TakesanTestSingletonMonoBehaviour<Takesantestmaster>
{
    protected override bool dontDestroyOnLoad { get { return true; } }

    [SerializeField] public static float audiovolume { get; set; }

    [SerializeField] public static int gamedeta;
    [SerializeField] public static string playername { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        #if UNITY_EDITOR
        DebugStart();
        #endif
    }

#if UNITY_EDITOR
    void DebugStart()
    {

    }
#endif

    // Update is called once per frame
    void Update()
    {
        #if UNITY_EDITOR
        DebugUpdate();
        #endif
    }

#if UNITY_EDITOR
    void DebugUpdate()
    {

    }
#endif

    public void detaSave()
    {
        PlayerPrefs.SetInt("TestDeta",gamedeta);
        PlayerPrefs.Save();
    }
}
