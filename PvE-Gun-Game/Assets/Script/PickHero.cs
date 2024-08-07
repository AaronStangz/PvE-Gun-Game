using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickHero : MonoBehaviour
{
    public GameObject[] Heros;

    public void TogglePages(int indexToEnable)
    {
        for (int i = 0; i < Heros.Length; i++)
        {
            Heros[i].SetActive(indexToEnable == i);
        }
    }
}
