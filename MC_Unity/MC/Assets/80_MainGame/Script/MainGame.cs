using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public enum GameState{
        BeforeStart,
        PreparationPhase,
        GameRun,
        Wait,
        End
    }
    public GameState gamestate;

    //ゲーム内時間軸
    float Game_Speed;

    //**イベント**
    //一時停止
    bool pause;
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

    // Start is called before the first frame update
    void Start()
    {
        gamestate = GameState.BeforeStart;
        Game_Speed = 1;
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

                break;
            case GameState.Wait:

                break;
            case GameState.End:

                break;
        }
    }
}
