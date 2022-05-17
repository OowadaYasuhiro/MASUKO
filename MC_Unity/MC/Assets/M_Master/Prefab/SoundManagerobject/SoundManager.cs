using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    AudioClip[] bgm;
    [SerializeField]
    AudioClip[] se;
    [SerializeField]
    AudioClip[] voice;

    [SerializeField]
    AudioSource bgmAudioSource;
    [SerializeField]
    AudioSource seAudioSource;
    [SerializeField]
    AudioSource voiceAudioSource;

    private float mastervolume;
    private float bgmvolume;
    private float voicevolume;

    bool mute;

    Dictionary<string, int> bgmIndex = new Dictionary<string, int>();
    Dictionary<string, int> seIndex = new Dictionary<string, int>();
    Dictionary<string, int> voiceIndex = new Dictionary<string, int>();

    private void Start()
    {
        mastervolume = Master.playerdeta.MasterSoundvolume;
        bgmvolume = Master.playerdeta.BGMSoundvolume;
        voicevolume = Master.playerdeta.VoiceSoundvolume;
        mute = Master.playerdeta.mute;
        MuteCheck();
        if (!(bgm.Length == 0))
        {
            try
            {
                for (int i = 0; i < bgm.Length; i++)
                {
                    bgmIndex.Add(bgm[i].name, i);
                }
            }
            catch
            {
                Debug.LogError("インスペクター上のオーディオクリップ(BGM)配列サイズが挿入した以上になっています、余分を配列サイズから引いてください。");
            }
            
        }
        if (!(se.Length == 0))
        {
            try
            {
                for (int i = 0; i < se.Length; i++)
                {
                    seIndex.Add(se[i].name, i);
                }
            }
            catch
            {
                Debug.LogError("インスペクター上のオーディオクリップ(BGM)配列サイズが挿入した以上になっています、余分を配列サイズから引いてください。");
            }
        }
        if (!(voice.Length == 0))
        {
            try
            {
                for (int i = 0; i < voice.Length; i++)
                {
                    voiceIndex.Add(voice[i].name, i);
                }
            }
            catch
            {
                Debug.LogError("インスペクター上のオーディオクリップ(BGM)配列サイズが挿入した以上になっています、余分を配列サイズから引いてください。");
            }
        }
    }

    public int  GetBgmIndex(string name)
    {
        if (bgmIndex.ContainsKey(name))
        {
            return bgmIndex[name];
        }
        else
        {
            Debug.LogError("指定された名前のBGMファイルが存在しません。");
            return 0;
        }
    }
    public int GetSEIndex(string name)
    {
        int index = 0;
        foreach(KeyValuePair<string,int> item in seIndex)
        {
            Debug.Log(item.Key);
            Debug.Log(name);
            /*if (item.Key.Equals("name"))
            {
                index = item.Value;
            }
            else
            {
                Debug.LogError("指定された名前のSEファイルが存在しません。");
                Debug.LogError("わざとエラーを出します");
                index = -1;
            }*/
            byte[] data = Encoding.UTF8.GetBytes(item.Key);
            byte[] valuedata = Encoding.UTF8.GetBytes(name);
            Debug.Log(data[0]);
            Debug.Log(data.Length);
            Debug.Log(valuedata[0]);
            Debug.Log(valuedata.Length);
            StringBuilder datasb = new StringBuilder(20000);
            StringBuilder valuedatasb = new StringBuilder(20000);
            for (int i = 0;i < data.Length; i++)
            {
                datasb.Append(data[i]);
            }
            for (int i = 0;i < valuedata.Length; i++)
            {
                valuedatasb.Append(valuedata[i]);
            }
            
            if (datasb.Equals(valuedatasb))
            {
                index = item.Value;
            }
            else
            {
                Debug.LogError("指定された名前のSEファイルが存在しません。");
                Debug.LogError("わざとエラーを出します");
                index = -1;
            }
        }
        return index;
    }
    public int GetVoiceIndex(string name)
    {
        if (voiceIndex.ContainsKey(name))
        {
            return voiceIndex[name];
        }
        else
        {
            Debug.LogError("指定された名前のVOICEファイルが存在しません。");
            return 0;
        }
    }

    //BGM再生
    public void PlayBgm(int index)
    {
        MuteCheck();
        index = Mathf.Clamp(index, 0, bgm.Length);

        bgmAudioSource.clip = bgm[index];
        bgmAudioSource.loop = true;
        bgmAudioSource.volume = bgmvolume * mastervolume;
        bgmAudioSource.Play();
    }
    public void PlayBgmByName(string name)
    {
        PlayBgm(GetBgmIndex(name));
    }
    //BGM停止
    public void StopBgm()
    {
        bgmAudioSource.Stop();
        bgmAudioSource.clip = null;
    }

    //SE再生
    public void PlaySe(int index)
    {
        MuteCheck();
        index = Mathf.Clamp(index, 0, se.Length);

        seAudioSource.PlayOneShot(se[index], mastervolume);
    }
    public void PlaySeByName(string name)
    {
        PlaySe(GetSEIndex(name));
    }
    public void StopSe()
    {
        seAudioSource.Stop();
        seAudioSource.clip = null;
    }

    //ボイス再生
    public void playVoice(int index)
    {
        MuteCheck();
        index = Mathf.Clamp(index, 0, voice.Length);

        voiceAudioSource.clip = bgm[index];
        voiceAudioSource.volume = voicevolume * mastervolume;
        voiceAudioSource.Play();
    }

    public void playVoiceByName(string name)
    {
        playVoice(GetVoiceIndex(name));
    }

    public void MuteCheck()
    {
        if (mute)
        {
            bgmAudioSource.mute = true;
            seAudioSource.mute = true;
            voiceAudioSource.mute = true;
        }
        else
        {
            bgmAudioSource.mute = false;
            seAudioSource.mute = false;
            voiceAudioSource.mute = false;
        }
    }

}
