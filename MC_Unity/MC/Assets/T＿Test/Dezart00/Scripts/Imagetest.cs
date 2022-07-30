using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imagetest : MonoBehaviour
{
    [SerializeField] 
    private GameObject text1;//GameObject型の変数textを宣言　好きなゲームオブジェクトをアタッチ
    [SerializeField]
    private GameObject text2;//GameObject型の変数textを宣言　好きなゲームオブジェクトをアタッチ
    [SerializeField]
    private GameObject text3;//GameObject型の変数textを宣言　好きなゲームオブジェクトをアタッチ

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Master.playerdeta.Stage1_1Mission1 == true)
        {
            text1.SetActive(true);
        }
        else if (Master.playerdeta.Stage1_1Mission1 == false)
        {
            text1.SetActive(false);
        }

        if (Master.playerdeta.Stage1_1Mission2 == true)
        {
            text2.SetActive(true);
        }
        else if (Master.playerdeta.Stage1_1Mission2 == false)
        {
            text2.SetActive(false);
        }

        if (Master.playerdeta.Stage1_1Mission3 == true)
        {
            text3.SetActive(true);
        }
        else if (Master.playerdeta.Stage1_1Mission3 == false)
        {
            text3.SetActive(false);
        }
    }
}
