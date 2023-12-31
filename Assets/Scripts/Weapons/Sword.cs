using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;

public class Sword : MonoBehaviour
{
    private Vector2 heading;
    private Vector2 mousePosition;
    private float distSwordToPlayer = 1.5f;

    [SerializeField] Rigidbody2D rb;

    public float damage = 30;
    public float lifetime = 2f;
    protected IEnumerator LifeTime(float time)
    {
        yield return new WaitForSeconds(time);
       Destroy(gameObject);
       
    }

    IEnumerator Start()
    {
        StartCoroutine(LifeTime(lifetime));
        Camera cam = Camera.main;
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        heading = new Vector2(mousePosition.x - cam.transform.position.x, mousePosition.y - cam.transform.position.y).normalized;
        float angle = Vector2.SignedAngle(Vector2.up, heading);
        rb.MoveRotation(angle);
        transform.position = transform.position + new Vector3(heading.x, heading.y, 0) * distSwordToPlayer;

        yield return new WaitForFixedUpdate();
        GetComponent<SpriteRenderer>().enabled = true;
    }

    void FixedUpdate()
    {

    }
}
