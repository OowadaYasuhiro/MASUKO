using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takesantestmaster : TakesanTestSingletonMonoBehaviour<Takesantestmaster>
{
    protected override bool dontDestroyOnLoad { get { return true; } }

    [SerializeField] public static float audiovolume { get; set; }

    [SerializeField] public static int gamedeta;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void detaSave()
    {
        PlayerPrefs.SetInt("TestDeta",gamedeta);
        PlayerPrefs.Save();
    }
}
