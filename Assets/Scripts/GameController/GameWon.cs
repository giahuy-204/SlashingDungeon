using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameWon : MonoBehaviour
{
    public Button mainMenuButton;
    // Start is called before the first frame update
    void Start()
    {
        mainMenuButton.onClick.AddListener(() => {
            SceneManager.LoadScene("MainMenu");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
