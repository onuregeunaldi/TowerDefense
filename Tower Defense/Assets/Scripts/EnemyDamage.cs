using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int hitPoints = 10;
    public int currentHealth;

    [SerializeField] ParticleSystem hitPartical;
    [SerializeField] ParticleSystem deadPartical;

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
        currentHealth -= 1;
        healthBar.SetHealt(currentHealth);
        hitPartical.Play();
        
    }

    void KillEnemy()
    {
        var vfx = Instantiate(deadPartical, transform.position, Quaternion.identity);
        vfx.Play();
        Destroy(vfx.gameObject, vfx.main.duration);

        Destroy(gameObject);
    }
}
