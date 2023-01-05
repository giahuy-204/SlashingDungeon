using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    Animator animator;
    private bool isAttacking = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.SetInt("slashing", 1);
            isAttacking = true;
            animator.SetBool("isAttacking", isAttacking);
        }
        else
        {
            isAttacking = false;
            animator.SetBool("isAttacking", isAttacking);
        }
    }
}
