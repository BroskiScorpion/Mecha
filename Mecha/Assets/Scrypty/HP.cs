using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {
    
    public float maxHealth;
    public float currentHealth;
    public DeathControl d;
	void Start ()
    {
        Spawn();
	}
    public void Damage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth<=0.0f && this.CompareTag("Enemy"))
        {
            (d as EnemyDeathControl).Death();
        }
    }
    void Spawn()
    {
        currentHealth = maxHealth;
    }
}
