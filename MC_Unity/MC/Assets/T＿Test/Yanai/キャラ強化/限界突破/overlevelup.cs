using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class overlevelup : MonoBehaviour
{
    [SerializeField] Text level;
<<<<<<< HEAD
    [SerializeField] Text levelup;
    [SerializeField] Text sozai1;
    [SerializeField] Text sozai2;
    [SerializeField] Text sozai3;
    [SerializeField] Text coin;
    //レベルlow
    [SerializeField] Text keikoku;
    [SerializeField] GameObject levellow;
    int nowlevel;
    [SerializeField] GameObject levelupwindow;
    //壱段階目か同課の判定
    bool nowselectover50;
    bool nowselectover70;
    // Start is called before the first frame update
    void OnEnable()
    {
        levellow.SetActive(false);
        syokika(Master.playerdeta.NowSelectCharactor);
        if(nowlevel <= 50) {
            sozai1.text = "×3";
            sozai2.text = "×5";
            sozai3.text = "×10";
            coin.text = "10000QP";
        }else {
            sozai1.text = "×5";
            sozai2.text = "×10";
            sozai3.text = "×15";
            coin.text = "50000QP";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void onclick() {
        //レベルがmaxか
        if(nowlevel == 50 || nowlevel == 70) {
            //素材が足りているか
            if(nowlevel <= 50) {
                if(Master.playerdeta.KisyounaReikon >=3&& Master.playerdeta.Reikesseki >= 5&& Master.playerdeta.Reikotu>=10&& Master.playerdeta.Coin >= 10000) {
                    levelupwindow.SetActive(true);
                }else if(nowlevel <= 70) {
                    if(Master.playerdeta.KisyounaReikon >= 5 && Master.playerdeta.Reikesseki >= 10 && Master.playerdeta.Reikotu >= 15 && Master.playerdeta.Coin >= 50000) {
                    levelupwindow.SetActive(true);
                    }
                }
                levellow.SetActive(true);
                keikoku.text = "素材が不足しています";
            }
        } else {
            levellow.SetActive(true);
            keikoku.text = "レベルが不足しています";
        }
   }


    void syokika(string i) {
        bool C;
        //レベルが50でかつレベル上限が70の時に多分バグるよ
        //かわいそう
        //直しといて
        //そこの判定をちゃんとする感じでお願いします
        //ごめんなさい
        C=false;
        nowselectover50 = true;
        nowselectover70 = true;
        switch(i) {
            case "Ghost":
                level.text = $"{Master.playerdeta.GhostLevel}";
                if(Master.playerdeta.GhostbreakingThrough1 == false) {
                    levelup.text = "/50";
                    nowselectover50 = false;
                } else if(Master.playerdeta.GhostbreakingThrough2 == false) {
                    levelup.text = "/70";
                    nowselectover70 = false;
                } else {
                    C=true;
                }
                nowlevel = Master.playerdeta.GhostLevel;
                break;
            case "Zashiki_warashi":
                level.text = $"{Master.playerdeta.Zashiki_warashiLevel}";
                if(Master.playerdeta.Zashiki_warashibreakingThrough1 == false) {
                    levelup.text = "/50";
                    nowselectover50 = false;
                } else if(Master.playerdeta.Zashiki_warashibreakingThrough2 == false) {
                    levelup.text = "/70";
                    nowselectover70 = false;
                } else {
                    C = true;
                }
                nowlevel = Master.playerdeta.Zashiki_warashiLevel;
                break;
            case "Gore":
                level.text = $"{Master.playerdeta.GoreLevel}";
                if(Master.playerdeta.GorebreakingThrough1 == false) {
                    levelup.text = "/50";
                    nowselectover50 = false;
                } else if(Master.playerdeta.GorebreakingThrough2 == false) {
                    levelup.text = "/70";
                    nowselectover70 = false;
                } else {
                    C = true;
                }
                nowlevel = Master.playerdeta.GoreLevel;
                break;
            case "Poltergeist":
                level.text = $"{Master.playerdeta.PoltergeistLevel}";
                if(Master.playerdeta.PoltergeistbreakingThrough1 == false) {
                    levelup.text = "/50";
                    nowselectover50 = false;
                } else if(Master.playerdeta.PoltergeistbreakingThrough2 == false) {
                    levelup.text = "/70";
                    nowselectover70 = false;
                } else {
                    C = true;
                }
                nowlevel = Master.playerdeta.PoltergeistLevel;
                break;
            case "Daemon":
                level.text = $"{Master.playerdeta.DaemonLevel}";
                if(Master.playerdeta.DaemonbreakingThrough1 == false) {
                    levelup.text = "/50";
                    nowselectover50 = false;
                } else if(Master.playerdeta.DaemonbreakingThrough2 == false) {
                    levelup.text = "/70";
                    nowselectover70 = false;
                } else {
                    C = true;
                }
                nowlevel = Master.playerdeta.DaemonLevel;
                break;
        }
        if(C == true) {
            level.text = $"{nowlevel}/90";
        }
        if((nowlevel ==50&&nowselectover50 ==false) || (nowlevel == 70&&nowselectover70 == false)) {
            level.color = Color.white;
        } else {
            level.color = Color.red;
        }
=======
    // Start is called before the first frame update
    void Start()
    {
        switch (Master.playerdeta.NowSelectCharactor)
        {
            case "Ghost":
                level.text = $"{Master.playerdeta.GhostLevel}/50";
                break;
            case "Zashiki_warashi":
                level.text = $"{Master.playerdeta.Zashiki_warashiLevel}/50";
                break;
            case "Gore":
                level.text = $"{Master.playerdeta.GoreLevel}/50";
                break;
            case "Poltergeist":
                level.text = $"{Master.playerdeta.PoltergeistLevel}/50";
                break;
            case "Daemon":
                level.text = $"{Master.playerdeta.DaemonLevel}/50"; 
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
>>>>>>> a6ceb9a119109db116ebcae5a9a2088efa6b8b03
    }
}
