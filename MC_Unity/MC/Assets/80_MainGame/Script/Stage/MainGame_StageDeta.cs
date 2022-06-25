using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Constant;

public class MainGame_StageDeta
{
    //壁
    bool[,] map_grids_wall = new bool[10,6];
    //敵出現場所
    internal Vector2 enemy1_spawn_position;
    internal Vector2 enemy2_spawn_position;
    //敵の目標
    internal Vector2 enemy1_target_object;
    internal Vector2 enemy2_target_object;
    
    //視界
    internal View view = new View();

    //ステージ生成
    public MainGame_StageDeta(string stage)
    {
        switch (stage)
        {
            case main_ep1_1:
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
                view.viewArray = new bool[,]{
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
                break;
            case main_ep1_2:
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
            case main_ep1_3:
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
            case main_ep1_4:
                break;
            case main_ep2_1:
                break;
            case main_ep2_2:
                break;
            case main_ep2_3:
                break;
            case main_ep2_4:
                break;
            case main_ep3_1:
                break;
            case main_ep3_2:
                break;
            case main_ep3_3:
                break;
            case main_ep3_4:
                break;
            case main_ep4_1:
                break;
            case main_ep4_2:
                break;
            case main_ep4_3:
                break;
            case main_ep4_4:
                break;
            case main_ep5_1:
                break;
            case main_ep5_2:
                break;
            case main_ep5_3:
                break;
            case main_ep5_4:
                break;
        }
    }

    internal bool[,] GetMap()
    {
        return map_grids_wall;
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
    public bool[,] viewArray = new bool[10,6]{
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
