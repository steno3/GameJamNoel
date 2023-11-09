using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class SnowBall : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 heading;

    public float moveSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        heading = GetComponentInParent<SnowBallLauncher>().heading;
    }

    void FixedUpdate()
    {
        rb.velocity = heading * moveSpeed;
    }
}
