using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texttest2 : MonoBehaviour
{
    public GameObject Lv_object = null;
    public int Lv_num = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text Lv_text = Lv_object.GetComponent<Text>();
        Lv_text.text = "" + Lv_num;

    }
}
