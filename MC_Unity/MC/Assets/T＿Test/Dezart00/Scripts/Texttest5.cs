using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texttest5 : MonoBehaviour
{
    public GameObject Coin_object = null;
    public int Coin_num = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text Coin_text = Coin_object.GetComponent<Text>();
        Coin_text.text = "×" + Coin_num;
    }
}
