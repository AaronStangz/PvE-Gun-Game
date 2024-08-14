using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MarketManager : MonoBehaviour
{
    public List<Transform> Spawnpoint;
    public List<GameObject> Slots;

    public TMP_Text MarketTimeText;

    public float MarketTime = 60.0f;
    public float RestoreTime = 0;

    void Start()
    {
        RestoreMarket();
    }
    public void RestoreMarket()
    {
        foreach (Transform obj in Spawnpoint)
        {
            if (obj != null)
            {
                    Instantiate(Slots[Random.Range(0, Slots.Count)], obj.transform.position, obj.transform.rotation, obj);                   
            }
        }
    }

    public void Update()
    {
        MarketTimeText.text = "Market Restock: " + RestoreTime + " ";

        RestoreTime -= Time.deltaTime;

        if (RestoreTime <= 0)
        {
            timerEnded();
        }
    }

    void timerEnded()
    {
        RestoreTime = MarketTime;

        foreach (Transform obj in Spawnpoint)
        {
            if (obj != null)
            {
                if (obj.childCount <= 0)
                {
                    Instantiate(Slots[Random.Range(0, Slots.Count)], obj.transform.position, obj.transform.rotation, obj);
                }
            }
        }
    }

}
