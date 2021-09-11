using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOfHandle : MonoBehaviour
{
    AudioSource audioSource;
    
    public float FadeOutSeconds = 1.0f;
    public float FadeInSeconds = 1.0f;
    bool IsFadeOut = true;
    bool IsFadeIn = true;
    float FadeOutDeltaTime = 0;
    float FadeInDeltaTime = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        FadeOut();
    }

    public void PlaySoundIfNotPlaying(AudioClip source, bool fadeIn,bool fadeOut)
    {
  
        if (audioSource.isPlaying==false)
        {
            IsFadeOut = fadeOut;
            IsFadeIn = fadeIn;
            audioSource.clip = source;
            audioSource.Play();
        }
    }

    void FadeOut()
    {
        if (IsFadeOut)
        {
            FadeOutDeltaTime += Time.deltaTime;
            if (FadeOutDeltaTime >= FadeOutSeconds)
            {
                FadeOutDeltaTime = 0;
                IsFadeOut = false;
            }
            audioSource.volume = (float)(1.0 - FadeOutDeltaTime / FadeOutSeconds);
        }
    }
    void FadeIn()
    {
        if (IsFadeIn)
        {
            FadeInDeltaTime += Time.deltaTime;
            if (FadeInDeltaTime >= FadeInSeconds)
            {
                FadeInDeltaTime = 0;
                IsFadeIn = false;
            }
            audioSource.volume = (float)( FadeInDeltaTime / FadeInSeconds);
        }
    }

    public void StopSound()
    {
        if (IsFadeOut == true)
        {
            IsFadeOut = false;
            Invoke("StopSound", FadeOutSeconds);
        }
        audioSource.Stop();
    }
}
