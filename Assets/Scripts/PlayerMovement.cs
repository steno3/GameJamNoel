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

    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (!InputDisabled)
        {
                rb.velocity = new Vector2(_horizontal, _vertical).normalized * moveSpeed;
            
        }
    }
}
