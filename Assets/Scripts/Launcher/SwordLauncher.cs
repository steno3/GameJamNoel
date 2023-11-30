using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
using static UnityEngine.GraphicsBuffer;

public class SwordLauncher : AbstractWeapons
{
    [SerializeField] GameObject sword;


    protected override void Start()
    {
        cooldown = 3f;
        base.Start();
    }

    protected override void UseWeapon()
    {
        Instantiate(sword, transform);
    }
}
