using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    public int enemiesKilled = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = new Vector3 (player.position.x + offset.x, player.position.y + offset.y, offset.z);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemies")
        {
            other.gameObject.SetActive(false);
            enemiesKilled++;
        }
    }
}
