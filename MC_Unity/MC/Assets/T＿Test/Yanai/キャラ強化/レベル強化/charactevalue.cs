using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charactevalue : MonoBehaviour
{
    [SerializeField] Text HP;
    [SerializeField] Text Atk;
    [SerializeField] Text Def;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (Master.playerdeta.NowSelectCharactor)
        {
            case "Ghost":
                //Lv.text = $"Lv {Master.playerdeta.GhostLevel}";
                HP.text = $"{hairetu.GhostHP[Master.playerdeta.GhostLevel]}";
                Atk.text = $"{hairetu.GhostAtk[Master.playerdeta.GhostLevel]}";
                Def.text = $"{hairetu.GhostDef[Master.playerdeta.GhostLevel]}";
                break;
            case "Zashiki_warashi":
               // Lv.text = $"Lv {Master.playerdeta.Zashiki_warashiLevel}";
                HP.text = $"{hairetu.ZasikiHP[Master.playerdeta.Zashiki_warashiLevel]}";
                Atk.text = $"{hairetu.ZasikiAtk[Master.playerdeta.Zashiki_warashiLevel]}";
                Def.text = $"{hairetu.ZasikiDef[Master.playerdeta.Zashiki_warashiLevel]}";
                break;
            case "Gore":
              //  Lv.text = $"Lv {Master.playerdeta.GoreLevel}";
                HP.text = $"{hairetu.GoreHP[Master.playerdeta.GoreLevel]}";
                Atk.text = $"{hairetu.GoreAtk[Master.playerdeta.GoreLevel]}";
                Def.text = $"{hairetu.GoreDef[Master.playerdeta.GoreLevel]}";
                break;
            case "Poltergeist":
              //  Lv.text = $"Lv {Master.playerdeta.PoltergeistLevel}";
                HP.text = $"{hairetu.PorutaHP[Master.playerdeta.PoltergeistLevel]}";
                Atk.text = $"{hairetu.PorutaAtk[Master.playerdeta.PoltergeistLevel]}";
                Def.text = $"{hairetu.PorutaDef[Master.playerdeta.PoltergeistLevel]}";
                break;
            case "Daemon":
              //  Lv.text = $"Lv {Master.playerdeta.DaemonLevel}";
                HP.text = $"{hairetu.DEmonHP[Master.playerdeta.DaemonLevel]}";
                Atk.text = $"{hairetu.DEmonAtk[Master.playerdeta.DaemonLevel]}";
                Def.text = $"{hairetu.DEmonDef[Master.playerdeta.DaemonLevel]}";
                break;
        }
    }
}
