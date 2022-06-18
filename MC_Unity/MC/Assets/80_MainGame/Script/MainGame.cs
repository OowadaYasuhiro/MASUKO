using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;
using UnityEngine.SceneManagement;
using static System.Convert;
using System;

public partial class MainGame : MonoBehaviour
{
    //ゲームステート
    [HideInInspector]
    public GameState gamestate;

    //マスターオブジェクト
    GameObject master;

    //ステージ
    string stage;

    //ステージUI
    MainGame_StageUI mainGame_StageUI;

    //難易度
    string difficulty;

    //ステージデータ
    internal MainGame_StageDeta mainGame_StageDeta;

    //現在のウェーブ
    int waveNumber;

    //ゲーム内時間軸
    internal float gameSpeed { get; private set;}
    float timeLine;

    //勝敗
    bool playerWin;

    //**イベント**
    //一時停止
    bool pause;
    //スロウモード
    bool slowMode;
    //キャラクター１を選択
    bool charactor1;
    //キャラクター１スキル１
    bool charactor1skil1;
    //キャラクター１スキル２
    bool charactor1skil2;
    //キャラクター１スキル３
    bool charactor1skil3;
    //キャラクター１撤退
    bool charactor1goback;
    //キャラクター２を選択
    bool charactor2;
    //キャラクター２スキル１
    bool charactor2skil1;
    //キャラクター２スキル２
    bool charactor2skil2;
    //キャラクター２スキル３
    bool charactor2skil3;
    //キャラクター２撤退
    bool charactor2goback;
    //アイテム１
    bool item1;
    //アイテム２
    bool item2;

    //敵
    Enemy[] enemies;

    //プレイヤー
    Player [] players;

    //召喚
    internal SummonsCharactor[] summonsCharactor = new SummonsCharactor[8];

    //召喚
    internal SummonsObject[] summonsobject = new SummonsObject[8];

    //初期化
    void Start()
    {
        gamestate = GameState.BeforeStart;
        gameSpeed = 1;
        master = GameObject.Find("MasterObject");
        StageSelect_Deta.selectStageNumber = Constant.main_ep1_1;
        stage = StageSelect_Deta.selectStageNumber;
        
        difficulty = StageSelect_Deta.selectDifficulty;
        mainGame_StageDeta = new MainGame_StageDeta(stage);
        mainGame_StageUI = GetComponent<MainGame_StageUI>();
        mainGame_StageUI.SendMessage("SetBackGround", int.Parse(stage.Substring(1,2)));
        mainGame_StageUI.SendMessage("SetObstacle", int.Parse(stage.Substring(1, 2)));
        waveNumber = 1;
        playerWin = false;
        //GeneratEnemy();
        GeneratPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        switch (gamestate)
        {
            case GameState.BeforeStart:

                break;
            case GameState.PreparationPhase:

                break;
            case GameState.GameRun:

                //WaveClearCheck();
                break;
            case GameState.Wait:

                break;
            case GameState.End:

                break;
            case GameState.Result:

                break;
        }
        timeLine = Time.deltaTime * gameSpeed;
    }

    //ウェーブを次へ
    void ChengeWave()
    {
        waveNumber += 1;
        //GeneratEnemy();
    }

    //スロウモード
    void SlowCheck()
    {
        if (slowMode) gameSpeed = 0.25f;
        else gameSpeed = 1f;
    }

    /*
    //ウェーブが終わったか判定
    void WaveClearCheck()
    {
        bool allenemydead = false;
        foreach (var i in enemies)
        {
            allenemydead = true;
            if(i.CheckHp > 0)
            {
                allenemydead = false;
                break;
            }
        }
        if (allenemydead == true)
        {
            ChengeWave();
        }
    }
    */

    //セーブデータの情報からプレイヤーキャラクターを生成
    void GeneratPlayer()
    {
        if (Master.formationdeta.GetCharactor1() != null)
        {
            if (Master.formationdeta.GetCharactor2() != null)
            {
                players = new Player[] { new Player(this, 1),new Player(this, 2) };
            }
            else
            {
                players = new Player[] { new Player(this, 1) };
            }
        }
        else
        {
            if (Master.formationdeta.GetCharactor2() != null)
            {
                players = new Player[] { new Player(this, 2) };
            }
            else
            {
                //ありえない
            }
        }
    }

    //メインゲーム終了
    void Exit()
    {
        Load_Deta.Nextscenename = "StageSelectScene";
        SceneManager.LoadScene("Yanai_TestScene");
    }

}
