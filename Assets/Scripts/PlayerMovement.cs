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

    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (!InputDisabled)
        {
            if (_horizontal != 0 && _vertical != 0)
            {
                rb.velocity = new Vector2(_horizontal * moveSpeed / 1.4f, _vertical * moveSpeed / 1.4f);
            }
            else
            {
                rb.velocity = new Vector2(_horizontal * moveSpeed, _vertical * moveSpeed);
            }
        }
    }
}
