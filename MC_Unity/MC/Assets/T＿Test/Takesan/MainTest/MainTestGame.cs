using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTestGame : MonoBehaviour
{
    int[,] glid = new int[10,6];

    int[,] st1_1emn = new int[,]{{0,0 },{1,0 },{2,0 },{3,0 },{4,0 },{5,0 },{6,0 },{7,0 },{8,0 },{9,0 },{8,0 },{7,0 },{6,0 },{5,0 },{4,0 },{3,0 },{2,0 },{1,0 },{0,0 }};

    int[,] emn = new int[30,4];

    bool emoving = false;
    int emovingnumber = 0;
    float timeline = 0;

    MainTestPlayer player = new MainTestPlayer();

    float speed = 1;
    float flame = 50;
    
    // Start is called before the first frame update
    void Start()
    {
        player.position = new Vector2(0,0);
        for (int i = 0; i < 18; i++)
        {
            emn[i, 0] = st1_1emn[i, 0];
            emn[i, 1] = st1_1emn[i, 1];
            emn[i, 2] = st1_1emn[i + 1, 0];
            emn[i, 3] = st1_1emn[i + 1, 1];
        }
        emoving = true;
        timeline = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (emoving)
        {
            timeline += Time.deltaTime;
        }

        Vector2 avec = new Vector2(emn[emovingnumber, 2], emn[emovingnumber, 3]) - new Vector2(emn[emovingnumber, 0], emn[emovingnumber, 1]);
        player.position += avec * Time.deltaTime;
        Debug.Log(player.position);

        if (timeline >= 1)
        {
            timeline = 0;
            player.position = new Vector2(emn[emovingnumber,2], emn[emovingnumber, 3]);
            emovingnumber++;
        }
    }

}

public class MainTestPlayer
{
    public Vector2 position;

}
