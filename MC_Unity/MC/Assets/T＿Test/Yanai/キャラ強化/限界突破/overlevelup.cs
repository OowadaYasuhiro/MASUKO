using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class overlevelup : MonoBehaviour
{
    [SerializeField] Text level;
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
        
    }
}
