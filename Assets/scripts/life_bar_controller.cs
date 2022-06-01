using System.Collections;
using System.Collections.Generic;
using PolyLabs;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class life_bar_controller : MonoBehaviour
{

    public Slider lifeBarSlider;
    public Gradient gradient;
    public Image fill;

    public TMP_Text hpText;

    public void SetMaxHealth(float maxHealth)
    {
        lifeBarSlider.maxValue = maxHealth;
        lifeBarSlider.value    = maxHealth;

        hpText.text = ShortScale.ParseFloat(maxHealth);

        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(float health)
    {
        lifeBarSlider.value = health;
        hpText.text = ShortScale.ParseFloat(health);

        fill.color = gradient.Evaluate(lifeBarSlider.normalizedValue);
    }
}
