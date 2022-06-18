using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masterhensytuu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Master.playerdeta.GhostbreakingThrough1 = true;
        Master.playerdeta.GhostbreakingThrough2 = false;
        Master.playerdeta.GhostSkill1Level = 1;
        Master.playerdeta.NowSelectCharactor = "Daemon";
        Master.playerdeta.MagaTamashi = 100000;
        Master.playerdeta.Zanryu_Sinen = 100000;
        Master.playerdeta.Coin = 1000000;
        Master.playerdeta.GhostUnLocked = true;
        Master.playerdeta.GhostLevel = 70;
        Master.playerdeta.KisyounaReikon = 100;
        //霊結石
        Master.playerdeta.Reikesseki=100;
        //霊骨
        Master.playerdeta.Reikotu=100;
        Master.playerdeta.Kosyo=100;
        //遺骨
        Master.playerdeta.Ikotu=100;
        //人間の血
        Master.playerdeta.Ningennnoti=100;
        //信頼度
        Master.playerdeta.GhostCredibility = 210;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
