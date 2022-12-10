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
    public Slider sliderVolume;

    void Awake() {
        btnPlay.onClick.AddListener(onClickPlay);
        btnSettings.onClick.AddListener(onClickSettings);
        btnExit.onClick.AddListener(onClickExit);
    }

    void Start()
    {
        bool isSound = PlayerPrefs.GetFloat("volume") == 1 ? true : false;
        float volume = PlayerPrefs.GetFloat("volume");
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
        PlayerPrefs.SetFloat("volume", sliderVolume.value);
        AudioListener.volume = sliderVolume.value;
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
