using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(LoadSceneAfterDelay());
        }
    }

    public IEnumerator LoadSceneAfterDelay() {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(currentScene + 1);
    }
}
