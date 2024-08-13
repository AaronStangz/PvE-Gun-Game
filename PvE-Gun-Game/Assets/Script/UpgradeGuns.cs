using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeGuns : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;

    [Header("GunObj")]
    public List<GameObject> BlazeBreakerObj;
    public List<GameObject> StormScorcherObj;
    public List<GameObject> PulsefireObj;
    // SMG
    public List<GameObject> SprayStrikerObj;
    public List<GameObject> BuzzBlitzerObj;
    public List<GameObject> RattleRipperObj;
    // Pistols
    public List<GameObject> PowderPopperObj;
    public List<GameObject> QuickdrawBlasterObj;
    public List<GameObject> BoltBouncerObj;
    // Shotguns
    public List<GameObject> BoomBusterObj;
    public List<GameObject> BlastBarrelObj;
    public List<GameObject> ThunderThumperObj;
    // Snipers
    public List<GameObject> StormshotSniperObj;
    public List<GameObject> ShadowSlicerObj;
    public List<GameObject> EagleEyeObj;

    [Header("Gun Parts Needed")]
    // ARS
    public int BlazeBreakerPartsNeeded;
    public int StormScorcherPartsNeeded;
    public int PulsefirePartsNeeded;
    // SMG
    public int SprayStrikerPartsNeeded;
    public int BuzzBlitzerPartsNeeded;
    public int RattleRipperPartsNeeded;
    // Pistols
    public int PowderPopperPartsNeeded;
    public int QuickdrawBlasterPartsNeeded;
    public int BoltBouncerPartsNeeded;
    // Shotguns
    public int BoomBusterPartsNeeded;
    public int BlastBarrelPartsNeeded;
    public int ThunderThumperPartsNeeded;
    // Snipers
    public int StormshotSniperPartsNeeded;
    public int ShadowSlicerPartsNeeded;
    public int EagleEyePartsNeeded;

    [Header("Gun Xp Need")]
    // ARS
    public int BlazeBreakerXpNeeded;
    public int StormScorcherXpNeeded;
    public int PulsefireXpNeeded;
    // SMG
    public int SprayStrikerXpNeeded;
    public int BuzzBlitzerXpNeeded;
    public int RattleRipperXpNeeded;
    // Pistols
    public int PowderPopperXpNeeded;
    public int QuickdrawBlasterXpNeeded;
    public int BoltBouncerXpNeeded;
    // Shotguns
    public int BoomBusterXpNeeded;
    public int BlastBarrelXpNeeded;
    public int ThunderThumperXpNeeded;
    // Snipers
    public int StormshotSniperXpNeeded;
    public int ShadowSlicerXpNeeded;
    public int EagleEyeXpNeeded;

    [Header("Gun Xp Text")]
    // ARS
    public TMP_Text BlazeBreakerXPText;
    public TMP_Text StormScorcherXPText;
    public TMP_Text PulsefireXPText;
    // SMG
    public TMP_Text SprayStrikerXPText;
    public TMP_Text BuzzBlitzerXPText;
    public TMP_Text RattleRipperXPText;
    // Pistols
    public TMP_Text PowderPopperXPText;
    public TMP_Text QuickdrawBlasterXPText;
    public TMP_Text BoltBouncerXPText;
    // Shotguns
    public TMP_Text BoomBusterXPText;
    public TMP_Text BlastBarrelXPText;
    public TMP_Text ThunderThumperXPText;
    // Snipers
    public TMP_Text StormshotSniperXPText;
    public TMP_Text ShadowSlicerXPText;
    public TMP_Text EagleEyeXPText;

    [Header("Gun Parts Text")]
    // ARS
    public TMP_Text BlazeBreakerPartText;
    public TMP_Text StormScorcherPartText;
    public TMP_Text PulsefirePartText;
    // SMG
    public TMP_Text SprayStrikerPartText;
    public TMP_Text BuzzBlitzerPartText;
    public TMP_Text RattleRipperPartText;
    // Pistols
    public TMP_Text PowderPopperPartText;
    public TMP_Text QuickdrawBlasterPartText;
    public TMP_Text BoltBouncerPartText;
    // Shotguns
    public TMP_Text BoomBusterPartText;
    public TMP_Text BlastBarrelPartText;
    public TMP_Text ThunderThumperPartText;
    // Snipers
    public TMP_Text StormshotSniperPartText;
    public TMP_Text ShadowSlicerPartText;
    public TMP_Text EagleEyePartText;

    [Header("Gun Parts Text")]
    public List<TMP_Text> SturdyMechanicalPartsText;
    public List<TMP_Text> SleekMechanicalPartsText;
    public List<TMP_Text> RustyMechanicalPartsText;

    [Header("Gun Level Slider")]
    // ARS
    public List<Slider> BlazeBreakerLevel;
    public List<Slider> StormScorcherLevel;
    public List<Slider> PulsefireLevel;
    // SMG
    public List<Slider> SprayStrikerLevel;
    public List<Slider> BuzzBlitzerLevel;
    public List<Slider> RattleRipperLevel;
    // Pistols
    public List<Slider> PowderPopperLevel;
    public List<Slider> QuickdrawBlasterLevel;
    public List<Slider> BoltBouncerLevel;
    // Shotguns
    public List<Slider> BoomBusterLevel;
    public List<Slider> BlastBarrelLevel;
    public List<Slider> ThunderThumperLevel;
    // Snipers
    public List<Slider> StormshotSniperLevel;
    public List<Slider> ShadowSlicerLevel;
    public List<Slider> EagleEyeLevel;

    private void Awake()
    {
        MM = mainManager.GetComponent<MainManager>();
    }

    public void Update()
    {
        UpgradePartsTexts();
    }

    public void UpgradePartsTexts()
    {
        foreach (TMP_Text obj in SturdyMechanicalPartsText)
        {
            if (obj != null)
            {
                obj.text = "Parts: " + MM.SturdyMechanicalParts + " / " + "1 ";
            }
        }
        foreach (TMP_Text obj in SleekMechanicalPartsText)
        {
            if (obj != null)
            {
                obj.text = "Parts: " + MM.SleekMechanicalParts + " / " + "1 ";
            }
        }
        foreach (TMP_Text obj in RustyMechanicalPartsText)
        {
            if (obj != null)
            {
                obj.text = "Parts: " + MM.RustyMechanicalParts + " / " + "1 ";
            }
        }


        BlazeBreakerPartText.text = "Parts: " + MM.BlazeBreakerParts + " / " + BlazeBreakerPartsNeeded + " ";
        BlazeBreakerXPText.text = "Research XP: " + MM.ResearchXp + " / " + BlazeBreakerXpNeeded + " ";

        StormScorcherPartText.text = "Parts: " + MM.StormScorcherParts + " / " + StormScorcherPartsNeeded + " ";
        StormScorcherXPText.text = "Research XP: " + MM.ResearchXp + " / " + StormScorcherXpNeeded + " ";

        PulsefirePartText.text = "Parts: " + MM.PulsefireParts + " / " + PulsefirePartsNeeded + " ";
        PulsefireXPText.text = "Research XP: " + MM.ResearchXp + " / " + PulsefireXpNeeded + " ";

         SprayStrikerPartText.text = "Parts: " + MM. SprayStrikerParts + " / " +  SprayStrikerPartsNeeded + " ";
         SprayStrikerXPText.text = "Research XP: " + MM.ResearchXp + " / " +  SprayStrikerXpNeeded + " ";

        BuzzBlitzerPartText.text = "Parts: " + MM.BuzzBlitzerParts + " / " + BuzzBlitzerPartsNeeded + " ";
        BuzzBlitzerXPText.text = "Research XP: " + MM.ResearchXp + " / " + BuzzBlitzerXpNeeded + " ";

        RattleRipperPartText.text = "Parts: " + MM.RattleRipperParts + " / " + RattleRipperPartsNeeded + " ";
        RattleRipperXPText.text = "Research XP: " + MM.ResearchXp + " / " + RattleRipperXpNeeded + " ";

        PowderPopperPartText.text = "Parts: " + MM.PowderPopperParts + " / " + PowderPopperPartsNeeded + " ";
        PowderPopperXPText.text = "Research XP: " + MM.ResearchXp + " / " + PowderPopperXpNeeded + " ";

        QuickdrawBlasterPartText.text = "Parts: " + MM.QuickdrawBlasterParts + " / " + QuickdrawBlasterPartsNeeded + " ";
        QuickdrawBlasterXPText.text = "Research XP: " + MM.ResearchXp + " / " + QuickdrawBlasterXpNeeded + " ";

        BoltBouncerPartText.text = "Parts: " + MM.BoltBouncerParts + " / " + BoltBouncerPartsNeeded + " ";
        BoltBouncerXPText.text = "Research XP: " + MM.ResearchXp + " / " + BoltBouncerXpNeeded + " ";

        BoomBusterPartText.text = "Parts: " + MM.BoomBusterParts + " / " + BoomBusterPartsNeeded + " ";
        BoomBusterXPText.text = "Research XP: " + MM.ResearchXp + " / " + BoomBusterXpNeeded + " ";

        BlastBarrelPartText.text = "Parts: " + MM.BlastBarrelParts + " / " + BlastBarrelPartsNeeded + " ";
        BlastBarrelXPText.text = "Research XP: " + MM.ResearchXp + " / " + BlastBarrelXpNeeded + " ";

        ThunderThumperPartText.text = "Parts: " + MM.ThunderThumperParts + " / " + ThunderThumperPartsNeeded + " ";
        ThunderThumperXPText.text = "Research XP: " + MM.ResearchXp + " / " + ThunderThumperXpNeeded + " ";

        StormshotSniperPartText.text = "Parts: " + MM.StormshotSniperParts + " / " + StormshotSniperPartsNeeded + " ";
        StormshotSniperXPText.text = "Research XP: " + MM.ResearchXp + " / " + StormshotSniperXpNeeded + " ";

        ShadowSlicerPartText.text = "Parts: " + MM.ShadowSlicerParts + " / " + ShadowSlicerPartsNeeded + " ";
        ShadowSlicerXPText.text = "Research XP: " + MM.ResearchXp + " / " + ShadowSlicerXpNeeded + " ";

        EagleEyePartText.text = "Parts: " + MM.EagleEyeParts + " / " + EagleEyePartsNeeded + " ";
        EagleEyeXPText.text = "Research XP: " + MM.ResearchXp + " / " + EagleEyeXpNeeded + " ";


    }

    public void BlazeBreaker()
    {
        if(MM.BlazeBreakerParts >= BlazeBreakerPartsNeeded && MM.BlazeBreakerLevel <= 10 && MM.ResearchXp >= BlazeBreakerXpNeeded && MM.SturdyMechanicalParts >= 1)
        {
            foreach (Slider obj in BlazeBreakerLevel)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in BlazeBreakerObj)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.BlazeBreakerParts -= BlazeBreakerPartsNeeded;
            MM.ResearchXp -= BlazeBreakerXpNeeded;
            MM.SturdyMechanicalParts -= 1;
            BlazeBreakerPartsNeeded += 5;
            MM.BlazeBreakerLevel += 1;
            MM.Xp += 50;
        }
    }

    public void StormScorcher()
    {
        if (MM.StormScorcherParts >= StormScorcherPartsNeeded && MM.StormScorcherLevel <= 10 && MM.ResearchXp >= StormScorcherXpNeeded && MM.SturdyMechanicalParts >= 1)
        {
            foreach (Slider obj in StormScorcherLevel)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in StormScorcherObj)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.StormScorcherParts -= StormScorcherPartsNeeded;
            MM.ResearchXp -= StormScorcherXpNeeded;
            MM.SturdyMechanicalParts -= 1;
            StormScorcherPartsNeeded += 5;
            MM.StormScorcherLevel += 1;
            MM.Xp += 50;
        }
    }
    public void Pulsefire()
    {
        if (MM.PulsefireParts >= PulsefirePartsNeeded && MM.PulsefireLevel <= 10 && MM.ResearchXp >= PulsefireXpNeeded && MM.SturdyMechanicalParts >= 1)
        {
            foreach (Slider obj in PulsefireLevel)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in PulsefireObj)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.PulsefireParts -= PulsefirePartsNeeded;
            MM.ResearchXp -= PulsefireXpNeeded;
            MM.SturdyMechanicalParts -= 1;
            PulsefirePartsNeeded += 5;
            MM.PulsefireLevel += 1;
            MM.Xp += 50;
        }
    }

    public void SprayStriker()
    {
        if (MM.SprayStrikerParts >= SprayStrikerPartsNeeded && MM.SprayStrikerLevel <= 10 && MM.ResearchXp >= SprayStrikerXpNeeded && MM.SturdyMechanicalParts >= 1)
        {
            foreach (Slider obj in SprayStrikerLevel)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in SprayStrikerObj)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.SprayStrikerParts -= SprayStrikerPartsNeeded;
            MM.ResearchXp -= SprayStrikerXpNeeded;
            MM.SturdyMechanicalParts -= 1;
            SprayStrikerPartsNeeded += 5;
            MM.SprayStrikerLevel += 1;
            MM.Xp += 50;
        }
    }
    public void  BuzzBlitzer()
    {
        if (MM. BuzzBlitzerParts >=  BuzzBlitzerPartsNeeded && MM. BuzzBlitzerLevel <= 10 && MM.ResearchXp >=  BuzzBlitzerXpNeeded && MM.SturdyMechanicalParts >= 1)
        {
            foreach (Slider obj in  BuzzBlitzerLevel)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in  BuzzBlitzerObj)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM. BuzzBlitzerParts -=  BuzzBlitzerPartsNeeded;
            MM.ResearchXp -=  BuzzBlitzerXpNeeded;
            MM.SturdyMechanicalParts -= 1;
             BuzzBlitzerPartsNeeded += 5;
            MM. BuzzBlitzerLevel += 1;
            MM.Xp += 50;
        }
    }
    public void RattleRipper()
    {
        if (MM.RattleRipperParts >= RattleRipperPartsNeeded && MM.RattleRipperLevel <= 10 && MM.ResearchXp >= RattleRipperXpNeeded && MM.SturdyMechanicalParts >= 1)
        {
            foreach (Slider obj in RattleRipperLevel)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in RattleRipperObj)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.RattleRipperParts -= RattleRipperPartsNeeded;
            MM.ResearchXp -= RattleRipperXpNeeded;
            MM.SturdyMechanicalParts -= 1;
            RattleRipperPartsNeeded += 5;
            MM.RattleRipperLevel += 1;
            MM.Xp += 50;
        }
    }
    public void PowderPopper()
    {
        if (MM.PowderPopperParts >= PowderPopperPartsNeeded && MM.PowderPopperLevel <= 10 && MM.ResearchXp >= PowderPopperXpNeeded && MM.SturdyMechanicalParts >= 1)
        {
            foreach (Slider obj in PowderPopperLevel)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in PowderPopperObj)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.PowderPopperParts -= PowderPopperPartsNeeded;
            MM.ResearchXp -= PowderPopperXpNeeded;
            MM.SturdyMechanicalParts -= 1;
            PowderPopperPartsNeeded += 5;
            MM.PowderPopperLevel += 1;
            MM.Xp += 50;
        }
    }
    public void QuickdrawBlaster()
    {
        if (MM.QuickdrawBlasterParts >= QuickdrawBlasterPartsNeeded && MM.QuickdrawBlasterLevel <= 10 && MM.ResearchXp >= QuickdrawBlasterXpNeeded && MM.SturdyMechanicalParts >= 1)
        {
            foreach (Slider obj in QuickdrawBlasterLevel)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in QuickdrawBlasterObj)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.QuickdrawBlasterParts -= QuickdrawBlasterPartsNeeded;
            MM.ResearchXp -= QuickdrawBlasterXpNeeded;
            MM.SturdyMechanicalParts -= 1;
            QuickdrawBlasterPartsNeeded += 5;
            MM.QuickdrawBlasterLevel += 1;
            MM.Xp += 50;
        }
    }
    public void BoltBouncer()
    {
        if (MM.BoltBouncerParts >= BoltBouncerPartsNeeded && MM.BoltBouncerLevel <= 10 && MM.ResearchXp >= BoltBouncerXpNeeded && MM.SturdyMechanicalParts >= 1)
        {
            foreach (Slider obj in BoltBouncerLevel)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in BoltBouncerObj)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.BoltBouncerParts -= BoltBouncerPartsNeeded;
            MM.ResearchXp -= BoltBouncerXpNeeded;
            MM.SturdyMechanicalParts -= 1;
            BoltBouncerPartsNeeded += 5;
            MM.BoltBouncerLevel += 1;
            MM.Xp += 50;
        }
    }
    public void BoomBuster()
    {
        if (MM.BoomBusterParts >= BoomBusterPartsNeeded && MM.BoomBusterLevel <= 10 && MM.ResearchXp >= BoomBusterXpNeeded && MM.SturdyMechanicalParts >= 1)
        {
            foreach (Slider obj in BoomBusterLevel)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in BoomBusterObj)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.BoomBusterParts -= BoomBusterPartsNeeded;
            MM.ResearchXp -= BoomBusterXpNeeded;
            MM.SturdyMechanicalParts -= 1;
            BoomBusterPartsNeeded += 5;
            MM.BoomBusterLevel += 1;
            MM.Xp += 50;
        }
    }
    public void BlastBarrel()
    {
        if (MM.BlastBarrelParts >= BlastBarrelPartsNeeded && MM.BlastBarrelLevel <= 10 && MM.ResearchXp >= BlastBarrelXpNeeded && MM.SturdyMechanicalParts >= 1)
        {
            foreach (Slider obj in BlastBarrelLevel)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in BlastBarrelObj)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.BlastBarrelParts -= BlastBarrelPartsNeeded;
            MM.ResearchXp -= BlastBarrelXpNeeded;
            MM.SturdyMechanicalParts -= 1;
            BlastBarrelPartsNeeded += 5;
            MM.BlastBarrelLevel += 1;
            MM.Xp += 50;
        }
    }
    public void ThunderThumper()
    {
        if (MM.ThunderThumperParts >= ThunderThumperPartsNeeded && MM.ThunderThumperLevel <= 10 && MM.ResearchXp >= ThunderThumperXpNeeded && MM.SturdyMechanicalParts >= 1)
        {
            foreach (Slider obj in ThunderThumperLevel)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in ThunderThumperObj)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.ThunderThumperParts -= ThunderThumperPartsNeeded;
            MM.ResearchXp -= ThunderThumperXpNeeded;
            MM.SturdyMechanicalParts -= 1;
            ThunderThumperPartsNeeded += 5;
            MM.ThunderThumperLevel += 1;
            MM.Xp += 50;
        }
    }
    public void StormshotSniper()
    {
        if (MM.StormshotSniperParts >= StormshotSniperPartsNeeded && MM.StormshotSniperLevel <= 10 && MM.ResearchXp >= StormshotSniperXpNeeded && MM.SturdyMechanicalParts >= 1)
        {
            foreach (Slider obj in StormshotSniperLevel)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in StormshotSniperObj)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.StormshotSniperParts -= StormshotSniperPartsNeeded;
            MM.ResearchXp -= StormshotSniperXpNeeded;
            MM.SturdyMechanicalParts -= 1;
            StormshotSniperPartsNeeded += 5;
            MM.StormshotSniperLevel += 1;
            MM.Xp += 50;
        }
    }
    public void ShadowSlicer()
    {
        if (MM.ShadowSlicerParts >= ShadowSlicerPartsNeeded && MM.ShadowSlicerLevel <= 10 && MM.ResearchXp >= ShadowSlicerXpNeeded && MM.SturdyMechanicalParts >= 1)
        {
            foreach (Slider obj in ShadowSlicerLevel)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in ShadowSlicerObj)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.ShadowSlicerParts -= ShadowSlicerPartsNeeded;
            MM.ResearchXp -= ShadowSlicerXpNeeded;
            MM.SturdyMechanicalParts -= 1;
            ShadowSlicerPartsNeeded += 5;
            MM.ShadowSlicerLevel += 1;
            MM.Xp += 50;
        }
    }

    public void EagleEye()
    {
        if (MM.EagleEyeParts >= EagleEyePartsNeeded && MM.EagleEyeLevel <= 10 && MM.ResearchXp >= EagleEyeXpNeeded && MM.SturdyMechanicalParts >= 1)
        {
            foreach (Slider obj in EagleEyeLevel)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in EagleEyeObj)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.EagleEyeParts -= EagleEyePartsNeeded;
            MM.ResearchXp -= EagleEyeXpNeeded;
            MM.SturdyMechanicalParts -= 1;
            EagleEyePartsNeeded += 5;
            MM.EagleEyeLevel += 1;
            MM.Xp += 50;
        }
    }
}
