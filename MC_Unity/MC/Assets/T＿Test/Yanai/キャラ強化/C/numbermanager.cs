using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numbermanager : MonoBehaviour
{
    [SerializeField] GameObject sinrai;
    [SerializeField] GameObject charactername;
    [SerializeField] GameObject Coin;
    [SerializeField] GameObject Zanryu_Sinen;
    [SerializeField] GameObject MagaTamashi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //キャラクターネーム
        Text Charactername = charactername.GetComponent<Text>();
        switch(Master.playerdeta.NowSelectCharactor) {
            case "Ghost":
                Charactername.text = "幽霊";
                break;
            case "Zashiki_warashi":
                Charactername.text = "座敷童";
                break;
            case "Gore":
                Charactername.text = "鬼";
                break;
            case "Poltergeist":
                Charactername.text = "ポルターガイスト";
                break;
            case "Daemon":
                Charactername.text = "デーモン";
                break;
    　　}
        //信頼度
        Sinrai();
        /*ここから下の三つはプレハブ化されて使わなくなるかも*/
        //コイン
        Text coin = Coin.GetComponent<Text>();
        coin.text = $"{Master.playerdeta.Coin}";
        //残留思念
        Text zanryu_Sinen = Zanryu_Sinen.GetComponent<Text>();
        zanryu_Sinen.text = $"{Master.playerdeta.Zanryu_Sinen}";
        //勾玉
        Text magaTamashi = MagaTamashi.GetComponent<Text>();
        magaTamashi.text = $"{Master.playerdeta.MagaTamashi}";
    }

    void Sinrai() {
        Text Sinrai = sinrai.GetComponent<Text>();
        switch(Master.playerdeta.NowSelectCharactor) {
            case "Ghost":
                if(Master.playerdeta.GhostCredibility < 50) {
                    Sinrai.text = "0";
                }else if(Master.playerdeta.GhostCredibility < 150) {
                    Sinrai.text = "1";
                } else if(Master.playerdeta.GhostCredibility < 250) {
                    Sinrai.text = "2";
                }else if(Master.playerdeta.GhostCredibility < 450) {
                    Sinrai.text = "3";
                } else {
                    Sinrai.text = "4";
                }
                break;
            case "Zashiki_warashi":
                Sinrai.text = $"{Master.playerdeta.Zashiki_warashiCredibility}";
                break;
            case "Gore":
                Sinrai.text = $"{Master.playerdeta.goreCredibility}";
                break;
            case "Poltergeist":
                Sinrai.text = $"{Master.playerdeta.PoltergeistCredibility}";
                break;
            case "Daemon":
                Sinrai.text = $"{Master.playerdeta.DaemonCredibility}";
                break;
        }
    }
}
