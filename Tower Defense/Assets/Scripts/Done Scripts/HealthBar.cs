using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public EnemyDamage enemyDamage;
    // Start is called before the first frame update
    void Start()
    {
        EnemyDamage enemyDamage = FindObjectOfType<EnemyDamage>(); 
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealt(int health)
    {
        slider.value = health;
    }
}
