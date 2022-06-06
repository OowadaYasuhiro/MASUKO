using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Texttest : MonoBehaviour
{
    public GameObject TextLvel = null;
    public GameObject TextTotalExperience = null;
    //public GameObject Item_object = null;
    public int Item_num = 0;
    public int TotalExperience = 0;
    public int Lv_num = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) { //Down
            TotalExperience += 100;
            if (Lv_num * 1000 == TotalExperience)
            {
                Lv_num += 1;
                TotalExperience -= TotalExperience;
            }
        }
        Text TE_Lv = TextTotalExperience.GetComponent<Text>();
        TE_Lv.text =TotalExperience + "/" + Lv_num * 1000;
        Text Lv_text = TextLvel.GetComponent<Text>();
        Lv_text.text = Lv_num + "";

        //Text Item_text = Item_object.GetComponent<Text>();
        //Item_text.text = "×" + Item_num;
    }
}
