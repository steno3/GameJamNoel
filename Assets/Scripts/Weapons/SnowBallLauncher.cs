using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SnowBallLauncher : AbstractWeapons
{
    public Vector2 heading;

    [SerializeField] GameObject snowball;

    protected override void Start()
    {
        cooldown = 3f;
        base.Start();
    }

    protected override void UseWeapon()
    {
        Instantiate(snowball, transform);
    }

}
