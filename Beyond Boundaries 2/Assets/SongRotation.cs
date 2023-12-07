using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongRotation : MonoBehaviour
{
    [Header("Audio Clips")]
    [SerializeField] private AudioClip[] audioClips;
    [SerializeField] private AudioSource audioSource;

    //Internal Variables
    private int song = 0;
    private float songLength = 0;

    private void Start()
    {
        audioSource.PlayOneShot(audioClips[0]);
    }

    private void Update()
    {
        PlayNextSFX();
    }

    private void PlayNextSFX()
    {
        songLength += Time.deltaTime;

        if (songLength < audioClips[song].length || song == audioClips.Length)
        {
            return;
        }

        if (song < audioClips.Length - 1)
        {
            song++;
        }
        else
        {
            song = 0;
        }
        audioSource.Stop();
        audioSource.PlayOneShot(audioClips[song]);
        songLength = 0;
    }
}
