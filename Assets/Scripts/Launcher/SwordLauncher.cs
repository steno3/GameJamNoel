using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SwordLauncher : AbstractWeapons
{
    [SerializeField] GameObject sword;


    protected override void Start()
    {
        cooldown = 5f;
        base.Start();
    }

    protected override void UseWeapon()
    {
        Instantiate(sword, transform);
    }
}
