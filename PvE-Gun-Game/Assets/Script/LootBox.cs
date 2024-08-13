using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static UnityEngine.InputManagerEntry;

public class LootBox : MonoBehaviour
{
    public float useRange;
    [Space]
    public GameObject ClosedLid;
    public GameObject OpenLid;
    [Space]
    public Transform Spawnpoint;
    [Space]
    public int GiveXP;
    [Space]
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
        if(ClosedLid.activeSelf)
        {
        ClosedLid.SetActive(false);
        OpenLid.SetActive(true);
        MM.Xp += GiveXP;
        // openParticle.Play();
        Instantiate(Gun[Random.Range(0, Gun.Count)], Spawnpoint.transform.position, Spawnpoint.transform.rotation);
        Instantiate(Item[Random.Range(0, Item.Count)], Spawnpoint.transform.position, Spawnpoint.transform.rotation);
        }
    }
}
