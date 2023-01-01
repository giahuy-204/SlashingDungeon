using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChestScript : MonoBehaviour
{
    public GameObject sword;
    public bool isCollided = false;
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
            gameObject.transform.Find("Closed").gameObject.SetActive(false);
            gameObject.transform.Find("Open").gameObject.SetActive(true);
            sword.SetActive(true);
        }
        //disable box collider
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
        //collided
        isCollided = true;
    }
}
