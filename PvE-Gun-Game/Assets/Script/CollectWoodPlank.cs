using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectWoodPlank : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;

    public int pickUpRange;
    [Space]
    public int GivePlanks;
    [Space]
    public int GiveXP;
    void Start()
    {
        mainManager = GameObject.Find("MainManager");
        MM = mainManager.GetComponent<MainManager>();
    }

    public void CollectItem()
    {
        MM.Xp += GiveXP;
        MM.Planks += GivePlanks;
        Destroy(gameObject);
    }
}
