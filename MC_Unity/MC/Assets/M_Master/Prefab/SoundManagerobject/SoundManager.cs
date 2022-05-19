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

    public void Initialize()
    {
        mastervolume = Master.playerdeta.MasterSoundvolume;
        Debug.Log(mastervolume);
        bgmvolume = Master.playerdeta.BGMSoundvolume;
        Debug.Log(bgmvolume);
        voicevolume = Master.playerdeta.VoiceSoundvolume;
        Debug.Log(voicevolume);
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

    public void SetVolume()
    {
        mastervolume = Master.playerdeta.MasterSoundvolume;
        Debug.Log(mastervolume);
        bgmvolume = Master.playerdeta.BGMSoundvolume;
        Debug.Log(bgmvolume);
        voicevolume = Master.playerdeta.VoiceSoundvolume;
        Debug.Log(voicevolume);
        mute = Master.playerdeta.mute;
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
            byte[] data = Encoding.UTF8.GetBytes(item.Key);
            byte[] valuedata = Encoding.UTF8.GetBytes(name);
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
        int index = 0;
        foreach (KeyValuePair<string, int> item in seIndex)
        {
            byte[] data = Encoding.UTF8.GetBytes(item.Key);
            byte[] valuedata = Encoding.UTF8.GetBytes(name);
            StringBuilder datasb = new StringBuilder(20000);
            StringBuilder valuedatasb = new StringBuilder(20000);
            for (int i = 0; i < data.Length; i++)
            {
                datasb.Append(data[i]);
            }
            for (int i = 0; i < valuedata.Length; i++)
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
    public void PlayVoice(int index)
    {
        MuteCheck();
        index = Mathf.Clamp(index, 0, voice.Length);

        voiceAudioSource.clip = voice[index];
        voiceAudioSource.volume = voicevolume * mastervolume;
        voiceAudioSource.Play();
    }

    public void PlayVoiceByName(string name)
    {
        PlayVoice(GetVoiceIndex(name));
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
