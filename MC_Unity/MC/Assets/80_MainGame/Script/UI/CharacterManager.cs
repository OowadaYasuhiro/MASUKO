using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    [SerializeField]
    GameObject Player1;
    [SerializeField]
    GameObject Player2;
    [SerializeField]
    GameObject Enemy1;
    [SerializeField]
    GameObject Enemy2;

    RectTransform player1Rect;
    RectTransform player2Rect;
    RectTransform enemy1Rect;
    RectTransform enemy2Rect;

    Vector2 outPosition = new Vector2(-1,-1);
    Vector2 outSide = new Vector2(20,0);

    private void Start()
    {
        player1Rect = Player1.GetComponent<RectTransform>();
        player2Rect = Player2.GetComponent<RectTransform>();
        enemy1Rect = Enemy1.GetComponent<RectTransform>();
        enemy2Rect = Enemy2.GetComponent<RectTransform>();
    }

    public void CharacterVisualization(Vector2 position,bool player,int number)
    {
        if (position == outPosition)
        {
            if (player == true)
            {
                if (number == 1)
                {
                    player1Rect.anchoredPosition = PositionConvert.VectorConvert(outSide);
                }
                else
                {
                    player2Rect.anchoredPosition = PositionConvert.VectorConvert(outSide);
                }
            }
            else
            {
                if (number == 1)
                {
                    enemy1Rect.anchoredPosition = PositionConvert.VectorConvert(outSide);
                }
                else
                {
                    enemy2Rect.anchoredPosition = PositionConvert.VectorConvert(outSide);
                }
            }
        }
        else
        {
            if (player == true)
            {
                if (number == 1)
                {
                    player1Rect.anchoredPosition = PositionConvert.VectorConvert(position);
                }
                else
                {
                    player2Rect.anchoredPosition = PositionConvert.VectorConvert(position);
                }
            }
            else
            {
                if (number == 1)
                {
                    enemy1Rect.anchoredPosition = PositionConvert.VectorConvert(position);
                }
                else
                {
                    enemy2Rect.anchoredPosition = PositionConvert.VectorConvert(position);
                }
            }
        }
    }
}
