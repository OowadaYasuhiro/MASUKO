using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomimage : MonoBehaviour
{
    [SerializeField] GameObject image1;
    [SerializeField] GameObject image2;
    int i;
    // Start is called before the first frame update
    void OnEnable()
    {
        i = Random.Range(1, 3);
        if(i == 1) {
           image1.SetActive(true);
           image2.SetActive(false);
        } else {
            image1.SetActive(false);
            image2.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
