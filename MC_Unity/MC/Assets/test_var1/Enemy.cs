using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector2Int startposition = test_var1.Map.enemystartposition;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(startposition.x,1,startposition.y);
    }

    // Update is called once per frame
    void Update()
    {
        //test_var1.Map.mapdeta[,];
    }
}
