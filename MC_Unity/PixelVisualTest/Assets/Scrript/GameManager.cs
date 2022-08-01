using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //　定数
    const byte air = 0;
    const byte rock = 1;
    const byte sand = 2;

    // プレハブ
    [SerializeField]
    GameObject Air;
    [SerializeField]
    GameObject Rock;
    [SerializeField]
    GameObject Sand;

    static GridData[,] gridDatas = new GridData[500, 500];

    Text text;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 500; i++)
        {
            for (int j = 0; j < 500; j++)
            {
                gridDatas[i, j] = new GridData();
            }
        }

        setStage();

        text = GameObject.Find("Canvas").GetComponentInChildren<Text>();
    }

    void setStage()
    {
        for(int i = 0; i < 500; i++)
        {
            gridDatas[i,0]._type = rock;
            Instantiate(Rock,new Vector3(i,0,0),Quaternion.identity);
            gridDatas[0, i]._type = rock;
            Instantiate(Rock, new Vector3(0, i, 0), Quaternion.identity);
        }
    }

    public static byte GetGridData(int x, int y)
    {
        return gridDatas[x,y]._type;
    }

    public static void SetGridData(int x, int y, byte type)
    {
        gridDatas[x, y]._x = x;
        gridDatas[x, y]._y = y;
        gridDatas[x, y]._type = type;
    } 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            gridDatas[130, 110]._type = rock;
            Instantiate(Sand, new Vector3(130, 110, 0), Quaternion.identity);
            gridDatas[60, 110]._type = rock;
            Instantiate(Sand, new Vector3(60, 110, 0), Quaternion.identity);
            gridDatas[200, 110]._type = rock;
            Instantiate(Sand, new Vector3(200, 110, 0), Quaternion.identity);
            gridDatas[100, 110]._type = rock;
            Instantiate(Sand, new Vector3(100, 110, 0), Quaternion.identity);
            gridDatas[160, 110]._type = rock;
            Instantiate(Sand, new Vector3(160, 110, 0), Quaternion.identity);
        }

        text.text = (1/Time.deltaTime).ToString();
    }
}
