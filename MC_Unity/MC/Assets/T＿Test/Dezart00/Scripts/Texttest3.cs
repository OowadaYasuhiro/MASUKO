using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texttest3 : MonoBehaviour
{
    public GameObject Ep_object = null;
    public int Ep_num = 0;
    public int magnification = 0;
    public int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text Ep_text = Ep_object.GetComponent<Text>();
        Ep_text.text = Ep_num + "";
        num = Ep_num * magnification;
    }
}
