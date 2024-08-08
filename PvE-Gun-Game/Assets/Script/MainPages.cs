using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPages : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Pages;
    public GameObject[] Backdrops;

    public void TogglePages(int indexToEnable)
    {
        for (int i = 0; i < Pages.Length; i++)
        {
            Pages[i].SetActive(indexToEnable == i);
        }
        for (int i = 0; i < Backdrops.Length; i++)
        {
            Backdrops[i].SetActive(indexToEnable == i);
        }
    }
}
