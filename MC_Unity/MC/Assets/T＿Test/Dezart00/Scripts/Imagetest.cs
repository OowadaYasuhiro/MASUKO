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
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            text1.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            text1.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            text2.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            text2.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            text3.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            text3.SetActive(false);
        }
    }
}
