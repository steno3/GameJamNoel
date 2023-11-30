using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiesMovement : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] public int MaxHealth = 50;
    public int atk;
    public int dir;
    public int Health = 50;
    public float x=1;
    public float y=1;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        //x>0 vers la droite
        //x<0 vers la gauche
        //y>0 vers le haut
        //y<0 vers le bas
        rb.velocity = (player.transform.position - transform.position).normalized * moveSpeed;
        print(rb.velocity);
    }
   
}
