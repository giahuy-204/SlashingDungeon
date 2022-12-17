using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionDoors : MonoBehaviour
{
    public GameObject slash;
    // Start is called before the first frame update
    void Start()
    {
        slash = GameObject.FindWithTag("Slashing");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(slash.GetComponent<Slash>().enemiesKilled == 3)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
