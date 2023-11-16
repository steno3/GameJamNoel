using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Sword : MonoBehaviour
{  
    private Vector2 heading;
    private Vector2 mousePosition;

    public float damage = 30;
    public float lifetime = 2f;
    protected IEnumerator LifeTime(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
       
    }
    void Start()
    {
        StartCoroutine(LifeTime(lifetime));

        Camera cam = Camera.main;
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        heading = new Vector2(mousePosition.x - cam.transform.position.x, mousePosition.y - cam.transform.position.y).normalized;
    }

    void FixedUpdate()
    {
      
    }
}
