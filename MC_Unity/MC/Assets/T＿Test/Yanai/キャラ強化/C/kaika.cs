using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kaika : MonoBehaviour
{
    [SerializeField] GameObject sozaivalue;
    private string SelectC;
    // Start is called before the first frame update
    void Start()
    {
        int wa = Master.playerdeta.GhostPotentialflowering;
        Debug.Log(wa);
        SelectC = Master.playerdeta.NowSelectCharactor;
        switch (SelectC)
        {
            case "Ghost":
                Text Ghosts = sozaivalue.GetComponent<Text>();
                Ghosts.text = $"×{Master.playerdeta.Ghostduplication}";
                break;
            case "Zashiki_warashi":
                Text Zashikis = sozaivalue.GetComponent<Text>();
                Zashikis.text = $"×{Master.playerdeta.Zashiki_warashiduplication}";
                break;
            case "Gore":
                Text Gores = sozaivalue.GetComponent<Text>();
                Gores.text = $"×{Master.playerdeta.goreduplication}";
                break;
            case "Poltergeist":
                Text Poltergeists = sozaivalue.GetComponent<Text>();
                Poltergeists.text = $"×{Master.playerdeta.Poltergeistduplication}";
                break;
            case "Daemon":
                Text Daemons = sozaivalue.GetComponent<Text>();
                Daemons.text = $"×{Master.playerdeta.Daemonduplication}";
                break;
            default:
                Text Daemon = sozaivalue.GetComponent<Text>();
                Daemon.text = "null";
                break;
        }
    }
    void OnClick()
    {
        switch (SelectC)
        {
            case "Ghost":
                if (Master.playerdeta.Ghostduplication >= 1 )
                {
                    //限界突破！！
                }
                break;
            case "Zashiki_warashi":
                if (Master.playerdeta.Zashiki_warashiduplication >= 1)
                {
                    //限界突破！！
                }
                break;
            case "Gore":
                if (Master.playerdeta.goreduplication >= 1)
                {
                    //限界突破！！
                }
                break;
            case "Poltergeist":
                if (Master.playerdeta.Poltergeistduplication >= 1)
                {
                    //限界突破！！
                }
                break;
            case "Daemon":
                if (Master.playerdeta.Daemonduplication >= 1)
                {
                    //限界突破！！
                }
                break;
        }
    }
}
