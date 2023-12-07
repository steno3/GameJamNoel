using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _horizontal;
    private float _vertical;
    private bool InputDisabled;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Animator animator;

    public int MaxHealth = 100;
    public int Health = 100;

    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");

        // les animations
        if (Time.timeScale != 0f)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                animator.SetTrigger("Up");
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                animator.SetTrigger("Down");
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                animator.SetTrigger("Left");
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                animator.SetTrigger("Right");
            }

            if (_horizontal == 0 && _vertical == 0)
            {
                animator.SetBool("Idle", true);
            }
            else
            {
                animator.SetBool("Idle", false);
            }
        }
    }

    private void FixedUpdate()
    {
        if (!InputDisabled)
        {
            rb.velocity = new Vector2(_horizontal, _vertical).normalized * moveSpeed;
        }
    }
}
