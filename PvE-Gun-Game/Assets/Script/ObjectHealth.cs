using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHealth : MonoBehaviour
{
    public float health;
    public void HitTarget(float damage, float damageMultiplier)
    {
        float actualDamage = damage * damageMultiplier;
        Debug.Log("Damage taken: " + actualDamage);
        health -= actualDamage;
    }

    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject, 5f);
    }
}
