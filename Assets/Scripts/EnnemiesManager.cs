using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnnemiesManager : MonoBehaviour
{

    public float cooldown = 3f;

    void Start()
    {
        Debug.Log("EnnemiesManager.Start");
        StartCoroutine(LoopSpawn());
    }

    void SpawnEnnemy()
    {
        Debug.Log("EnnemiesManager.SpawnEnnemy");
    }

    protected IEnumerator LoopSpawn()
    {
        while (true)
        {
            SpawnEnnemy();
            yield return new WaitForSeconds(cooldown);
        }
    }

    void Update()
    {
        
    }
}
