using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class AbstractWeapons : MonoBehaviour
{
    protected float cooldown;

    protected virtual void Start()
    {
        Debug.Log("start ");
        StartCoroutine(LoopWeapon());
    }

    protected abstract void UseWeapon();

    protected IEnumerator LoopWeapon()
    {
        while (true)
        {
            UseWeapon();
            yield return new WaitForSeconds(cooldown);
        }
    }
}
