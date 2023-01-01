using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConditionDoors : MonoBehaviour
{
    public GameObject slashing;
    public TMP_Text questText;
    public int enemiesKilled;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        enemiesKilled = slashing.GetComponent<Slash>().enemiesKilled;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(enemiesKilled == 10)
            {
                gameObject.SetActive(false);
                questText.text = "<s>Enemies Killed: " + enemiesKilled + "/10</s> <br> <s>Unlock Door</s> <br> Kill Boss";
            }
        }
    }
}
