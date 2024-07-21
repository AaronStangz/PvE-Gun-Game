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
    public int GiveXP;
    public GameObject mainManager;
    MainManager MM;
    //public ParticleSystem openParticle;

    public List<GameObject> Gun;
    public List<GameObject> Item;

    void Start()
    {
        mainManager = GameObject.Find("MainManager");
        MM = mainManager.GetComponent<MainManager>();
    }

    public void OpenBox()
    {
        
        Destroy(lid);
        MM.PlayerLevel += GiveXP;
        // openParticle.Play();
        Instantiate(Gun[Random.Range(0, Gun.Count)], Spawnpoint.transform.position, Spawnpoint.transform.rotation);
        Instantiate(Item[Random.Range(0, Item.Count)], Spawnpoint.transform.position, Spawnpoint.transform.rotation);
    }
}
