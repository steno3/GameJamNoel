using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class SnowBall : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 heading;
    private Vector2 mousePosition;

    public float moveSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        heading = GetComponentInParent<SnowBallLauncher>().heading;
        Camera cam = Camera.main;
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        heading = new Vector2(mousePosition.x - cam.transform.position.x, mousePosition.y - cam.transform.position.y).normalized;
    }

    void FixedUpdate()
    {
        rb.velocity = heading * moveSpeed;
    }
}
