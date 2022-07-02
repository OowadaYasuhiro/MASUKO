using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Texttest : MonoBehaviour
{
    [SerializeField]
    public GameObject TextLvel = null;
    [SerializeField]
    public GameObject TextTotalExperience = null;
    [SerializeField]
    public GameObject slider;
    /*[SerializeField]
    public GameObject Item_object = null;
    [SerializeField]
    public int Item_num = 0;*/
    [SerializeField]
    public float TotalExperience = 0;
    [SerializeField]
    public float Lv_num = 0;
    [SerializeField]
    public Slider hpSlider;

    // Start is called before the first frame update
    void Start()
    {
        hpSlider = GetComponent<Slider>();



        //スライダーの最大値の設定
        hpSlider.maxValue = Lv_num * 1000;

        //スライダーの現在値の設定
        hpSlider.value = TotalExperience;
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

            //スライダーの現在値の設定
            hpSlider.value = TotalExperience;
        }
        Text TE_Lv = TextTotalExperience.GetComponent<Text>();
        TE_Lv.text =TotalExperience + "/" + Lv_num * 1000;
        Text Lv_text = TextLvel.GetComponent<Text>();
        Lv_text.text = Lv_num + "";
        //スライダーの最大値の設定
        hpSlider.maxValue = Lv_num * 1000;

        //Text Item_text = Item_object.GetComponent<Text>();
        //Item_text.text = "×" + Item_num;
    }
}
