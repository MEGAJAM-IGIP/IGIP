using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSystem : MonoBehaviour
{
    public static AudioSystem instance;
    
    private AudioSource audioSource;

    private void Awake()
    {
        if (instance != null) return;
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
