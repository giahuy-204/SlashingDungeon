using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Slash : MonoBehaviour
{
    public int enemiesKilled = 0;
    public bool bossKilled = false;
    public TMP_Text questText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        questText.text = "Enemies Killed: " + enemiesKilled + "/10";
        if (enemiesKilled == 10)
        {
            //add striketrough for text
            questText.text = "<s>Enemies Killed: " + enemiesKilled + "/10</s> <br> Unlock Door";
        }
        if (bossKilled)
        {
            questText.text = "<s>Enemies Killed: 10/10 </s> <br> <s>Unlock Door</s> <br> <s>Kill Boss</s>";
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemies")
        {
            other.gameObject.SetActive(false);
            enemiesKilled++;
        }
        if(other.gameObject.tag == "Boss")
        {
            other.gameObject.SetActive(false);
            bossKilled = true;
        }
    }
}
