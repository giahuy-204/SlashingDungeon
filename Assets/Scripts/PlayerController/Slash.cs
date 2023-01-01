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
    public bool isSlashing = false;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }   

    // Update is called once per frame
    void Update()
    {
        questText.text = "Enemies Killed: " + enemiesKilled + "/10";
        if (enemiesKilled == 10)
        {
            questText.text = "<s>Enemies Killed: " + enemiesKilled + "/10</s> <br> Kill Boss";
        }
        if (bossKilled) {
            questText.text = "<s>Enemies Killed: " + enemiesKilled + "/10</s> <br> <s>Kill Boss</s> <br> Exit";
        } 
        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Slashing"))
        {
            isSlashing = true;
        } else {
            isSlashing = false;
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
