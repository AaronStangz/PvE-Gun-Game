
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public enum BulletType { HeavyBullets, LightBullets, MediumBullets, Shells, Rockets }

public class CustomBullet : MonoBehaviour
{
    [Header("Assignables")]
    public Rigidbody rb;
    public GameObject explosion;
    public LayerMask whatIsEnemies;
    public BulletType bulletType;

    [Header("Stats")]
    [Range(0f, 1f)]
    public float bounciness;
    public bool useGravity;

    [Header("Damamge")]
    public int explosionDamage;
    public float explosionRange;
    public float explosionForce;

    [Header("LifeTime")]
    public int maxCollisions;
    public float maxLifetime;
    public bool explodeOnTouch = true;
    [Space]
    public List<List<float>>DamageMuitplers = new List<List<float>>();
    public List<float> HeavyBulletsMuitlper;
    public List<float> LightBulletsMuitlper;
    public List<float> MediumBulletsMuitlper;
    public List<float> ShellsMuitlper;
    public List<float> RocketsMuitlper;

    int collisions;
    PhysicMaterial physics_mat;

    private void Start()
    {
        Setup();
    }

    private void Update()
    {
        if (collisions > maxCollisions) Explode();

        maxLifetime -= Time.deltaTime;
        if (maxLifetime <= 0) Explode();
    }

    private void Explode()
    {
        if (explosion != null) Instantiate(explosion, transform.position, Quaternion.identity);

        Collider[] enemies = Physics.OverlapSphere(transform.position, explosionRange, whatIsEnemies);
        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemies[i].GetComponent<Rigidbody>())
                enemies[i].GetComponent<Rigidbody>().AddExplosionForce(explosionForce, transform.position, explosionRange);
        }

        Invoke("Delay", 0.05f);
    }
    private void Delay()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        collisions++;
        Explode();
        float damageMultpler = 1;
        int bullettype = 2;
        switch(bulletType)
        {
            case BulletType.HeavyBullets : bullettype = 0; break;
            case BulletType.LightBullets: bullettype = 1; break;
            case BulletType.MediumBullets: bullettype = 2; break;
            case BulletType.Shells: bullettype = 3; break;
            case BulletType.Rockets: bullettype = 4; break;
            default: bullettype = 2; break;
        }
        switch(collision.collider.tag) 
        {
            case "EnemyHead":damageMultpler = DamageMuitplers[bullettype][0]; break;
            case "EnemyArms": damageMultpler = DamageMuitplers[bullettype][1]; break;
            case "EnemyLegs": damageMultpler = DamageMuitplers[bullettype][2]; break;
            case "EnemyBody": damageMultpler = DamageMuitplers[bullettype][3]; break;
            default: damageMultpler = 1; break;

        }
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.transform.root.GetComponent<EnemyHealth>() != null)
        { collision.gameObject.transform.root.GetComponent<EnemyHealth>().HitTarget(1, damageMultpler); }
        Debug.Log(collision.transform.root);
    }

    private void Setup()
    {
        DamageMuitplers.Add(HeavyBulletsMuitlper);
        DamageMuitplers.Add(LightBulletsMuitlper);
        DamageMuitplers.Add(MediumBulletsMuitlper);
        DamageMuitplers.Add(ShellsMuitlper);
        DamageMuitplers.Add(RocketsMuitlper);
        physics_mat = new PhysicMaterial();
        physics_mat.bounciness = bounciness;
        physics_mat.frictionCombine = PhysicMaterialCombine.Minimum;
        physics_mat.bounceCombine = PhysicMaterialCombine.Maximum;

        rb.useGravity = useGravity;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRange);
    }
}
