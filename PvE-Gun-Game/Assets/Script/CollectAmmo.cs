using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAmmo : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;

    public int pickUpRange;

    public int GiveHeavyBullets;
    public int GiveLightBullets;
    public int GiveMediumBullets;
    public int GiveShells;
    public int GiveRockets;
    public int GiveXP;
    void Start()
    {
        mainManager = GameObject.Find("MainManager");
        MM = mainManager.GetComponent<MainManager>();
    }

    public void CollectItem()
    {
        MM.PlayerLevel += GiveXP;
        MM.HeavyBullets += GiveHeavyBullets;
        MM.LightBullets += GiveLightBullets;
        MM.MediumBullets += GiveMediumBullets;
        MM.Shells += GiveShells;
        MM.Rockets += GiveRockets;
        Destroy(gameObject);
    }
}
