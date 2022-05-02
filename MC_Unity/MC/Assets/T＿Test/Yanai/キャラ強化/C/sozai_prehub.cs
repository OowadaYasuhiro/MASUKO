using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sozai_prehub : MonoBehaviour
{
    bool i;
    // Start is called before the first frame update
    void OnEnable() {
        i = false;
        Invoke("timer", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //生成から0.5秒立ったかつどこかタップされたら
        if(Input.GetMouseButtonDown(0) == true&&i == true) {
            gameObject.SetActive(false);
        }
    }
    void timer() {
        i = true;
    }
}
