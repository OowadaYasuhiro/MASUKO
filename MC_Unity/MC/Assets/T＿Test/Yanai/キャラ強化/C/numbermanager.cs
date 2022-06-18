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
    [SerializeField] Image Sinrai1;
    [SerializeField] Image Sinrai2;
    [SerializeField] Image Sinrai3;
    [SerializeField] Image Sinrai4;

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
        float Sinraivalue = 0;
        Text Sinrai = sinrai.GetComponent<Text>();
        switch(Master.playerdeta.NowSelectCharactor) {
            case "Ghost":
                Sinraivalue = Master.playerdeta.GhostCredibility;
                break;
            case "Zashiki_warashi":
                Sinraivalue = Master.playerdeta.Zashiki_warashiCredibility;
                break;
            case "Gore":
                Sinraivalue = Master.playerdeta.goreCredibility;
                break;
            case "Poltergeist":
                Sinraivalue = Master.playerdeta.PoltergeistCredibility;
                break;
            case "Daemon":
                Sinraivalue = Master.playerdeta.DaemonCredibility;
                break;
        }
        if(Sinraivalue < 50) {
                    Sinrai.text = "0";
            Sinrai1.fillAmount = Sinraivalue/50f;
        } else if(Sinraivalue < 150) {
                    Sinrai.text = "1";
            Sinrai1.fillAmount = 1;
            Sinrai2.fillAmount =(Sinraivalue-50) / 100f;
        } else if(Sinraivalue < 250) {
                    Sinrai.text = "2";
            Sinrai1.fillAmount = 1;
            Sinrai2.fillAmount = 1;
            Sinrai3.fillAmount = (Sinraivalue - 150) / 200f;
        } else if(Sinraivalue < 450) {
                    Sinrai.text = "3";
            Sinrai1.fillAmount = 1;
            Sinrai2.fillAmount = 1;
            Sinrai3.fillAmount = 1;
            Sinrai4.fillAmount = (Sinraivalue - 250) / 450f;
        } else {
                    Sinrai.text = "4";
            Sinrai1.fillAmount = 1;
            Sinrai2.fillAmount = 1;
            Sinrai3.fillAmount = 1;
            Sinrai4.fillAmount = 1;
        }
        
    }
}
