using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreen : MonoBehaviour
{
    //障害物
    [SerializeField]
    GameObject[] Obstacle;

    //敵目標
    [SerializeField]
    GameObject[] EnemyTargetObject;

    public void InitializeObstacle(bool[,] mapData)
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

    public void InitializeEnemyTargetObject(Vector2[] target)
    {
        for (int i = 0; i < 60; i++)
        {
            int x = i % 10;
            int y = i / 10;
            if (target[0] == new Vector2(x,y) || target[1] == new Vector2(x, y))
            {
                EnemyTargetObject[i].SetActive(true);
            }
            else
            {
                EnemyTargetObject[i].SetActive(false);
            }
        }
    }
}
