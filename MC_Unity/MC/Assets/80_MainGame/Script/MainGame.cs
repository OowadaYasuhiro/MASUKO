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

    //影
    ShadowMesh shadowMesh;

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
    internal bool pause;
    //スロウモード
    bool slowMode;
    //キャラクター１を選択
    internal bool charactor1;
    //キャラクター１スキル１
    internal bool charactor1skil1;
    //キャラクター１スキル２
    internal bool charactor1skil2;
    //キャラクター１スキル３
    internal bool charactor1skil3;
    //キャラクター１撤退
    internal bool charactor1goback;
    //キャラクター２を選択
    internal bool charactor2;
    //キャラクター２スキル１
    internal bool charactor2skil1;
    //キャラクター２スキル２
    internal bool charactor2skil2;
    //キャラクター２スキル３
    internal bool charactor2skil3;
    //キャラクター２撤退
    internal bool charactor2goback;
    //アイテム１
    internal bool item1;
    //アイテム２
    internal bool item2;

    //敵
    Enemy[] enemies;

    //プレイヤー
    Player[] players;

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
        shadowMesh = GameObject.Find("ShadowObject").GetComponent<ShadowMesh>();
        shadowMesh.Initialize();
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

                ChangeView();
                WaveClearCheck();
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

    
    //ウェーブが終わったか判定
    void WaveClearCheck()
    {
        bool allenemyalive = false;
        foreach (var i in enemies)
        {
            if(i.alive == true)
            {
                allenemyalive = true;
                break;
            }
        }
        if (allenemyalive == false)
        {
            ChengeWave();
        }
    }
    

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

    //Viewの変更
    void ChangeView()
    {
        //障害物を避けて影を生成
        mainGame_StageDeta.view.viewArray = mainGame_StageDeta.GetMap();

        //キャラクターの視界を確保
        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].GetName() == "")
            {
                goto PlayerViewExit;
            }
            if (players[i].directionRight == true)
            {
                for (int j = 0; j < players[i].viewRange.Length; j++)
                {
                    mainGame_StageDeta.view.viewArray[(int)(players[i].position.x + players[i].viewRange[i].x), (int)(players[i].position.y + players[i].viewRange[i].y)] = true;
                }
            }
            else
            {
                for (int j = 0; j < players[i].viewRange.Length; j++)
                {
                    mainGame_StageDeta.view.viewArray[(int)(players[i].position.x + (players[i].viewRange[i].x * -1)), (int)(players[i].position.y + players[i].viewRange[i].y)] = true;
                }
            }
        }
        PlayerViewExit:

        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemies[i].GetName() == "")
            {
                goto EnemyViewExit;
            }
            if (enemies[i].directionRight == true)
            {
                for (int j = 0; j < enemies[i].viewRange.Length; j++)
                {
                    mainGame_StageDeta.view.viewArray[(int)(enemies[i].position.x + enemies[i].viewRange[i].x), (int)(enemies[i].position.y + enemies[i].viewRange[i].y)] = true;
                }
            }
            else
            {
                for (int j = 0; j < enemies[i].viewRange.Length; j++)
                {
                    mainGame_StageDeta.view.viewArray[(int)(enemies[i].position.x + (enemies[i].viewRange[i].x * -1)), (int)(enemies[i].position.y + enemies[i].viewRange[i].y)] = true;
                }
            }
        }
        EnemyViewExit:

        for (int i = 0; i < summonsCharactor.Length; i++)
        {
            if (summonsCharactor[i].GetName() == "")
            {
                goto SummonCharactorViewExit;
            }
            if (summonsCharactor[i].directionRight == true)
            {
                for (int j = 0; j < summonsCharactor[i].viewRange.Length; j++)
                {
                    mainGame_StageDeta.view.viewArray[(int)(summonsCharactor[i].position.x + summonsCharactor[i].viewRange[i].x), (int)(summonsCharactor[i].position.y + summonsCharactor[i].viewRange[i].y)] = true;
                }
            }
            else
            {
                for (int j = 0; j < summonsCharactor[i].viewRange.Length; j++)
                {
                    mainGame_StageDeta.view.viewArray[(int)(summonsCharactor[i].position.x + (summonsCharactor[i].viewRange[i].x * -1)), (int)(summonsCharactor[i].position.y + summonsCharactor[i].viewRange[i].y)] = true;
                }
            }
        }
        SummonCharactorViewExit:

        for (int i = 0; i < summonsobject.Length; i++)
        {
            if (summonsobject[i].GetName() == "")
            {
                goto SummonObjectExitViewExit;
            }
            if (summonsobject[i].directionRight == true)
            {
                for (int j = 0; j < summonsobject[i].viewRange.Length; j++)
                {
                    mainGame_StageDeta.view.viewArray[(int)(summonsobject[i].position.x + summonsobject[i].viewRange[i].x), (int)(summonsobject[i].position.y + summonsobject[i].viewRange[i].y)] = true;
                }
            }
            else
            {
                for (int j = 0; j < summonsobject[i].viewRange.Length; j++)
                {
                    mainGame_StageDeta.view.viewArray[(int)(summonsobject[i].position.x + (summonsobject[i].viewRange[i].x * -1)), (int)(summonsobject[i].position.y + summonsobject[i].viewRange[i].y)] = true;
                }
            }
        }
        SummonObjectExitViewExit:

        //出現場所と目標を見えるように
        mainGame_StageDeta.view.viewArray[(int)(mainGame_StageDeta.enemy1_spawn_position.x), (int)(mainGame_StageDeta.enemy1_spawn_position.x)] = true;
        mainGame_StageDeta.view.viewArray[(int)(mainGame_StageDeta.enemy2_spawn_position.x), (int)(mainGame_StageDeta.enemy2_spawn_position.x)] = true;
        mainGame_StageDeta.view.viewArray[(int)(mainGame_StageDeta.enemy1_target_object.x), (int)(mainGame_StageDeta.enemy1_target_object.x)] = true;
        mainGame_StageDeta.view.viewArray[(int)(mainGame_StageDeta.enemy2_target_object.x), (int)(mainGame_StageDeta.enemy2_target_object.x)] = true;

        //表示
        shadowMesh.SetMesh(mainGame_StageDeta.view.viewArray);
    }

    //メインゲーム終了
    void Exit()
    {
        Load_Deta.Nextscenename = "StageSelectScene";
        SceneManager.LoadScene("Yanai_TestScene");
    }

}
