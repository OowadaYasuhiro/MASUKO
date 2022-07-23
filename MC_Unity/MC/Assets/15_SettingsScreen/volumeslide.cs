using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class volumeslide : MonoBehaviour
{
    [SerializeField] Slider masterSlider;
    [SerializeField] Slider BGMSlider;
    [SerializeField] Slider voiceSlider;
    [SerializeField] GameObject batu;
    // Start is called before the first frame update
    void OnEnable()
    {
        Master.playerdeta.MasterSoundvolume =masterSlider.value;
        Master.playerdeta.BGMSoundvolume    = BGMSlider.value;
        Master.playerdeta.VoiceSoundvolume = voiceSlider.value ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick() {
        if(Master.playerdeta.mute == true) {
            Master.playerdeta.mute = false;
        } else {
            Master.playerdeta.mute = true;
        }
    }

    public void masterS() {
        Master.playerdeta.MasterSoundvolume = masterSlider.value;
    }

    public void BGMS() {
        Master.playerdeta.BGMSoundvolume = BGMSlider.value;
    }

    public void VoiceS() {
        Master.playerdeta.VoiceSoundvolume = voiceSlider.value;
    }

    public void tiltel() {
        Load_Deta.Nextscenename = "titlescene";
        SceneManager.LoadScene("Yanai_TestScene");
    }

    public void baticlick() {
        batu.SetActive(false);
    }
}
