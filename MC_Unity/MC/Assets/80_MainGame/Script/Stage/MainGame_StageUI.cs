using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

[Serializable]
public class MainGame_StageUI : MonoBehaviour
{
    [Space(15)]
    //ステージ背景
    //[SerializeField] GameObject BackGround;
    //ステージ
    [SerializeField] GameObject GameScreen;

    //エピソード１のステージ
    [SerializeField] GameObject EP1GameScreen;
    //エピソード２のステージ
    [SerializeField] GameObject EP2GameScreen;
    //エピソード３のステージ
    [SerializeField] GameObject EP3GameScreen;
    //エピソード４のステージ
    [SerializeField] GameObject EP4GameScreen;
    //エピソード５のステージ
    [SerializeField] GameObject EP5GameScreen;

    //バックグラウンドをセット
    internal void SetBackGround(int number)
    {
        //BackGround.SendMessage("SetBackGround",number);
    }

    internal void SetObstacle(int number)
    {
        switch (number)
        {
            case 1:
                GameScreen = EP1GameScreen;
                break;
            case 2:
                GameScreen = EP2GameScreen;
                break;
            case 3:
                GameScreen = EP3GameScreen;
                break;
            case 4:
                GameScreen = EP4GameScreen;
                break;
            case 5:
                GameScreen = EP5GameScreen;
                break;
        }
        bool[,] mapData = GetComponent<MainGame>().mainGame_StageDeta.GetMap();
        GameScreen.SendMessage("InitializeObstacle", mapData);
    }
}
