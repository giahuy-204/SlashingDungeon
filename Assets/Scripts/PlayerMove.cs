using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float MoveSpeed = 5f;

    private Vector2 movement;
    private new Rigidbody2D rigidbody;
    private SpriteRenderer spriteRenderer;
    public Vector3 oldPos;
    public Quaternion oldRot;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (movement.x > 0)
        {
            spriteRenderer.flipX = false;
        }
    }

    public void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + movement.normalized * MoveSpeed * Time.fixedDeltaTime);    
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
}
