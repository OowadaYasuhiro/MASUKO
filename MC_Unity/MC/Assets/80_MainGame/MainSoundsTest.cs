using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSoundsTest : MonoBehaviour
{
    GameObject sm;
    [SerializeField]
    GameObject tti;
    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("SoundManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Master.playerdeta.MasterSoundvolume = 1f;
            Master.playerdeta.BGMSoundvolume = 1f;
            Master.playerdeta.VoiceSoundvolume = 1f;
            sm.GetComponent("SoundManager").GetComponent<SoundManager>().SetVolume();
            Master.formationdeta.SetSelectCharacter1(new Charactor("Test"));
            Master.saveManager.DetaSave();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            sm.SendMessage("PlayVoiceByName", "ログイン");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            sm.SendMessage("PlayBgmByName", "bgm_リザルト画面");
        }
        if (TakesantestInput.Touchbegan)
        {
            Player p = new Player(1);
            Enemy e = new Enemy("b");
            StartCoroutine( new MainGameSkillEvent().DoSkillEvent(e,1,1,p.skillEvent1));
        }
    }
}
