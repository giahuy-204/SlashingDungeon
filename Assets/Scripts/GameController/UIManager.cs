using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Button btnPlay;
    public Button btnSettings;
    public Button btnExit;
    public Button settingsDone;
    public Canvas canvasSettings;
    public Canvas canvasMain;
    public Slider musicVolume;
    public Slider soundVolume;

    void Awake() {
        btnPlay.onClick.AddListener(onClickPlay);
        btnSettings.onClick.AddListener(onClickSettings);
        btnExit.onClick.AddListener(onClickExit);
    }

    void Start()
    {
        PlayerPrefs.SetInt("slashing", 0);
        PlayerPrefs.SetInt("hitting", 0);
        PlayerPrefs.SetInt("healing", 0);
        PlayerPrefs.SetInt("beingHit", 0);
        PlayerPrefs.SetInt("dying", 0);
    }

    public void onClickPlay()
    {
        SceneManager.LoadScene("SpawnRoom");
    }
    
    public void onClickSettings()
    {
        canvasSettings.gameObject.SetActive(true);
        if (canvasSettings.sortingOrder == 1)
        {
            btnPlay.interactable = false;
            btnSettings.interactable = false;
            btnExit.interactable = false;
        }
        settingsDone.onClick.AddListener(onClickSettingsDone);
        canvasMain.gameObject.SetActive(false);
    }

    public void onClickSettingsDone() {
        canvasSettings.gameObject.SetActive(false);
        if (canvasSettings.sortingOrder == 0)
        {
            btnPlay.interactable = true;
            btnSettings.interactable = true;
            btnExit.interactable = true;
        }
        PlayerPrefs.SetFloat("soundVolume", soundVolume.value);
        PlayerPrefs.SetFloat("musicVolume", musicVolume.value);
        AudioListener.volume = musicVolume.value;
        settingsDone.onClick.RemoveListener(onClickSettingsDone);
        canvasMain.gameObject.SetActive(true);
    }

    public void onClickExit()
    {
        Application.Quit();
    }

    void Update()
    {
        
    }

    private void OnDestroy() {
        btnPlay.onClick.RemoveListener(onClickPlay);
        btnSettings.onClick.RemoveListener(onClickSettings);
        btnExit.onClick.RemoveListener(onClickExit);
    }
}
