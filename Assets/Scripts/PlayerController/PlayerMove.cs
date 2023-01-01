using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float MoveSpeed = 10f;

    private Vector2 movement;
    private new Rigidbody2D rigidbody;
    private SpriteRenderer spriteRenderer;
    public Vector3 oldPos;
    public Quaternion oldRot;
    private bool isRight = true;
    public GameObject slashing;
    public bool isSlashing = false;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        float xVal = Input.GetAxisRaw("Horizontal") * Time.deltaTime * MoveSpeed;
        isSlashing = slashing.GetComponent<Slash>().isSlashing;
        if (!isSlashing) {
            if (xVal > 0 && !isRight) {
                Flip();
            }
            if (xVal < 0 && isRight) {
                Flip();
            }
        }
        var Horizontal = Input.GetAxis("Horizontal");
        var Vertical = Input.GetAxis("Vertical");

        if (Horizontal != 0 && Vertical == 0) {
            rigidbody.velocity = new Vector2(Horizontal * MoveSpeed, rigidbody.velocity.y);
        }
        else if (Vertical != 0 && Horizontal == 0) {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, Vertical * MoveSpeed);
        } 
        else if (Vertical != 0 && Horizontal != 0)
        {
            rigidbody.velocity = new Vector2(Horizontal * MoveSpeed, Vertical * MoveSpeed);
        }
    }

    private void LateUpdate() {
        // Vector3 moveDirection = oldRot * (transform.position - oldPos);
        // //check if character is moving
        // if (moveDirection.magnitude > 0.01f) {
        //     if(moveDirection.x > 0) {
        //         spriteRenderer.flipX = false;
        //     } else if(moveDirection.x < 0) {
        //         spriteRenderer.flipX = true;
        //     }
        // }

        // oldPos = transform.position;
        // oldRot = transform.rotation;
    }

    private void Flip() {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        isRight = !isRight;
    }
}