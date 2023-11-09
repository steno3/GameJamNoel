using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SnowBallLauncher : AbstractWeapons
{
    private Vector2 mousePosition;
    public Vector2 heading;

    [SerializeField] GameObject player;
    [SerializeField] GameObject snowball;

    protected override void Start()
    {
        cooldown = 3f;
        base.Start();
    }

    protected override void UseWeapon()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        heading = new Vector2(mousePosition.x - player.transform.position.x, mousePosition.y - player.transform.position.y).normalized;
        Debug.Log(heading);
        Instantiate(snowball, transform);
    }

}
