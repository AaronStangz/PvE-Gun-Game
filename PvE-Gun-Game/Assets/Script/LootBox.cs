using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static UnityEngine.InputManagerEntry;

public class LootBox : MonoBehaviour
{
    public float useRange;
    public GameObject lid;
    public Transform Spawnpoint;
    //public ParticleSystem openParticle;

    public List<GameObject> Gun;
    public List<GameObject> Ammo;
    public List<GameObject> Item;

    public void OpenBox()
    {
        Destroy(lid);
       // openParticle.Play();
        Instantiate(Gun[Random.Range(0, Gun.Count)], Spawnpoint.transform.position, Spawnpoint.transform.rotation);
        Instantiate(Ammo[Random.Range(0, Ammo.Count)], Spawnpoint.transform.position, Spawnpoint.transform.rotation);
        Instantiate(Item[Random.Range(0, Item.Count)], Spawnpoint.transform.position, Spawnpoint.transform.rotation);
    }
}
