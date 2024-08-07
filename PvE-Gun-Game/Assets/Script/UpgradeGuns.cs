using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeGuns : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;

    [Header("GunPartsNeeded")]
    public int Sniper1PartsNeeded;
    public int Sniper2PartsNeeded;
    public int SMG1PartsNeeded;
    public int SMG2PartsNeeded;
    public int Pistol1PartsNeeded;
    public int Pistol2PartsNeeded;
    public int AR1PartsNeeded;
    public int AR2PartsNeeded;
    public int ShotGun1PartsNeeded;
    public int ShotGun2PartsNeeded;
    public int RocketLancher1PartsNeeded;
    public int RocketLancher2PartsNeeded;

    [Header("GunXpNeed")]
    public int Sniper1XpNeeded;
    public int Sniper2XpNeeded;
    public int SMG1XpNeeded;
    public int SMG2XpNeeded;
    public int Pistol1XpNeeded;
    public int Pistol2XpNeeded;
    public int AR1XpNeeded;
    public int AR2XpNeeded;
    public int ShotGun1XpNeeded;
    public int ShotGun2XpNeeded;
    public int RocketLancher1XpNeeded;
    public int RocketLancher2XpNeeded;

    [Header("GunText")]
    public TMP_Text Sniper1XpText;
    public TMP_Text Sniper2XpText;
    public TMP_Text SMG1XpText;
    public TMP_Text SMG2XpText;
    public TMP_Text Pistol1XpText;
    public TMP_Text Pistol2XpText;
    public TMP_Text AR1XpText;
    public TMP_Text AR2XpText;
    public TMP_Text ShotGun1XpText;
    public TMP_Text ShotGun2XpText;
    public TMP_Text RocketLancher1XpText;
    public TMP_Text RocketLancher2XpText;

    [Header("GunText")]
    public TMP_Text Sniper1Text;
    public TMP_Text Sniper2Text;
    public TMP_Text SMG1Text;
    public TMP_Text SMG2Text;
    public TMP_Text Pistol1Text;
    public TMP_Text Pistol2Text;
    public TMP_Text AR1Text;
    public TMP_Text AR2Text;
    public TMP_Text ShotGun1Text;
    public TMP_Text ShotGun2Text;
    public TMP_Text RocketLancher1Text;
    public TMP_Text RocketLancher2Text;

    [Header("GunLocks")]
    public List<GameObject> Sniper1Lock;
    public List<GameObject> Sniper2Lock;
    public List<GameObject> SMG1Lock;
    public List<GameObject> SMG2Lock;
    public List<GameObject> Pistol1Lock;
    public List<GameObject> Pistol2Lock;
    public List<GameObject> AR1Lock;
    public List<GameObject> AR2Lock;
    public List<GameObject> ShotGun1Lock;
    public List<GameObject> ShotGun2Lock;
    public List<GameObject> RocketLancher1Lock;
    public List<GameObject> RocketLancher2Lock;

    [Header("Gun")]
    public List<GameObject> BlackhawkS14;
    public List<GameObject> SentinelS37;
    public List<GameObject> VanguardM17;
    public List<GameObject> ValkyrieM76;
    public List<GameObject> ReaperP12;
    public List<GameObject> PredatorP63;
    public List<GameObject> ThunderboltA16;
    public List<GameObject> GuardianA37;
    public List<GameObject> PhantomS47;
    public List<GameObject> HavocS13;
    public List<GameObject> SabreR23;
    public List<GameObject> TitanR30;

    [Header("GunLevelSlider")]
    public List<Slider> BlackhawkS14Level;
    public List<Slider> SentinelS37Level;
    public List<Slider> VanguardM17Level;
    public List<Slider> ValkyrieM76Level;
    public List<Slider> ReaperP12Level;
    public List<Slider> PredatorP63Level;
    public List<Slider> ThunderboltA16Level;
    public List<Slider> GuardianA37Level;
    public List<Slider> PhantomS47Level;
    public List<Slider> HavocS13Level;
    public List<Slider> SabreR23Level;
    public List<Slider> TitanR30Level;

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
        Sniper1Text.text = "Parts: " + MM.BlackhawkS14Parts + " / " + Sniper1PartsNeeded + " ";
        Sniper2Text.text = "Parts: " + MM.SentinelS37Parts + " / " + Sniper2PartsNeeded + " ";

        SMG1Text.text = "Parts: " + MM.VanguardM17Parts + " / " + SMG1PartsNeeded + " ";
        SMG2Text.text = "Parts: " + MM.ValkyrieM76Parts + " / " + SMG2PartsNeeded + " ";

        Pistol1Text.text = "Parts: " + MM.ReaperP12Parts + " / " + Pistol1PartsNeeded + " ";
        Pistol2Text.text = "Parts: " + MM.PredatorP63Parts + " / " + Pistol2PartsNeeded + " ";

        AR1Text.text = "Parts: " + MM.ThunderboltA16Parts + " / " + AR1PartsNeeded + " ";
        AR2Text.text = "Parts: " + MM.GuardianA37Parts + " / " + AR2PartsNeeded + " ";

        ShotGun1Text.text = "Parts: " + MM.PhantomS47Parts + " / " + ShotGun1PartsNeeded + " ";
        ShotGun2Text.text = "Parts: " + MM.HavocS13Parts + " / " + ShotGun2PartsNeeded + " ";

        RocketLancher1Text.text = "Parts: " + MM.SabreR23Parts + " / " + RocketLancher1PartsNeeded + " ";
        RocketLancher2Text.text = "Parts: " + MM.TitanR30Parts + " / " + RocketLancher2PartsNeeded + " ";



        Sniper1XpText.text = "Research XP: " + MM.ResearchXp + " / " + Sniper1XpNeeded + " ";
        Sniper2XpText.text = "Research XP: " + MM.ResearchXp + " / " + Sniper2XpNeeded + " ";

        SMG1XpText.text = "Research XP: " + MM.ResearchXp + " / " + SMG1XpNeeded + " ";
        SMG2XpText.text = "Research XP: " + MM.ResearchXp + " / " + SMG2XpNeeded + " ";

        Pistol1XpText.text = "Research XP: " + MM.ResearchXp + " / " + Pistol1XpNeeded + " ";
        Pistol2XpText.text = "Research XP: " + MM.ResearchXp + " / " + Pistol2XpNeeded + " ";

        AR1XpText.text = "Research XP: " + MM.ResearchXp + " / " + AR1XpNeeded + " ";
        AR2XpText.text = "Research XP: " + MM.ResearchXp + " / " + AR2XpNeeded + " ";

        ShotGun1XpText.text = "Research XP: " + MM.ResearchXp + " / " + ShotGun1XpNeeded + " ";
        ShotGun2XpText.text = "Research XP: " + MM.ResearchXp + " / " + ShotGun2XpNeeded + " ";

        RocketLancher1XpText.text = "Research XP: " + MM.ResearchXp + " / " + RocketLancher1XpNeeded + " ";
        RocketLancher2XpText.text = "Research XP: " + MM.ResearchXp + " / " + RocketLancher2XpNeeded + " ";

    }

    public void UpgradeSniper1()
    {
        if(MM.BlackhawkS14Parts >= Sniper1PartsNeeded && MM.BlackhawkS14Level <= 10 && MM.ResearchXp >= Sniper1XpNeeded)
        {
            foreach (GameObject obj in Sniper1Lock)
            {
                if (obj != null)  
                {
                    obj.SetActive(false);
                }
            }
            foreach (Slider obj in BlackhawkS14Level)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in BlackhawkS14)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.BlackhawkS14Parts -= Sniper1PartsNeeded;
            MM.ResearchXp -= Sniper1XpNeeded;
            Sniper1PartsNeeded += 5;
            MM.BlackhawkS14Level += 1;
            MM.Xp += 50;
        }
    }

    public void UpgradeSniper2()
    {
        if (MM.SentinelS37Parts >= Sniper2PartsNeeded && MM.SentinelS37Level <= 10 && MM.ResearchXp >= Sniper2XpNeeded)
        {
            foreach (GameObject obj in Sniper2Lock)
            {
                if (obj != null)
                {
                    obj.SetActive(false);
                }
            }
            foreach (Slider obj in SentinelS37Level)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in SentinelS37)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.SentinelS37Parts -= Sniper2PartsNeeded;
            MM.ResearchXp -= Sniper2XpNeeded;
            Sniper2PartsNeeded += 5;
            MM.SentinelS37Level += 1;
            MM.Xp += 50;
        }
    }

    public void UpgradeSMG1()
    {
        if (MM.VanguardM17Parts >= SMG1PartsNeeded && MM.VanguardM17Level <= 10 && MM.ResearchXp >= SMG1XpNeeded)
        {
            foreach (GameObject obj in SMG1Lock)
            {
                if (obj != null)
                {
                    obj.SetActive(false);
                }
            }
            foreach (Slider obj in VanguardM17Level)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in VanguardM17)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.VanguardM17Parts -= SMG1PartsNeeded;
            MM.ResearchXp -= SMG1XpNeeded;
            SMG1PartsNeeded += 5;
            MM.VanguardM17Level += 1;
            MM.Xp += 50;
        }
    }

    public void UpgradeSMG2()
    {
        if (MM.ValkyrieM76Parts >= SMG2PartsNeeded && MM.ValkyrieM76Level <= 10 && MM.ResearchXp >= SMG2XpNeeded)
        {
            foreach (GameObject obj in SMG2Lock)
            {
                if (obj != null)
                {
                    obj.SetActive(false);
                }
            }
            foreach (Slider obj in ValkyrieM76Level)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in ValkyrieM76)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.ValkyrieM76Parts -= SMG2PartsNeeded;
            MM.ResearchXp -= SMG2XpNeeded;
            SMG2PartsNeeded += 5;
            MM.ValkyrieM76Level += 1;
            MM.Xp += 50;
        }
    }

    public void UpgradePistol1()
    {
        if (MM.ReaperP12Parts >= Pistol1PartsNeeded && MM.ReaperP12Level <= 10 && MM.ResearchXp >= Pistol1XpNeeded)
        {
            foreach (GameObject obj in Pistol1Lock)
            {
                if (obj != null)
                {
                    obj.SetActive(false);
                }
            }
            foreach (Slider obj in ReaperP12Level)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in ReaperP12)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.ReaperP12Parts -= Pistol1PartsNeeded;
            MM.ResearchXp -= Pistol1XpNeeded;
            Pistol1PartsNeeded += 5;
            MM.ReaperP12Level += 1;
            MM.Xp += 50;
        }
    }

    public void UpgradePistol2()
    {
        if (MM.PredatorP63Parts >= Pistol2PartsNeeded && MM.PredatorP63Level <= 10 && MM.ResearchXp >= Pistol2XpNeeded)
        {
            foreach (GameObject obj in Pistol2Lock)
            {
                if (obj != null)
                {
                    obj.SetActive(false);
                }
            }
            foreach (Slider obj in PredatorP63Level)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in PredatorP63)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.PredatorP63Parts -= Pistol2PartsNeeded;
            MM.ResearchXp -= Pistol2XpNeeded;
            Pistol2PartsNeeded += 5;
            MM.PredatorP63Level += 1;
            MM.Xp += 50;
        }
    }

    public void UpgradeAR1()
    {
        if (MM.ThunderboltA16Parts >= AR1PartsNeeded && MM.ThunderboltA16Level <= 10 && MM.ResearchXp >= AR1XpNeeded)
        {
            foreach (GameObject obj in AR1Lock)
            {
                if (obj != null)
                {
                    obj.SetActive(false);
                }
            }
            foreach (Slider obj in ThunderboltA16Level)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in ThunderboltA16)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.ThunderboltA16Parts -= AR1PartsNeeded;
            MM.ResearchXp -= AR1XpNeeded;
            AR1PartsNeeded += 5;
            MM.ThunderboltA16Level += 1;
            MM.Xp += 50;
        }
    }

    public void UpgradeAR2()
    {
        if (MM.GuardianA37Parts >= AR2PartsNeeded && MM.GuardianA37Level <= 10 && MM.ResearchXp >= AR2XpNeeded)
        {
            foreach (GameObject obj in AR2Lock)
            {
                if (obj != null)
                {
                    obj.SetActive(false);
                }
            }
            foreach (Slider obj in GuardianA37Level)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in GuardianA37)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.GuardianA37Parts -= AR2PartsNeeded;
            MM.ResearchXp -= AR2XpNeeded;
            AR2PartsNeeded += 5;
            MM.GuardianA37Level += 1;
            MM.Xp += 50;
        }
    }

    public void UpgradeShotGun1()
    {
        if (MM.PhantomS47Parts >= ShotGun1PartsNeeded && MM.PhantomS47Level <= 10 && MM.ResearchXp >= ShotGun1XpNeeded)
        {
            foreach (GameObject obj in ShotGun1Lock)
            {
                if (obj != null)
                {
                    obj.SetActive(false);
                }
            }
            foreach (Slider obj in PhantomS47Level)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in PhantomS47)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.PhantomS47Parts -= ShotGun1PartsNeeded;
            MM.ResearchXp -= ShotGun1XpNeeded;
            ShotGun1PartsNeeded += 5;
            MM.PhantomS47Level += 1;
            MM.Xp += 50;
        }
    }

    public void UpgradeShotGun2()
    {
        if (MM.HavocS13Parts >= ShotGun2PartsNeeded && MM.HavocS13Level <= 10 && MM.ResearchXp >= ShotGun2XpNeeded)
        {
            foreach (GameObject obj in ShotGun2Lock)
            {
                if (obj != null)
                {
                    obj.SetActive(false);
                }
            }
            foreach (Slider obj in HavocS13Level)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in HavocS13)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.HavocS13Parts -= ShotGun2PartsNeeded;
            MM.ResearchXp -= ShotGun2XpNeeded;
            ShotGun2PartsNeeded += 5;
            MM.HavocS13Level += 1;
            MM.Xp += 50;
        }
    }

    public void UpgradeRocketLancher1()
    {
        if (MM.SabreR23Parts >= RocketLancher1PartsNeeded && MM.SabreR23Level <= 10 && MM.ResearchXp >= RocketLancher1XpNeeded)
        {
            foreach (GameObject obj in RocketLancher1Lock)
            {
                if (obj != null)
                {
                    obj.SetActive(false);
                }
            }
            foreach (Slider obj in SabreR23Level)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in SabreR23)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.SabreR23Parts -= RocketLancher1PartsNeeded;
            MM.ResearchXp -= RocketLancher1XpNeeded;
            RocketLancher1PartsNeeded += 5;
            MM.SabreR23Level += 1;
            MM.Xp += 50;
        }
    }

    public void UpgradeRocketLancher2()
    {
        if (MM.TitanR30Parts >= RocketLancher2PartsNeeded && MM.TitanR30Level <= 10 && MM.ResearchXp >= RocketLancher2XpNeeded)
        {
            foreach (GameObject obj in RocketLancher2Lock)
            {
                if (obj != null)
                {
                    obj.SetActive(false);
                }
            }
            foreach (Slider obj in TitanR30Level)
            {
                if (obj != null)
                {
                    obj.value += 1f;
                }
            }
            foreach (GameObject obj in TitanR30)
            {
                if (obj != null)
                {
                    obj.GetComponent<CustomGun>().spread -= 0.01f;
                    obj.GetComponent<CustomGun>().timeBetweenShots -= 0.01f;
                    obj.GetComponent<CustomGun>().reloadTime -= 0.01f;
                }
            }
            MM.TitanR30Parts -= RocketLancher2PartsNeeded;
            MM.ResearchXp -= RocketLancher2XpNeeded;
            RocketLancher2PartsNeeded += 5;
            MM.TitanR30Level += 1;
            MM.Xp += 50;
        }
    }
}
