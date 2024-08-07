using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickPlay : MonoBehaviour
{
    public GameObject mainManager;
    private MainManager MM;

    public GameObject MainGui;
    public GameObject PickHero;

    public void Awake()
    {
        MM = mainManager.GetComponent<MainManager>();
    }
    public void Play()
    {
        if(MM.Main == true && MM.Second == true)
        {
        MainGui.SetActive(false);
        PickHero.SetActive(true);
        }
    }
}
