using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class XPManager : MonoBehaviour
{
    public float XP = 0;
    public float MaxXP = 100; // C'est l'XP max avant de passer au prochain niveau
    public int Niveau = 1;
    public float rateXP =2; //Multipllie MaxXp à chaque passage de niveau 

    public Image XPBar;
    public TextMeshProUGUI XPText;
    public TextMeshProUGUI LVText;

    // Start is called before the first frame update
    void Start()
    {
        LVText.text = "LV : " + Niveau;
    }

    // Update is called once per frame
    void Update()
    {
        if (XP >= MaxXP)
        {
            float reste = XP - MaxXP;
            Niveau += 1;
            LVText.text = "LV : " + Niveau;
            XP = reste;
            MaxXP = MaxXP * rateXP;
        }

        XPBar.fillAmount = XP / MaxXP;
        XPText.text = XP + " / " + MaxXP;
        XP = Mathf.Clamp(XP, 0f, MaxXP);

    }

    public void gain(float xpgagne)
    {
        XP = XP + xpgagne;
    }
}
