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

    //カーソル位置のグリッド　(-1,-1)を範囲外とする
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
    QuadraticIndex quadraticIndex_left0 = new QuadraticIndex(0.1583f, -816f);
    QuadraticIndex quadraticIndex_left1 = new QuadraticIndex(0.1266f, -707.23f);
    QuadraticIndex quadraticIndex_left2 = new QuadraticIndex(0.095f, -489.575f);
    QuadraticIndex quadraticIndex_left3 = new QuadraticIndex(0.063f, -326.384f);
    QuadraticIndex quadraticIndex_left4 = new QuadraticIndex(0.0316f, -163.206f);
    QuadraticIndex quadraticIndex_left5 = new QuadraticIndex(0, 0);
    QuadraticIndex quadraticIndex_left6 = new QuadraticIndex(-0.0316f, 163.206f);
    QuadraticIndex quadraticIndex_left7 = new QuadraticIndex(-0.063f, 326.384f);
    QuadraticIndex quadraticIndex_left8 = new QuadraticIndex(-0.095f, 489.575f);
    QuadraticIndex quadraticIndex_left9 = new QuadraticIndex(-0.1266f, 707.23f);
    QuadraticIndex quadraticIndex_left10 = new QuadraticIndex(-0.1583f, 816f);

    Vector2 cursorPosition;
    //[SerializeField] GameObject Camera;
    //[SerializeField] GameObject Image;

    private void Start()
    {
        cursorPosition = GameObject.Find("UICamera").GetComponent<TouchUI>().cursorPotision; 
        //cursorPosition = new Vector2(Image.transform.position.x, Image.transform.position.y);
        selectGrid = new Vector2Int(-1,-1);
    }

    private void Update()
    {
        cursorPosition = GameObject.Find("UICamera").GetComponent<TouchUI>().cursorPotision;
        CursorGrid();
    }

    void CursorGrid()
    {
        if (cursorPosition.y > depth0)
        {
            //範囲外
            selectGrid.x = -1;
            selectGrid.y = -1;
        }
        else if (cursorPosition.y > depth1)
        {
            selectGrid.y = 5;
            if (cursorPosition.x < quadraticIndex_left0.BoundaryCalculation(cursorPosition))
            {
                //範囲外
                selectGrid.x = -1;
                selectGrid.y = -1;
            }
            else if (cursorPosition.x < quadraticIndex_left1.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 0;
            }
            else if (cursorPosition.x < quadraticIndex_left2.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 1;
            }
            else if (cursorPosition.x < quadraticIndex_left3.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 2;
            }
            else if (cursorPosition.x < quadraticIndex_left4.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 3;
            }
            else if (cursorPosition.x < quadraticIndex_left5.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 4;
            }
            else if (cursorPosition.x < quadraticIndex_left6.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 5;
            }
            else if (cursorPosition.x < quadraticIndex_left7.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 6;
            }
            else if (cursorPosition.x < quadraticIndex_left8.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 7;
            }
            else if (cursorPosition.x < quadraticIndex_left9.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 8;
            }
            else if (cursorPosition.x < quadraticIndex_left10.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 9;
            }
            else
            {
                //範囲外
                selectGrid.x = -1;
                selectGrid.y = -1;
            }
        }
        else if (cursorPosition.y > depth2)
        {
            selectGrid.y = 4;
            if (cursorPosition.x < quadraticIndex_left0.BoundaryCalculation(cursorPosition))
            {
                //範囲外
                selectGrid.x = -1;
                selectGrid.y = -1;
            }
            else if (cursorPosition.x < quadraticIndex_left1.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 0;
            }
            else if (cursorPosition.x < quadraticIndex_left2.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 1;
            }
            else if (cursorPosition.x < quadraticIndex_left3.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 2;
            }
            else if (cursorPosition.x < quadraticIndex_left4.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 3;
            }
            else if (cursorPosition.x < quadraticIndex_left5.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 4;
            }
            else if (cursorPosition.x < quadraticIndex_left6.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 5;
            }
            else if (cursorPosition.x < quadraticIndex_left7.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 6;
            }
            else if (cursorPosition.x < quadraticIndex_left8.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 7;
            }
            else if (cursorPosition.x < quadraticIndex_left9.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 8;
            }
            else if (cursorPosition.x < quadraticIndex_left10.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 9;
            }
            else
            {
                //範囲外
                selectGrid.x = -1;
                selectGrid.y = -1;
            }
        }
        else if (cursorPosition.y > depth3)
        {
            selectGrid.y = 3;
            if (cursorPosition.x < quadraticIndex_left0.BoundaryCalculation(cursorPosition))
            {
                //範囲外
                selectGrid.x = -1;
                selectGrid.y = -1;
            }
            else if (cursorPosition.x < quadraticIndex_left1.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 0;
            }
            else if (cursorPosition.x < quadraticIndex_left2.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 1;
            }
            else if (cursorPosition.x < quadraticIndex_left3.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 2;
            }
            else if (cursorPosition.x < quadraticIndex_left4.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 3;
            }
            else if (cursorPosition.x < quadraticIndex_left5.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 4;
            }
            else if (cursorPosition.x < quadraticIndex_left6.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 5;
            }
            else if (cursorPosition.x < quadraticIndex_left7.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 6;
            }
            else if (cursorPosition.x < quadraticIndex_left8.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 7;
            }
            else if (cursorPosition.x < quadraticIndex_left9.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 8;
            }
            else if (cursorPosition.x < quadraticIndex_left10.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 9;
            }
            else
            {
                //範囲外
                selectGrid.x = -1;
                selectGrid.y = -1;
            }
        }
        else if (cursorPosition.y > depth4)
        {
            selectGrid.y = 2;
            if (cursorPosition.x < quadraticIndex_left0.BoundaryCalculation(cursorPosition))
            {
                //範囲外
                selectGrid.x = -1;
                selectGrid.y = -1;
            }
            else if (cursorPosition.x < quadraticIndex_left1.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 0;
            }
            else if (cursorPosition.x < quadraticIndex_left2.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 1;
            }
            else if (cursorPosition.x < quadraticIndex_left3.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 2;
            }
            else if (cursorPosition.x < quadraticIndex_left4.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 3;
            }
            else if (cursorPosition.x < quadraticIndex_left5.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 4;
            }
            else if (cursorPosition.x < quadraticIndex_left6.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 5;
            }
            else if (cursorPosition.x < quadraticIndex_left7.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 6;
            }
            else if (cursorPosition.x < quadraticIndex_left8.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 7;
            }
            else if (cursorPosition.x < quadraticIndex_left9.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 8;
            }
            else if (cursorPosition.x < quadraticIndex_left10.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 9;
            }
            else
            {
                //範囲外
                selectGrid.x = -1;
                selectGrid.y = -1;
            }
        }
        else if (cursorPosition.y > depth5)
        {
            selectGrid.y = 1;
            if (cursorPosition.x < quadraticIndex_left0.BoundaryCalculation(cursorPosition))
            {
                //範囲外
                selectGrid.x = -1;
                selectGrid.y = -1;
            }
            else if (cursorPosition.x < quadraticIndex_left1.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 0;
            }
            else if (cursorPosition.x < quadraticIndex_left2.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 1;
            }
            else if (cursorPosition.x < quadraticIndex_left3.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 2;
            }
            else if (cursorPosition.x < quadraticIndex_left4.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 3;
            }
            else if (cursorPosition.x < quadraticIndex_left5.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 4;
            }
            else if (cursorPosition.x < quadraticIndex_left6.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 5;
            }
            else if (cursorPosition.x < quadraticIndex_left7.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 6;
            }
            else if (cursorPosition.x < quadraticIndex_left8.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 7;
            }
            else if (cursorPosition.x < quadraticIndex_left9.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 8;
            }
            else if (cursorPosition.x < quadraticIndex_left10.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 9;
            }
            else
            {
                //範囲外
                selectGrid.x = -1;
                selectGrid.y = -1;
            }
        }
        else if (cursorPosition.y > depth6)
        {
            selectGrid.y = 0;
            if (cursorPosition.x < quadraticIndex_left0.BoundaryCalculation(cursorPosition))
            {
                //範囲外
                selectGrid.x = -1;
                selectGrid.y = -1;
            }
            else if (cursorPosition.x < quadraticIndex_left1.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 0;
            }
            else if (cursorPosition.x < quadraticIndex_left2.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 1;
            }
            else if (cursorPosition.x < quadraticIndex_left3.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 2;
            }
            else if (cursorPosition.x < quadraticIndex_left4.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 3;
            }
            else if (cursorPosition.x < quadraticIndex_left5.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 4;
            }
            else if (cursorPosition.x < quadraticIndex_left6.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 5;
            }
            else if (cursorPosition.x < quadraticIndex_left7.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 6;
            }
            else if (cursorPosition.x < quadraticIndex_left8.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 7;
            }
            else if (cursorPosition.x < quadraticIndex_left9.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 8;
            }
            else if (cursorPosition.x < quadraticIndex_left10.BoundaryCalculation(cursorPosition))
            {
                selectGrid.x = 9;
            }
            else
            {
                //範囲外
                selectGrid.x = -1;
                selectGrid.y = -1;
            }
        }
        else
        {
            //範囲外
            selectGrid.x = -1;
            selectGrid.y = -1;
        }
        Debug.Log(selectGrid);
        //Debug.Log(cursorPosition);
    }
}

public class QuadraticIndex
{
    public QuadraticIndex(float r,float d)
    {
        ratio = r;
        difference = d;
    }

    public float ratio;
    public float difference;

    public float BoundaryCalculation(Vector2 value)
    {
        float boundaryPoint;
        boundaryPoint = value.y * ratio + difference;
        return boundaryPoint;
    }
}
