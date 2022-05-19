using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using static Constant;

public class MainGame_StageDeta
{
    //壁
    bool[,] map_grids_wall = new bool[10,6];
    //敵出現場所
=======

public class MainGame_StageDeta
{
    bool[,] map_grids_wall = new bool[10,6];
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
    Vector2 enemy1_spawn_position;
    Vector2 enemy2_spawn_position;
    Vector2 enemy1_target_object;
    Vector2 enemy2_target_object;
<<<<<<< HEAD
    //敵座標
    Vector2?[] enemy1_position;
    Vector2?[] enemy2_position;
    //プレイヤー座標
    Vector2?[] player1_position;
    Vector2?[] player2_position;

    //ステージ生成
=======
    Vector2?[] enemy1_position;
    Vector2?[] enemy2_position;
    Vector2?[] player1_position;
    Vector2?[] player2_position;

>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
    public MainGame_StageDeta(string stage)
    {
        switch (stage)
        {
<<<<<<< HEAD
            case (main_ep1_1):
=======
            case (StageSelect_Deta.main_ep1_1):
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
                map_grids_wall = new bool[,]{
                            { true,false,false,false,false,true},
                            { true,false,false,false,false,true},
                            { true,false,false,false,false,true},
                            { true,false,false,false,false,true},
                            { true,false,false,false,false,true},
                            { true,false,false,false,false,true},
                            { true,false,false,false,false,true},
                            { true,false,false,false,false,true},
                            { true,false,false,false,false,true},
                            { true,false,false,false,false,true},
                        };
                enemy1_spawn_position = new Vector2(0, 4);
                enemy2_spawn_position = new Vector2(0, 1);
                enemy1_target_object = new Vector2(9, 4);
                enemy2_target_object = new Vector2(9, 1);
                break;
<<<<<<< HEAD
            case (main_ep1_2):
=======
            case (StageSelect_Deta.main_ep1_2):
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
                map_grids_wall = new bool[,]{
                            { true,false,false,false,false,true},
                            { true,false,false,false,false,true},
                            { true,true,true,false,true,true},
                            { true,false,false,false,false,true},
                            { true,false,false,false,false,true},
                            { true,false,false,true,true,true},
                            { true,false,false,false,false,true},
                            { true,false,false,false,false,true},
                            { true,true,true,false,true,true},
                            { true,false,false,false,false,true}
                        };
                enemy1_spawn_position = new Vector2(0, 1);
                enemy2_spawn_position = new Vector2(0, 1);
                enemy1_target_object = new Vector2(9, 4);
                enemy2_target_object = new Vector2(9, 4);
                break;
<<<<<<< HEAD
            case (main_ep1_3):
=======
            case (StageSelect_Deta.main_ep1_3):
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
                map_grids_wall = new bool[,]{
                            { true,true,true,true,false,true},
                            { true,true,false,true,false,true},
                            { true,true,false,true,false,true},
                            { false,false,false,false,false,false},
                            { false,false,false,false,false,false},
                            { false,false,false,false,false,false},
                            { false,false,false,false,false,false},
                            { true,true,false,true,false,true},
                            { true,true,false,true,false,true},
                            { true,true,true,true,false,true}
                        };
                enemy1_spawn_position = new Vector2(0, 4);
                enemy2_spawn_position = new Vector2(9, 4);
                enemy1_target_object = new Vector2(4, 0);
                enemy2_target_object = new Vector2(5, 0);
                break;
<<<<<<< HEAD
            case (main_ep1_4):
                break;
            case (main_ep2_1):
                break;
            case (main_ep2_2):
                break;
            case (main_ep2_3):
                break;
            case (main_ep2_4):
                break;
            case (main_ep3_1):
                break;
            case (main_ep3_2):
                break;
            case (main_ep3_3):
                break;
            case (main_ep3_4):
                break;
            case (main_ep4_1):
                break;
            case (main_ep4_2):
                break;
            case (main_ep4_3):
                break;
            case (main_ep4_4):
                break;
            case (main_ep5_1):
                break;
            case (main_ep5_2):
                break;
            case (main_ep5_3):
                break;
            case (main_ep5_4):
=======
            case (StageSelect_Deta.main_ep1_4):
                break;
            case (StageSelect_Deta.main_ep2_1):
                break;
            case (StageSelect_Deta.main_ep2_2):
                break;
            case (StageSelect_Deta.main_ep2_3):
                break;
            case (StageSelect_Deta.main_ep2_4):
                break;
            case (StageSelect_Deta.main_ep3_1):
                break;
            case (StageSelect_Deta.main_ep3_2):
                break;
            case (StageSelect_Deta.main_ep3_3):
                break;
            case (StageSelect_Deta.main_ep3_4):
                break;
            case (StageSelect_Deta.main_ep4_1):
                break;
            case (StageSelect_Deta.main_ep4_2):
                break;
            case (StageSelect_Deta.main_ep4_3):
                break;
            case (StageSelect_Deta.main_ep4_4):
                break;
            case (StageSelect_Deta.main_ep5_1):
                break;
            case (StageSelect_Deta.main_ep5_2):
                break;
            case (StageSelect_Deta.main_ep5_3):
                break;
            case (StageSelect_Deta.main_ep5_4):
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
                break;
        }
    }
}

public struct Map_Grid
{
    bool wall;
    public Map_Grid(bool v)
    {
        wall = v;
    }
}

public class View
{
    bool[,] view = new bool[10,6]{
            { false,false,false,false,false,false },
            { false,false,false,false,false,false },
            { false,false,false,false,false,false },
            { false,false,false,false,false,false },
            { false,false,false,false,false,false },
            { false,false,false,false,false,false },
            { false,false,false,false,false,false },
            { false,false,false,false,false,false },
            { false,false,false,false,false,false },
            { false,false,false,false,false,false },
    };
}
