using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//一度生成されるとどこにでも存在し破壊されることがなく複製される事も無いためシーンの切り替えやリロードの影響を受けません
public class Master : SingletonMonoBehaviour<Master>
{
    protected override bool dontDestroyOnLoad { get { return true; } }

    public static PlayerDeta playerdeta = new PlayerDeta();
    

    private new void Awake()
    {
        Debug.Log("");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
