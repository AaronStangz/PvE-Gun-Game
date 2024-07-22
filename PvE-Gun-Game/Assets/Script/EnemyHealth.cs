using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 300f; // Initial health
    public float bodyDespawn = 10f;
    public Rigidbody rb;
    public Animator animator;
    [Space]
    public BoxCollider mainColliders;

    public List<CapsuleCollider> ragDollColliders;
    public List<Rigidbody> limbsRigidbodies;

    void Start()
    {
        RagdollModeOff();
    }

    void Update()
    {
        if (health <= 0)
        {
            knocked();
        }
        if (health <= -100)
        {
            Die();
        }
    }

    public void HitTarget(float damage, float damageMultiplier)
    {
        float actualDamage = damage * damageMultiplier;
        Debug.Log("Damage taken: " + actualDamage);
        health -= actualDamage;
    }

    void knocked()
    {
        animator.SetTrigger("TrKnocked");
    }

    void Die()
    {
        RagdollModeOn();
        Destroy(gameObject, bodyDespawn);
    }


    void RagdollModeOn()
    {
        foreach (Collider col in ragDollColliders)
        {
            col.enabled = true;
        }
        foreach (Rigidbody rigid in limbsRigidbodies)
        {
            rigid.isKinematic = false;
        }

        Destroy(mainColliders, 2f);
        
        animator.enabled = false;
        rb.GetComponent<Rigidbody>().isKinematic = true;
    }

    void RagdollModeOff()
    {
        foreach(Collider col in ragDollColliders)
        {
            col.enabled = true;
        }
        foreach (Rigidbody rigid in limbsRigidbodies)
        {
            rigid.isKinematic = true;
        }

        mainColliders.enabled = true;
        animator.enabled = true;
        rb.GetComponent<Rigidbody>().isKinematic = false;

    }


}
