using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

//一度生成されるとどこにでも存在し破壊されることがなく複製される事も無いためシーンの切り替えやリロードの影響を受けません
public class Master : SingletonMonoBehaviour<Master>
{
    protected override bool dontDestroyOnLoad { get { return true; } }

    public static PlayerDeta playerdeta = new PlayerDeta();
    public static FormationDeta formationdeta = new FormationDeta();
    public static SaveManager saveManager;



    private new void Awake()
    {
        saveManager = gameObject.AddComponent<SaveManager>();
        saveManager.DetaLoad();
        SceneManager.sceneUnloaded += OnSceneUnloaded;
        GameObject.Find("SoundManager").GetComponent<SoundManager>().Initialize();
    }

    private void OnSceneUnloaded(Scene current)
    {
        saveManager.DetaSave();
    }

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
