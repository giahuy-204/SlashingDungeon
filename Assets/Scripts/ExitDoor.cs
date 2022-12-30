using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public GameObject slashing;
    public bool bossKilled;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bossKilled = slashing.GetComponent<Slash>().bossKilled;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(bossKilled)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
