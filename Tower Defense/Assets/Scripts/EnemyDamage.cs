using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int hitPoints = 10;
    public int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = hitPoints;
        healthBar.SetMaxHealth(hitPoints);
    }

    // Update is called once per frames
    void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        print("HIT");
        ProcessHit();
        if(currentHealth <= 0)
        {
            KillEnemy();
        }
    }

    void ProcessHit()
    {
        //hitPoints -= 1;
        currentHealth -= 1;
        healthBar.SetHealt(currentHealth);
        
    }

    void KillEnemy()
    {
        Destroy(gameObject);
    }
}
