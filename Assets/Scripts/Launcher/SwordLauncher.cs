using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
using static UnityEngine.GraphicsBuffer;

public class SwordLauncher : AbstractWeapons
{
    [SerializeField] GameObject sword;
    private Vector2 heading;
    private Vector2 mousePosition;


    protected override void Start()
    {
        cooldown = 3f;
        base.Start();
    }

    protected override void UseWeapon()
    {
        /*Camera cam = Camera.main;
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        heading = new Vector2(mousePosition.x - cam.transform.position.x, mousePosition.y - cam.transform.position.y).normalized;
        float angle = Vector2.SignedAngle(Vector2.up, heading);
        Euler*/
        Instantiate(sword, transform);
    }
}
