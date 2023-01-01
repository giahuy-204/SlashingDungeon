using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Button btnRetry;
    public Button btnMenu;

    void Awake() {
        btnRetry.onClick.AddListener(onClickRetry);
        btnMenu.onClick.AddListener(onClickMenu);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickRetry()
    {
        //load scene
        SceneManager.LoadScene("SpawnRoom");
    }

    public void onClickMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void OnDestroy() {
        btnRetry.onClick.RemoveListener(onClickRetry);
        btnMenu.onClick.RemoveListener(onClickMenu);
    }
}
