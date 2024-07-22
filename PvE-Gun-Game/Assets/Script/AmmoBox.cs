using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
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

    public List<GameObject> Ammo;

    void Start()
    {
        mainManager = GameObject.Find("MainManager");
        MM = mainManager.GetComponent<MainManager>();
    }

    public void OpenBox()
    {
        if (ClosedLid.activeSelf)
        {
            ClosedLid.SetActive(false);
            OpenLid.SetActive(true);
            MM.PlayerLevel += GiveXP;
            // openParticle.Play();
            Instantiate(Ammo[Random.Range(0, Ammo.Count)], Spawnpoint.transform.position, Spawnpoint.transform.rotation);
            Instantiate(Ammo[Random.Range(0, Ammo.Count)], Spawnpoint.transform.position, Spawnpoint.transform.rotation);
            Instantiate(Ammo[Random.Range(0, Ammo.Count)], Spawnpoint.transform.position, Spawnpoint.transform.rotation);
        }
    }
}
