using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
    const byte air = 0;
    const byte rock = 1;
    const byte sand = 2;

    public static bool SandMove(Transform transform)
    {
        bool moved = true;

        if (GameManager.GetGridData((int)transform.position.x, (int)transform.position.y - 1) == air)
        {
            GameManager.SetGridData((int)transform.position.x, (int)transform.position.y, air);
            GameManager.SetGridData((int)transform.position.x, (int)transform.position.y - 1, sand);
            transform.Translate(0, -1, 0);
        }
        else if (GameManager.GetGridData((int)transform.position.x - 1, (int)transform.position.y - 1) == air)
        {
            GameManager.SetGridData((int)transform.position.x, (int)transform.position.y, air);
            GameManager.SetGridData((int)transform.position.x - 1, (int)transform.position.y - 1, sand);
            transform.Translate(-1, -1, 0);
        }
        else if (GameManager.GetGridData((int)transform.position.x + 1, (int)transform.position.y - 1) == air)
        {
            GameManager.SetGridData((int)transform.position.x, (int)transform.position.y, air);
            GameManager.SetGridData((int)transform.position.x + 1, (int)transform.position.y - 1, sand);
            transform.Translate(+1, -1, 0);
        }
        else
        {
            moved = false;
        }

        return moved;
    }
}
