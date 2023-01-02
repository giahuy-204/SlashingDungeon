using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float speed = 3f;
    public float distance;
    private GameObject player;
    private Rigidbody2D rb;
    Animator animator;
    private bool isRight = true;
    public bool isChasing = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        float xVal = player.transform.position.x - transform.position.x;
        if (xVal > 0 && !isRight) {
            Flip();
        }
        if (xVal < 0 && isRight) {
            Flip();
        }
        distance = Vector2.Distance(transform.position, player.transform.position);
        if (distance < 5f)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
            animator.SetBool("isRunning", true);
            isChasing = true;
        } else {
            animator.SetBool("isRunning", false);
            isChasing = false;
        }

    }
    // Update is called once per frame
    void FixedUpdate()
    {

    }

    private void Flip() {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        isRight = !isRight;
    }
}
