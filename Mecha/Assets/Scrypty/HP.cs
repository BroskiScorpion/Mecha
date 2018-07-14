using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {
    
    public float maxHealth;
    public float currentHealth;

    public void Damage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth<=0 && this.gameObject.CompareTag("Enemy"))
        {
            GetComponent<EnemyDeathControl>().Death();
        }
    }
    void Spawn()
    {
        currentHealth = maxHealth;
    }
}
