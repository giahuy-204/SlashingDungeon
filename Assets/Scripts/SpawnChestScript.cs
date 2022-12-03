using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChestScript : MonoBehaviour
{
    public GameObject sword;
    // Start is called before the first frame update
    void Start()
    {
        // if (sword == null)
        // {
        //     sword = GameObject.FindWithTag("Sword");
        // }
        // sword.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            gameObject.transform.Find("Closed").gameObject.SetActive(false);
            gameObject.transform.Find("Open").gameObject.SetActive(true);
        }
    }
}
