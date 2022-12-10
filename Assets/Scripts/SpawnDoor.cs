using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDoor : MonoBehaviour
{
    public GameObject chest;
    // Start is called before the first frame update
    void Start()
    {
        chest = GameObject.FindWithTag("Chest");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(chest.GetComponent<SpawnChestScript>().isCollided)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
