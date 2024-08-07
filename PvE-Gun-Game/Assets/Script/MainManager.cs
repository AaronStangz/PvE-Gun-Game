using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    [Header("GunSlot")]
    public bool Main;
    public bool Second;

    [Header("Ammo")]
    public int HeavyBullets;
    public int LightBullets;
    public int MediumBullets;
    public int Shells;
    public int Rockets;

    [Header("GunParts")]
    public int BlackhawkS14Parts;
    public int SentinelS37Parts;
    public int VanguardM17Parts;
    public int ValkyrieM76Parts;
    public int ReaperP12Parts;
    public int PredatorP63Parts;
    public int ThunderboltA16Parts;
    public int GuardianA37Parts;
    public int PhantomS47Parts;
    public int HavocS13Parts;
    public int SabreR23Parts;
    public int TitanR30Parts;

    [Header("GunLevel")]
    public int BlackhawkS14Level;
    public int SentinelS37Level;
    public int VanguardM17Level;
    public int ValkyrieM76Level;
    public int ReaperP12Level;
    public int PredatorP63Level;
    public int ThunderboltA16Level;
    public int GuardianA37Level;
    public int PhantomS47Level;
    public int HavocS13Level;
    public int SabreR23Level;
    public int TitanR30Level;

    [Header("Mats")]
    public int WoodPlanks;
    public int Gold;

    public TMP_Text PlayerLevelText;
    public int PlayerLevel;
    public int Xp;
    public int ResearchXp;

    public void Update()
    {
        PlayerLevelText.text = "Power Level:" + PlayerLevel + " ";
        if (Xp == 100)
        {
            PlayerLevel = 1;
        }
        if (Xp == 200)
        {
            PlayerLevel = 2;
        }
        if (Xp == 400)
        {
            PlayerLevel = 3;
        }
        if (Xp == 800)
        {
            PlayerLevel = 4;
        }
        if (Xp == 1600)
        {
            PlayerLevel = 5;
        }
        if (Xp == 2400)
        {
            PlayerLevel = 6;
        }
        if (Xp == 4800)
        {
            PlayerLevel = 7;
        }
    }
}
