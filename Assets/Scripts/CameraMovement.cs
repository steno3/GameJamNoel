using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] private PlayerMovement target;

    public bool isDead = false;

    void Update()
    {
        if (target is null || isDead) return;

        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10f);
    }
}
