using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakesanTestAudio : MonoBehaviour
{
    [SerializeField] AudioClip[] audioClips;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume  = Takesantestmaster.audiovolume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setingaudiovolume(float value)
    {
        audioSource.volume = value;
    }
}
