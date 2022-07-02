using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultExperience : MonoBehaviour
{
    [SerializeField]
    public GameObject TextLvel;
    [SerializeField]
    public GameObject TextTotalExperience;
    /*[SerializeField]
    public GameObject Item_object = null;
    [SerializeField]
    public int Item_num = 0;*/
    [SerializeField]
    public float TotalExperience;
    [SerializeField]
    public float Lv_num;
    [SerializeField]
    public Slider exSlider;

    void Awake()
    {
        /*TextLvel = null;
        TextTotalExperience = null;*/
        TotalExperience = 0;
        Lv_num = 1;
    }
    // Start is called before the first frame update
    void Start()
    {

        //スライダーの最大値の設定
        exSlider.maxValue = Lv_num * 1000;

        //スライダーの現在値の設定
        exSlider.value = TotalExperience;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        { //Down
            TotalExperience += 10f;
            if (Lv_num * 1000 == TotalExperience)
            {
                Lv_num += 1;
                TotalExperience -= TotalExperience;
            }
            //スライダーの現在値の設定
            exSlider.value = TotalExperience;
        }
        Text TE_Lv = TextTotalExperience.GetComponent<Text>();
        TE_Lv.text = TotalExperience + "/" + Lv_num * 1000;
        Text Lv_text = TextLvel.GetComponent<Text>();
        Lv_text.text = Lv_num + "";
        //スライダーの最大値の設定
        exSlider.maxValue = Lv_num * 1000;

        //Text Item_text = Item_object.GetComponent<Text>();
        //Item_text.text = "×" + Item_num;
    }
}
