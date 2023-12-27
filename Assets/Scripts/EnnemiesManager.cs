using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class EnnemiesManager : MonoBehaviour
{

    private int ennemyCount = 0;
    private Transform pos;

    [SerializeField] protected List<GameObject> ennemyPrefabs_1;
    [SerializeField] protected List<GameObject> ennemyPrefabs_2;
    [SerializeField] protected List<GameObject> ennemyPrefabs_3;
    [SerializeField] protected GameObject ennemyBoss;

    public float cooldown = 3f;

    void Start()
    {
        Debug.Log("EnnemiesManager.Start");
        StartCoroutine(LoopSpawn());
    }

    void SpawnEnnemy()
    {
        Debug.Log("EnnemiesManager.SpawnEnnemy");
     
        Vector3 camPos = Camera.main.transform.position;
        pos.position = new Vector3(Random.Range(camPos.x - 10, camPos.x + 10), Random.Range(camPos.y - 10, camPos.y + 10), 0);
        Debug.Log(pos.position);

        if (ennemyCount < 100)
        {
            ennemyCount++;
            if (ennemyCount % 10 == 0)
            {
                Instantiate(ennemyPrefabs_2[Random.Range(0, ennemyPrefabs_2.Count)], pos);
            }
            else
            {
                Instantiate(ennemyPrefabs_1[Random.Range(0, ennemyPrefabs_1.Count)], pos);
            }
        }
        else if (ennemyCount < 200)
        {
            ennemyCount++;
            if (ennemyCount % 10 == 0)
            {
                Instantiate(ennemyPrefabs_3[Random.Range(0, ennemyPrefabs_3.Count)], pos);
            }
            else
            {
                Instantiate(ennemyPrefabs_2[Random.Range(0, ennemyPrefabs_2.Count)], pos);
            }
        }
        else
        {
            ennemyCount++;
            if (ennemyCount % 250 == 0)
            {
                cooldown = cooldown * 0.9f;
                Instantiate(ennemyPrefabs_3[Random.Range(0, ennemyPrefabs_3.Count)], pos);
            }
            else
            {
                Instantiate(ennemyBoss, pos);
            }
        }
    }

    protected IEnumerator LoopSpawn()
    {
        while (true)
        {
            SpawnEnnemy();
            yield return new WaitForSeconds(cooldown);
        }
    }
}
