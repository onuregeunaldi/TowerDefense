using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int maxHealth = 10;
    [SerializeField ]private int playerHealth = 10;
    [SerializeField] int damage = 1;

    public HealthBar healthBar;


    void Start()
    {
        playerHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    private void OnTriggerEnter(Collider other)
    {
        playerHealth = playerHealth - damage;
        healthBar.SetHealt(playerHealth);
    }
}
