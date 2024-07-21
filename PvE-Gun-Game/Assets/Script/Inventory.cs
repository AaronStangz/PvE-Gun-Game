using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject inventoryGameObject;
    public GameObject inventoryGUI;
    public GameObject playerCamera;
    public GameObject mainManger;
    MainManager MM;

    public TMP_Text[] ItemText;
    public TMP_Text[] GunText;
    public TMP_Text[] AmmoText;

    public bool InvOpen;
    void Start()
    {
        MM = mainManger.GetComponent<MainManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Tab) && !InvOpen) 
        {
            InvOpen = true;
            playerCamera.SetActive(false);
            inventoryGameObject.SetActive(true);
            inventoryGUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            gameObject.GetComponent<PlayerMovement>().enabled = false;
        }
        if (Input.GetKey(KeyCode.Escape) && InvOpen)
        {
            InvOpen = false;
            playerCamera.SetActive(true);
            inventoryGameObject.SetActive(false);
            inventoryGUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            gameObject.GetComponent<PlayerMovement>().enabled = true;
        }

        if(InvOpen)
        {
            UpgradeText();
        }
    }

    public void UpgradeText()
    {
        ItemText[0].text = "Wood Planks: " + MM.WoodPlanks + " / " + "5";

        AmmoText[0].text = "Heavy Bullets: " + MM.HeavyBullets + " / " + "999";
        AmmoText[1].text = "Light Bullets: " + MM.LightBullets + " / " + "999";
        AmmoText[2].text = "Medium Bullets: " + MM.MediumBullets + " / " + "999";
        AmmoText[3].text = "Shells: " + MM.Shells + " / " + "999";
        AmmoText[4].text = "Rockets: " + MM.Rockets + " / " + "999";
    }
}
