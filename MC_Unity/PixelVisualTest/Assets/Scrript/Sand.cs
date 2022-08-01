using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sand : MonoBehaviour
{
    const byte air = 0;
    const byte rock = 1;
    const byte sand = 2;

    internal byte _type;

    bool _isStatic = false;

    int fallDelay = 1;
    int delayTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_isStatic) goto SKIP;
        delayTime++;
        if (delayTime != fallDelay) goto SKIP;
        delayTime = 0;


        if (GameManager.GetGridData((int)transform.position.x, (int)transform.position.y - 1) == air)
        {
            GameManager.SetGridData((int)transform.position.x, (int)transform.position.y, air);
            GameManager.SetGridData((int)transform.position.x, (int)transform.position.y - 1, sand);
            transform.Translate(0,-1,0);
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
            _isStatic = true;
            gameObject.isStatic = true;
        }

        SKIP:;
    }
}
