using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro:

public class HealthPlayerController : MonoBehaviour
{

    // Health et MaxHealth déclaré public dans PlayerMovement

    public float MaxHealth = 100f;
    public float Health = 100f;

    public Image HealthBar;
    public TextMeshProUGUI HealthText;


    // Update is called once per frame
    void Update()
    {
        HealthBar.fillAmount = Health / MaxHealth;
        HealthText.text = Health + " / " + MaxHealth;
        Health = Mathf.Clamp(Health, 0f, MaxHealth);

        /*Fait la même chose que
         * if Health > MaxHealth 
         *      Health = MaxHealth
         * else if Health <0 
         *         Health = 0f;
         */
    }

    void DamageEnnemies(int damage)
    {
        Health -= damage;
    }

    void HealPlayer(int heal)
    {
        Health += heal;
    }


}
