using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//キャラ画像の表示
public class selectcharacter : MonoBehaviour
{
    //キャラ画像の取得
    [SerializeField] GameObject Daemon;
    [SerializeField] GameObject Poltergeist;
    [SerializeField] GameObject Gore;
    [SerializeField] GameObject Zashiki_warashi;
    [SerializeField] GameObject Ghost;
    void Start()
    {
        //初期化
        Ghost.gameObject.SetActive(false);
        Zashiki_warashi.gameObject.SetActive(false);
        Gore.gameObject.SetActive(false);
        Poltergeist.gameObject.SetActive(false);
        Daemon.gameObject.SetActive(false);
        //選択中のキャラの取得
        //string Now = Master.playerdeta.NowSelectCharactor;
        //判定し、表示
        switch (Master.playerdeta.NowSelectCharactor)
        {
            case "Ghost":
                Ghost.gameObject.SetActive(true);
                break;
            case "Zashiki_warashi":
                Zashiki_warashi.gameObject.SetActive(true);
                break;
            case "Gore":
                Gore.gameObject.SetActive(true);
                break;
            case "Poltergeist":
                Poltergeist.gameObject.SetActive(true);
                break;
            case "Daemon":
                Daemon.gameObject.SetActive(true);
                break;
        }
    }
}
