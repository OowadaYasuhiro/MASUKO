using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Gacha1 : MonoBehaviour
{

    public GameObject _object = null;
    public int _num = 0;

    [SerializeField]
    private Button _button;

    int value1 = 0;
    int value2 = 0;
    int value3 = 0;
    int value4 = 0;
    int value5 = 0;
    int value6 = 0;
    int value7 = 0;
    int value8 = 0;
    int value9 = 0;
    int value10 = 0;

    [SerializeField]
    private Text _text1;
    [SerializeField]
    private Text _text2;
    [SerializeField]
    private Text _text3;
    [SerializeField]
    private Text _text4;
    [SerializeField]
    private Text _text5;
    [SerializeField]
    private Text _text6;
    [SerializeField]
    private Text _text7;
    [SerializeField]
    private Text _text8;
    [SerializeField]
    private Text _text9;
    [SerializeField]
    private Text _text10;


    float time1 = 0;

    // Start is called before the first frame update
    void Start()
    {
        _text1.text = "0";
        _text2.text = "0";
        _text3.text = "0";
        _text4.text = "0";
        _text5.text = "0";
        _text6.text = "0";
        _text7.text = "0";
        _text8.text = "0";
        _text9.text = "0";
        _text10.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        time1 += Time.deltaTime;
        A();
        //Debug.Log(time1);
    }

     void A()
    {
        if(time1 > 10f) { 
            value1 = Random.Range(0, 1000);
            value2 = Random.Range(0, 1000);
            value3 = Random.Range(0, 1000);
            value4 = Random.Range(0, 1000);
            value5 = Random.Range(0, 1000);
            value6 = Random.Range(0, 1000);
            value7 = Random.Range(0, 1000);
            value8 = Random.Range(0, 1000);
            value9 = Random.Range(0, 1000);
            value10 = Random.Range(0, 1000);
            time1 = 0f;
            Invoke("B",0.5f);
        }
    }

    void B()
    {
        _text1.text = "1: " + value1;
        Invoke("C",0.5f);
    }
    void C()
    {
        _text2.text = "2: " + value2;
        Invoke("D",0.5f);
    }
    void D()
    {
        _text3.text = "3: " + value3;
        Invoke("E",0.5f);
    }
    void E()
    {
        _text4.text = "4: " + value4;
        Invoke("F", 0.5f);
    }
    void F()
    {
        _text5.text = "5: " + value5;
        Invoke("G", 0.5f);
    }
    void G()
    {
        _text6.text = "6: " + value6;
        Invoke("H", 0.5f);
    }
    void H()
    {
        _text7.text = "7: " + value7;
        Invoke("I", 0.5f);
    }
    void I()
    {
        _text8.text = "8: " + value8;
        Invoke("J", 0.5f);
    }
    void J()
    {
        _text9.text = "9: " + value9;
        Invoke("K", 0.5f);
    }
    void K()
    {
        _text10.text = "10: " + value10;
        Invoke("M",2f);
    }
    void M()
    {
        _text1.text = "0";
        _text2.text = "0";
        _text3.text = "0";
        _text4.text = "0";
        _text5.text = "0";
        _text6.text = "0";
        _text7.text = "0";
        _text8.text = "0";
        _text9.text = "0";
        _text10.text = "0";
    }
}
