using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Buy : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;

    public int GoldNeeded;
    public TMP_Text GoldText;

    [Header("Ammo")]
    public int GiveHeavyBullets;
    public int GiveLightBullets;
    public int GiveMediumBullets;
    public int GiveShells;
    public int GiveRockets;

    [Header("GunParts")]
    // ARS
    public int GiveBlazeBreakerParts;
    public int GiveStormScorcherParts;
    public int GivePulsefireParts;
    // SMG
    public int GiveSprayStrikerParts;
    public int GiveBuzzBlitzerParts;
    public int GiveRattleRipperParts;
    // Pistols
    public int GivePowderPopperParts;
    public int GiveQuickdrawBlasterParts;
    public int GiveBoltBouncerParts;
    // Shotguns
    public int GiveBoomBusterParts;
    public int GiveBlastBarrelParts;
    public int GiveThunderThumperParts;
    // Snipers
    public int GiveStormshotSniperParts;
    public int GiveShadowSlicerParts;
    public int GiveEagleEyeParts;

    [Header("Mat")]
    public int GiveSturdyMechanicalParts;
    public int GiveSleekMechanicalParts;
    public int GiveRustyMechanicalParts;

    // Start is called before the first frame update
    void Start()
    {
        mainManager = GameObject.Find("MainManager");
        MM = mainManager.GetComponent<MainManager>();
    }

    // Update is called once per frame
    void Update()
    {
        GoldText.text = " " + MM.Gold + " / " + GoldNeeded + " ";
    }

    public void Bought()
    {
        if (MM.Gold >= GoldNeeded)
        {
            MM.Gold -= GoldNeeded;

            MM.BlazeBreakerParts += GiveBlazeBreakerParts;
            MM.StormScorcherParts += GiveStormScorcherParts;
            MM.PulsefireParts += GivePulsefireParts;
            // SMG
            MM.SprayStrikerParts += GiveSprayStrikerParts;
            MM.BuzzBlitzerParts += GiveBuzzBlitzerParts;
            MM.RattleRipperParts += GiveRattleRipperParts;
            // Pistols
            MM.PowderPopperParts += GivePowderPopperParts;
            MM.QuickdrawBlasterParts += GiveQuickdrawBlasterParts;
            MM.BoltBouncerParts += GiveBoltBouncerParts;
            // Shotguns 
            MM.BoomBusterParts += GiveBoomBusterParts;
            MM.BlastBarrelParts += GiveBlastBarrelParts;
            MM.ThunderThumperParts += GiveThunderThumperParts;
            // Snipers 
            MM.StormshotSniperParts += GiveStormshotSniperParts;
            MM.ShadowSlicerParts += GiveShadowSlicerParts;
            MM.EagleEyeParts += GiveEagleEyeParts;

            MM.SturdyMechanicalParts += GiveSturdyMechanicalParts;
            MM.SleekMechanicalParts += GiveSleekMechanicalParts;
            MM.RustyMechanicalParts += GiveRustyMechanicalParts;

            MM.HeavyBullets += GiveHeavyBullets;
            MM.LightBullets += GiveLightBullets;
            MM.MediumBullets += GiveMediumBullets;
            MM.Shells += GiveShells;
            MM.Rockets += GiveRockets;
            Destroy(gameObject);
        }
    }
}
