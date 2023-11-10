using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FartLauncher : AbstractWeapons
{
    [SerializeField] GameObject elfFart;

    protected override void Start()
    {
        cooldown = 5f;
        base.Start();
    }

    protected override void UseWeapon()
    {
        Instantiate(elfFart, transform);
    }
}
