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
        i += (Random.value);
        loadSlider.value = i;
        if (loadSlider.value >= 95)
        {
            loadSlider.value = 100;
            i = 100;
        }


        //ロード完了した時
        if(loadSlider.value >= 100) {
            //Load_Deta.Nextscrnrnumberに対応した次のシーンに飛ばす。
                    SceneManager.LoadScene(Load_Deta.Nextscenename);
        }
    }
}
