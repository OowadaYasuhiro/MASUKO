using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TapStart : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] Animator Animation = null;

    // Start is called before the first frame update
    public void OnClick() {
        Animation.SetTrigger("Click");
        Invoke("Seni",3f);
    }
    void Seni() {
        //ここにホーム画面の名前を入れる。
        Load_Deta.Nextscenename = "HomeScene";
        SceneManager.LoadScene("Yanai_TestScene");
    }

}
