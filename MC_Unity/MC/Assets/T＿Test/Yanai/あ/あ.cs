using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class あ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OcClick() {
        //次のシーンを文字で指定
        Load_Deta.Nextscenename = "Yanai_test2";
        //ローディング画面に飛ばす
        //T_Test>Yanai>load>C>loadにスクリプトが入ってる。
        SceneManager.LoadScene("Yanai_TestScene");
    }
}
