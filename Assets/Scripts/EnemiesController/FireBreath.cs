using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBreath : MonoBehaviour
{
    private bool isChasing = false;
    public GameObject boss;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isChasing = boss.GetComponent<Boss>().isChasing;
        if (isChasing) {
            animator.SetBool("isChasing", true);
        } else {
            animator.SetBool("isChasing", false);
        }
    }
}
