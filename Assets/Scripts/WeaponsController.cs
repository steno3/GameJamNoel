using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponsController : MonoBehaviour
{
    public List<GameObject> weapons; 
    public int weaponsCount = 0; // 5 armes max ?
    public GameObject snowball;


    public void Start()
    {
        AddWeapon(snowball);
    }

    public void AddWeapon(GameObject weapon)
    {
        weapons.Add(weapon);
        weaponsCount++;
        GameObject spawned = Instantiate(weapon,transform);
        spawned.SetActive(true);
    }

}
