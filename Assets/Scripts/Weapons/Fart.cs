using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fart : MonoBehaviour
{

    public float damage = 20;
    public float size = 1;
    public float range; // sert à calculer la distance aux ennemis
    public float lifetime = 3f;

    protected IEnumerator LifeTime(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

    void Start()
    {
        StartCoroutine(LifeTime(lifetime));

        range = 32 * size;
        gameObject.transform.localScale = new Vector3(size,size,size);
    }

    void Update()
    {
        // tester la distance aux ennemis (range*size)
    }
}
