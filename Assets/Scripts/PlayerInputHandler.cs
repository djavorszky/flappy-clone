using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    [Range(5.0f, 15.0f)]
    public float flapForce = 10f;

    [Range(5.0f, 15.0f)]
    public float maxVerticalSpeed = 10f;

    private Rigidbody2D rb;

    private bool isJumpPressed = false;


    private void Start() => rb = gameObject.GetComponent<Rigidbody2D>();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumpPressed = true;
        }
    }

    private void FixedUpdate()
    {
        if (isJumpPressed)
        {
            rb.velocity = GetJumpVelocity();
            isJumpPressed = false;
        }
    }

    private Vector2 GetJumpVelocity()
    {
        return Vector2.ClampMagnitude(rb.velocity + Vector2.up * flapForce, maxVerticalSpeed);
    }
}
