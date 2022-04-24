using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imagetest3 : MonoBehaviour
{
    [SerializeField]
    private GameObject text1;//GameObject型の変数textを宣言　好きなゲームオブジェクトをアタッチ

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            text1.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            text1.SetActive(false);
        }

    }
}
