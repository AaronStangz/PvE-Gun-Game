using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectWoodPlank : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;

    public int pickUpRange;
    [Space]
    public int GiveWoodPlanks;
    [Space]
    public int GiveXP;
    void Start()
    {
        mainManager = GameObject.Find("MainManager");
        MM = mainManager.GetComponent<MainManager>();
    }

    public void CollectItem()
    {
        MM.PlayerLevel += GiveXP;
        MM.WoodPlanks += GiveWoodPlanks;
        Destroy(gameObject);
    }
}
