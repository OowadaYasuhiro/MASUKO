using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapStart : MonoBehaviour
{
    [SerializeField] Animator Animation = null; 
    // Start is called before the first frame update
   public void OnClick() {
        Debug.Log("タップされた");
        Animation.SetTrigger("Click");
        Invoke("Seni",1f);
    }
    void Seni() {
        //ここにホーム画面の名前を入れる。
        /*Load_Deta.Nextscenename = "";
        SceneManager.LoadScene("Yanai_TestScene");*/
    }

}
