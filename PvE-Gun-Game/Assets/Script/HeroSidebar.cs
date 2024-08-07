using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSidebar : MonoBehaviour
{
    public GameObject[] Sidebar;

    public void TogglePages(int indexToEnable)
    {
        for (int i = 0; i < Sidebar.Length; i++)
        {
            Sidebar[i].SetActive(indexToEnable == i);
        }
    }
}
