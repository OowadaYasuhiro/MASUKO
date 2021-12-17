using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace test_var1{
    public class Map : MonoBehaviour
    {
        [SerializeField] GameObject Road;
        [SerializeField] GameObject Wall;

        public static Vector2Int enemystartposition = new Vector2Int(0,3);

        //left y right x
        public static int[,] mapdeta = new int[5,10]
        {
            { 1,1,1,0,1,0,0,0,0,1 },
            { 1,1,1,0,0,0,0,1,0,0 },
            { 0,0,0,0,1,0,0,1,0,0 },
            { 1,1,1,0,1,0,1,1,0,1 },
            { 1,1,1,0,1,0,0,0,0,1 }
        };

        const int road = 0;
        const int wall = 1;
        // Start is called before the first frame update
        void Start()
        {
            for (int a = 0;a < mapdeta.GetLength(0); a++)
            {
                for (int b = 0;b < mapdeta.GetLength(1); b++)
                {
                    Vector3 instantiateposition = new Vector3(b,0,5 - a);
                    if(mapdeta[a,b] == road)
                    {
                        Instantiate(Road, instantiateposition, Quaternion.identity);
                    }
                    if(mapdeta[a,b] == wall)
                    {
                        Instantiate(Wall, instantiateposition, Quaternion.identity);
                    }
                }
            }
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
