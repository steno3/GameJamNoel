using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class SnowBall : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 heading;
    private Vector2 mousePosition;

    public float moveSpeed = 5;
    public float damage = 10;
    public float lifetime = 5f;

    protected IEnumerator LifeTime(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
        //Debug.Log("destroyed");
    }
    void Start()
    {
        StartCoroutine(LifeTime(lifetime));

        rb = GetComponent<Rigidbody2D>();
        Camera cam = Camera.main;
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        heading = new Vector2(mousePosition.x - cam.transform.position.x, mousePosition.y - cam.transform.position.y).normalized;
    }

    void FixedUpdate()
    {
        rb.velocity = heading * moveSpeed;
    }
}
