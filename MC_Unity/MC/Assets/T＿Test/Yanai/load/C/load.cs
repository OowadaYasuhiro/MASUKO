using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class load : MonoBehaviour
{
    float i;
    public Slider loadSlider;
    // Start is called before the first frame update
    void OnEnable()
    {
        loadSlider = GetComponent<Slider>();
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        i += (Random.value / 5);
        loadSlider.value = i;
        if (loadSlider.value >= 95)
        {
            loadSlider.value = 100;
        }


        //ロード完了した時
        if(loadSlider.value <= 100) {
            //次にどこのシーンにいいのかを受け取る
            /*switch() {
            対応したシーンに飛ばす
            }*/
        }
    }
}
