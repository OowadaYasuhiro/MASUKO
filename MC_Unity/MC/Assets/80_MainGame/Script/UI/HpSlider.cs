using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpSlider : MonoBehaviour
{
    Slider slider;
    float value = 1f;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    internal void SetHpSlider(int hp,int maxHp)
    {
        value = (float)hp / maxHp;
        slider.value = value;
    }
    
}
