using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    public float useRange;
    public GameObject lid;
    public Transform Spawnpoint;
    public int GiveXP;
    public GameObject mainManager;
    MainManager MM;
    //public ParticleSystem openParticle;

    public List<GameObject> Ammo;

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
        Instantiate(Ammo[Random.Range(0, Ammo.Count)], Spawnpoint.transform.position, Spawnpoint.transform.rotation);
        Instantiate(Ammo[Random.Range(0, Ammo.Count)], Spawnpoint.transform.position, Spawnpoint.transform.rotation);
        Instantiate(Ammo[Random.Range(0, Ammo.Count)], Spawnpoint.transform.position, Spawnpoint.transform.rotation);
    }
}
