using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{

    public float maxSpeed = 10.0f;
    public float speed = 30.0f;
    public float upSpeed = 10.0f;

    Rigidbody2D RigidBody;
    SpriteRenderer spriteRenderer;

    bool onGroundState = false;
    bool onJumpState = false;

    bool moving = false;
    bool faceRightState = true;

    // Start is called before the first frame update
    void Start()
    {
        RigidBody = GetComponentInChildren<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (moving == true)
        {
            MoveHorizontal(faceRightState == true ? 1 : -1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    public void MoveHorizontalCheck(int value)
    {
        if (value == 0)
        {
            moving = false;
        }
        else
        {
            FlipSprite(value);
            moving = true;
            MoveHorizontal(value);
        }
    }

    void MoveHorizontal(int value)
    {
        Vector2 movement = new Vector2(value, 0);
        // check if it doesn't go beyond maxSpeed
        if (MathF.Abs(RigidBody.velocity.x) < maxSpeed)
        {
            RigidBody.AddForce(movement * speed, ForceMode2D.Force);
            Debug.Log("Speedddd");
            Debug.Log(value);
        }
    }

    void FlipSprite(int value)
    {
        if (value == -1 && faceRightState)
        {
            faceRightState = false;
            spriteRenderer.flipX = true;
        }

        else if (value == 1 && !faceRightState)
        {
            faceRightState = true;
            spriteRenderer.flipX = false;
        }
    }

    public void Jump()
    {
        if (onGroundState)
        {
            // jump
            RigidBody.AddForce(Vector2.up * upSpeed, ForceMode2D.Impulse);
            onGroundState = false;
            onJumpState = true;
            // update animator state
            //Animator.SetBool("onGround", onGroundState);

        }
    }

    //Getter Setter
    public bool OnGroundState
    {
        get
        {
            return onGroundState;
        }
        set
        {
            onGroundState = value;
        }
    }

    public void GameRestart()
    {
        onGroundState = false;
        onJumpState = false;

        moving = false;
        faceRightState = true;

        this.transform.position = Vector3.zero;
    }
}
