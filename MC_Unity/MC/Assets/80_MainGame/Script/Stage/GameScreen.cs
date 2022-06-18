using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreen : MonoBehaviour
{
    //障害物
    [SerializeField]
    GameObject[] Obstacle;

    internal void InitializeObstacle(bool[,] mapData)
    {
        for (int i = 0; i < 60; i++)
        {
            int x = i%10;
            int y = i/10;
            if (mapData[x,y] == true)
            {
                Obstacle[i].SetActive(true);
            }
            else
            {
                Obstacle[i].SetActive(false);
            }
        }
    }
}
