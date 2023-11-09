using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int MaxHealth = 100;
    public int Health = 100;

    public List<GameObject> Weapons; // 5 armes max ?

    public void AddWeapon(GameObject weapons)
    {
        Weapons.Add(weapons);
    }
}
