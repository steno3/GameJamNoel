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
        animator.SetFloat("horizontal", _horizontal);
        animator.SetBool("idle", false);
        if (_horizontal == 0)
        {
            animator.SetFloat("vertical", _vertical);
            if (_vertical == 0)
            {
                animator.SetBool("idle", true);
            }
        }
        else
        {
            animator.SetFloat("vertical", 0);
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
