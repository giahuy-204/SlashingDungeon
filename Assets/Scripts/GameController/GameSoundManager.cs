using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSoundManager : MonoBehaviour
{
    //audio source
    public AudioSource musicVolume;
    public AudioSource soundVolume;
    public float musicVolumeValue;
    public float soundVolumeValue;

    public AudioClip slashSound;
    public AudioClip hitSound;
    public AudioClip healSound;
    public AudioClip beingHitSound;
    public AudioClip deathSound;

    public int slashing;
    public int hitting;
    public int healing;
    public int beingHit;
    public int dying;

    void Awake() {
        musicVolumeValue = PlayerPrefs.GetFloat("musicVolume");
        soundVolumeValue = PlayerPrefs.GetFloat("soundVolume");
    }

    void Start()
    {
        musicVolume.volume = musicVolumeValue;
        soundVolume.volume = soundVolumeValue;

        DontDestroyOnLoad(musicVolume);
    }

    void Update()
    {
        slashing = PlayerPrefs.GetInt("slashing");
        hitting = PlayerPrefs.GetInt("hitting");
        healing = PlayerPrefs.GetInt("healing");
        beingHit = PlayerPrefs.GetInt("beingHit");
        dying = PlayerPrefs.GetInt("dying");

        if (slashing == 1)
        {
            soundVolume.PlayOneShot(slashSound);
            PlayerPrefs.SetInt("slashing", 0);
        }
        if (hitting == 1)
        {
            soundVolume.PlayOneShot(hitSound);
            PlayerPrefs.SetInt("hitting", 0);
        }
        if (healing == 1)
        {
            soundVolume.PlayOneShot(healSound);
            PlayerPrefs.SetInt("healing", 0);
        }
        if (beingHit == 1)
        {
            soundVolume.PlayOneShot(beingHitSound);
            PlayerPrefs.SetInt("beingHit", 0);
        }
        if (dying == 1)
        {
            soundVolume.PlayOneShot(deathSound);
            PlayerPrefs.SetInt("dying", 0);
        }
    }
}
