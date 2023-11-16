using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesMovement : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;

    public int MaxHealth = 50;
    public int Health = 50;

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = (player.transform.position - transform.position).normalized * moveSpeed;
    }
}
