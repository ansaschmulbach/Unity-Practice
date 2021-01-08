using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private int health;
    [SerializeField] private int maxHealth = 10;
    [SerializeField] public Slider slider;
    [SerializeField] public Gradient gradient;
    [SerializeField] public Image filler;

    void Start()
    {
        health = maxHealth;
        if (slider)
        {
            slider.maxValue = maxHealth;
            slider.value = maxHealth; 
            filler.color = gradient.Evaluate(1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoseHealth(int amount)
    {
        health = Math.Max(0, health - amount);
        UpdateSlider();
        if (health == 0)
        {
            Die();
        }
    }

    public void GainHealth(int amount)
    {
        health = Math.Min(maxHealth, health + amount);
        UpdateSlider();
    }

    public void UpdateSlider()
    {
        if (slider != null)
        {
            slider.value = health;
            filler.color = gradient.Evaluate(slider.normalizedValue);
        }
    }
    
    public void Die()
    {
        Destroy(this.gameObject);
    }
    
}
