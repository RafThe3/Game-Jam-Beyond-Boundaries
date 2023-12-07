using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementSFX : MonoBehaviour
{
    [Header("Audio Clips")]
    [SerializeField] private AudioClip[] audioClips;
    [SerializeField] private AudioSource audioSource;

    //Internal Variables
    private Player player;
    private int song = 0;
    private float songLength = 0;

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    private void Update()
    {
        if (player.isMoving)
        {
            PlayNextSFX();
        }
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

        audioSource.PlayOneShot(audioClips[song]);
        songLength = 0;
    }
}
