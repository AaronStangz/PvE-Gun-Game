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

    [Header("GunLevel")]
    // ARS
    public int BlazeBreakerLevel;
    public int StormScorcherLevel;
    public int PulsefireLevel;
    // SMG
    public int SprayStrikerLevel;
    public int BuzzBlitzerLevel;
    public int RattleRipperLevel;
    // Pistols
    public int PowderPopperLevel;
    public int QuickdrawBlasterLevel;
    public int BoltBouncerLevel;
    // Shotguns
    public int BoomBusterLevel;
    public int BlastBarrelLevel;
    public int ThunderThumperLevel;
    // Snipers
    public int StormshotSniperLevel;
    public int ShadowSlicerLevel;
    public int EagleEyeLevel;

    [Header("GunParts")]
    // ARS
    public int BlazeBreakerParts;
    public int StormScorcherParts;
    public int PulsefireParts;
    // SMG
    public int SprayStrikerParts;
    public int BuzzBlitzerParts;
    public int RattleRipperParts;
    // Pistols
    public int PowderPopperParts;
    public int QuickdrawBlasterParts;
    public int BoltBouncerParts;
    // Shotguns
    public int BoomBusterParts;
    public int BlastBarrelParts;
    public int ThunderThumperParts;
    // Snipers
    public int StormshotSniperParts;
    public int ShadowSlicerParts;
    public int EagleEyeParts;

    [Header("Guns")]
    // ARS
    public bool BlazeBreaker;
    public bool StormScorcher;
    public bool Pulsefire;
    // SMG
    public bool SprayStriker;
    public bool BuzzBlitzer;
    public bool RattleRipper;
    // Pistols
    public bool PowderPopper;
    public bool QuickdrawBlaster;
    public bool BoltBouncer;
    // Shotguns
    public bool BoomBuster;
    public bool BlastBarrel;
    public bool ThunderThumper;
    // Snipers
    public bool StormshotSniper;
    public bool ShadowSlicer;
    public bool EagleEye;

    [Header("Mat")]
    public int Gold;
    public int Planks;
    public int SturdyMechanicalParts;
    public int SleekMechanicalParts;
    public int RustyMechanicalParts;

    public TMP_Text PowerLevelText;
    public TMP_Text PlayerLevelText;
    public TMP_Text GoldText;
    public int PowerLevel;
    public int Xp;
    public int ResearchXp;

    public void Update()
    {
        GoldText.text = Gold + " ";
        PowerLevelText.text = PowerLevel + " ";
        PlayerLevelText.text = Xp + " ";
        if (Xp == 100)
        {
            PowerLevel = 1;
        }
        if (Xp == 200)
        {
            PowerLevel = 2;
        }
        if (Xp == 400)
        {
            PowerLevel = 3;
        }
        if (Xp == 800)
        {
            PowerLevel = 4;
        }
        if (Xp == 1600)
        {
            PowerLevel = 5;
        }
        if (Xp == 2400)
        {
            PowerLevel = 6;
        }
        if (Xp == 4800)
        {
            PowerLevel = 7;
        }
    }
}
