using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame_StageDeta
{
    bool[,] map_grids_wall = new bool[10,6];
    Vector2 enemy1_spawn_position;
    Vector2 enemy2_spawn_position;
    Vector2 enemy1_target_object;
    Vector2 enemy2_target_object;
    Vector2?[] enemy1_position;
    Vector2?[] enemy2_position;
    Vector2?[] player1_position;
    Vector2?[] player2_position;

    public MainGame_StageDeta(int ep,int st)
    {
        switch (ep)
        {
            case 1:
                switch (st)
                {
                    case 1:
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
                    case 2:
                        map_grids_wall = new bool[,]{
                            { true,false,false,false,new Map_Grid(false),new Map_Grid(true)},
                            { true,false,false,false,new Map_Grid(false),new Map_Grid(true)},
                            { true,true,true,false,new Map_Grid(true),new Map_Grid(true)},
                            { true,false,false,false,new Map_Grid(false),new Map_Grid(true)},
                            { true,false,false,false,new Map_Grid(false),new Map_Grid(true)},
                            { true,false,false,true,new Map_Grid(true),new Map_Grid(true)},
                            { true,false,false,false,new Map_Grid(false),new Map_Grid(true)},
                            { true,false,false,false,new Map_Grid(false),new Map_Grid(true)},
                            { true,true,true,false,new Map_Grid(true),new Map_Grid(true)},
                            { true,false,false,false,new Map_Grid(false),new Map_Grid(true)}
                        };
                        enemy1_spawn_position = new Vector2(0, 1);
                        enemy2_spawn_position = new Vector2(0, 1);
                        enemy1_target_object = new Vector2(9, 4);
                        enemy2_target_object = new Vector2(9, 4);
                        break;
                    case 3:
                        map_grids_wall = new Map_Grid[,]{
                            { new Map_Grid(true),new Map_Grid(true),new Map_Grid(true),new Map_Grid(true),new Map_Grid(false),new Map_Grid(true)},
                            { new Map_Grid(true),new Map_Grid(true),new Map_Grid(false),new Map_Grid(true),new Map_Grid(false),new Map_Grid(true)},
                            { new Map_Grid(true),new Map_Grid(true),new Map_Grid(false),new Map_Grid(true),new Map_Grid(false),new Map_Grid(true)},
                            { new Map_Grid(false),new Map_Grid(false),new Map_Grid(false),new Map_Grid(false),new Map_Grid(false),new Map_Grid(false)},
                            { new Map_Grid(false),new Map_Grid(false),new Map_Grid(false),new Map_Grid(false),new Map_Grid(false),new Map_Grid(false)},
                            { new Map_Grid(false),new Map_Grid(false),new Map_Grid(false),new Map_Grid(false),new Map_Grid(false),new Map_Grid(false)},
                            { new Map_Grid(false),new Map_Grid(false),new Map_Grid(false),new Map_Grid(false),new Map_Grid(false),new Map_Grid(false)},
                            { new Map_Grid(true),new Map_Grid(true),new Map_Grid(false),new Map_Grid(true),new Map_Grid(false),new Map_Grid(true)},
                            { new Map_Grid(true),new Map_Grid(true),new Map_Grid(false),new Map_Grid(true),new Map_Grid(false),new Map_Grid(true)},
                            { new Map_Grid(true),new Map_Grid(true),new Map_Grid(true),new Map_Grid(true),new Map_Grid(false),new Map_Grid(true)}
                        };
                        enemy1_spawn_position = new Vector2(0, 4);
                        enemy2_spawn_position = new Vector2(9, 4);
                        enemy1_target_object = new Vector2(4, 0);
                        enemy2_target_object = new Vector2(5, 0);
                        break;
                    case 4:

                        break;
                }
                break;
            case 2:
                switch (st)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                }
                break;
            case 3:
                switch (st)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                }
                break;
            case 4:
                switch (st)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                }
                break;
            case 5:
                switch (st)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                }
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
