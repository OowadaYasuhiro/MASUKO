using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getvalue : MonoBehaviour
{
    public Slider mastarSlider;
    public Text value;

    // Start is called before the first frame update
    void Start()
    {
        mastarSlider = GetComponent<Slider>();
        value = GetComponent<Text>();
    }

    // Update is called once per frame

    void Method()
    {
        value.text = $"{mastarSlider.value}";
    }
}
