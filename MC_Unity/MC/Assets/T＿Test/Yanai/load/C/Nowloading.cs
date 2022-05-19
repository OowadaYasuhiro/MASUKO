using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nowloading : MonoBehaviour
{
    private bool flag;
    private bool flag2;
    private int hh;
    public GameObject dash = null;
    private Text load_text;
    // Start is called before the first frame update
    void Start()
    {
        flag = true;
        flag2 = false;
        hh = 0;
        load_text = dash.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == true)
        {
            Invoke("cont", 0.75f);
            flag = false;
        }
        if (flag2 == true)
        {
            switch (hh)
            {
                case 0:
                    load_text.text = "Now Loading";
                    hh++;
                    flag2 = false;
                    break;
                case 1:
                    load_text.text = "Now Loading・";
                    hh++;
                    flag2 = false;
                    break;
                case 2:
                    load_text.text = "Now Loading・・";
                    hh++;
                    flag2 = false;
                    break;
                case 3:
                    load_text.text = "Now Loading・・・";
                    hh = 0;
                    flag2 = false;
                    break;
            }

        }
    }
    void cont()
    {
        flag2 = true;
        flag = true;
    }
}
