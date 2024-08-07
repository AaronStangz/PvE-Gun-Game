using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipGun : MonoBehaviour
{
    public GameObject[] MainGun;
    public GameObject[] SecondGun;
    public GameObject[] MainGunUi;
    public GameObject[] SecondGunUi;

    public void ToggleMainGun(int indexToEnable)
    {
        for (int i = 0; i < MainGun.Length; i++)
        {
            MainGun[i].SetActive(indexToEnable == i);
        }
        for (int i = 0; i < MainGunUi.Length; i++)
        {
            MainGunUi[i].SetActive(indexToEnable == i);
        }
    }

    public void ToggleSecondGun(int indexToEnable)
    {
        for (int i = 0; i < SecondGun.Length; i++)
        {
            SecondGun[i].SetActive(indexToEnable == i);
        }
        for (int i = 0; i < SecondGunUi.Length; i++)
        {
            SecondGunUi[i].SetActive(indexToEnable == i);
        }
    }
}
