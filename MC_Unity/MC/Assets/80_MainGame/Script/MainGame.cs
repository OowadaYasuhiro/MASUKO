using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using static Constant;

public partial class MainGame : MonoBehaviour
{
    //ゲームステート
    [HideInInspector]
=======

public partial class MainGame : MonoBehaviour
{
    public enum GameState{
        BeforeStart,
        PreparationPhase,
        GameRun,
        Wait,
        End
    }
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
    public GameState gamestate;

    //マスターオブジェクト
    GameObject master;

    //ステージ
    string stage;

    //現在のウェーブ
    int waveNumber;

    //ゲーム内時間軸
    float Game_Speed;

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

<<<<<<< HEAD
    //プレイヤー
    Player [] player;

    //初期化
=======
    // Start is called before the first frame update
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
    void Start()
    {
        gamestate = GameState.BeforeStart;
        Game_Speed = 1;
        master = GameObject.Find("MasterObject");
<<<<<<< HEAD
        waveNumber = 1;
        GeneratEnemy();
=======
        
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
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

<<<<<<< HEAD
                WaveClearCheck();
=======
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
                break;
            case GameState.Wait:

                break;
            case GameState.End:

                break;
        }
    }

<<<<<<< HEAD
    //ウェーブを次へ
    void ChengeWave()
    {
        waveNumber += 1;
        GeneratEnemy();
    }

    //スロウモード
=======
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
    void SlowCheck()
    {
        if (slowMode) Game_Speed = 0.25f;
        else Game_Speed = 1f;
    }

<<<<<<< HEAD
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

=======
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03

}
