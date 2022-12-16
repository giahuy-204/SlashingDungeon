using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        // player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // gameObject.transform.position = player.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemies")
        {
            other.gameObject.SetActive(false);
        }
    }
}
