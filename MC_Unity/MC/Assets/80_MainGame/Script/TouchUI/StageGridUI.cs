using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageGridUI : MonoBehaviour
{
    //ステージの四つ角
    readonly Vector2 upLeft = new Vector2(-755f, 385f);
    readonly Vector2 upRight = new Vector2(755f, 385f);
    readonly Vector2 downLeft = new Vector2(-850f, -215f);
    readonly Vector2 downRight = new Vector2(850f, -215f);

    //カーソル位置のグリッド
    Vector2Int selectGrid;

    //グリッドの横線
    const float depth0 = 385;
    const float depth1 = 292;
    const float depth2 = 200;
    const float depth3 = 102;
    const float depth4 = 0;
    const float depth5 = -105;
    const float depth6 = -215;

    //グリッドの縦線
    

    Vector2 cursorPosition;
    private void Start()
    {
        cursorPosition = GameObject.Find("UICamera").GetComponent<TouchUI>().InputPosition; 
        selectGrid = new Vector2Int(-1,-1);
    }

    void CursorGrid()
    {
        if (cursorPosition.y > depth0)
        {
            //範囲外
        }
        else if (cursorPosition.y > depth1)
        {
            selectGrid.y = 5;
            //if (cursorPosition.x > )
        }
        else if (cursorPosition.y > depth2)
        {
            selectGrid.y = 4;
        }
        else if (cursorPosition.y > depth3)
        {
            selectGrid.y = 3;
        }
        else if (cursorPosition.y > depth4)
        {
            selectGrid.y = 2;
        }
        else if (cursorPosition.y > depth5)
        {
            selectGrid.y = 1;
        }
        else if (cursorPosition.y > depth6)
        {
            selectGrid.y = 0;
        }
    }
}
