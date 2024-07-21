using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    public Transform Spawnpoint;
    public List<GameObject> Plot;

    void Start()
    {
        Instantiate(Plot[Random.Range(0, Plot.Count)], Spawnpoint.transform.position, Spawnpoint.transform.rotation);
    }


}
