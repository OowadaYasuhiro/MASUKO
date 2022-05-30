using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour
{
    public static float i;
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
        i += (Random.value*3);
        loadSlider.value = i;
        if (loadSlider.value >= 95)
        {
            loadSlider.value = 100;
            i = 100;
        }


        //ロード完了した時
        if(loadSlider.value >= 100) {
            //Load_Deta.Nextscrnrnumberに対応した次のシーンに飛ばす。
            switch(Load_Deta.nextscenenumber) {
                case Nextscenenumber.Kyouka:
                    //強化画面
                    SceneManager.LoadScene("yanai_test2");
                    break;
              /*case Nextscenenumber.(任意の列挙型) :
                    //強化画面
                    SceneManager.LoadScene("任意のシーン");
                    break;
              */
            }
        }
    }
}
