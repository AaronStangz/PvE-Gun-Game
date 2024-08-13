using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunLevelManager : MonoBehaviour
{
    public GameObject mainManager;
    private MainManager MM;

    // ARS
    public List<Image> BlazeBreakerLevel;
    public List<Image> StormScorcherLevel;
    public List<Image> PulsefireLevel;
    // SMG
    public List<Image> SprayStrikerLevel;
    public List<Image> BuzzBlitzerLevel;
    public List<Image> RattleRipperLevel;
    // Pistols
    public List<Image> PowderPopperLevel;
    public List<Image> QuickdrawBlasterLevel;
    public List<Image> BoltBouncerLevel;
    // Shotguns
    public List<Image> BoomBusterLevel;
    public List<Image> BlastBarrelLevel;
    public List<Image> ThunderThumperLevel;
    // Snipers
    public List<Image> StormshotSniperLevel;
    public List<Image> ShadowSlicerLevel;
    public List<Image> EagleEyeLevel;

    private Dictionary<int, Color> levelColors = new Dictionary<int, Color>
    {
        { 3, Color.green},
        { 5, Color.blue},
        { 7, Color.magenta},
        { 10, Color.yellow }
    };

    private Dictionary<string, List<Image>> gunLevelLists;

    void Start()
    {
        MM = mainManager.GetComponent<MainManager>();

        gunLevelLists = new Dictionary<string, List<Image>>
        {
            { "BlazeBreakerLevel", BlazeBreakerLevel },
            { "StormScorcherLevel", StormScorcherLevel },
            { "PulsefireLevel", PulsefireLevel },
            { "SprayStrikerLevel", SprayStrikerLevel },
            { "BuzzBlitzerLevel", BuzzBlitzerLevel },
            { "RattleRipperLevel", RattleRipperLevel },
            { "PowderPopperLevel", PowderPopperLevel },
            { "QuickdrawBlasterLevel", QuickdrawBlasterLevel },
            { "BoltBouncerLevel", BoltBouncerLevel },
            { "BoomBusterLevel", BoomBusterLevel },
            { "BlastBarrelLevel", BlastBarrelLevel },
            { "ThunderThumperLevel", ThunderThumperLevel},
            { "StormshotSniperLevel", StormshotSniperLevel },
            { "ShadowSlicerLevel", ShadowSlicerLevel },
            { "EagleEyeLevel", EagleEyeLevel }
        };
    }

    void Update()
    {
        UpdateGunLevelColors("BlazeBreakerLevel", MM.BlazeBreakerLevel);
        UpdateGunLevelColors("StormScorcherLevel", MM.StormScorcherLevel);
        UpdateGunLevelColors("PulsefireLevel", MM.PulsefireLevel);
        UpdateGunLevelColors("SprayStrikerLevel", MM.SprayStrikerLevel);
        UpdateGunLevelColors("BuzzBlitzerLevel", MM.BuzzBlitzerLevel);
        UpdateGunLevelColors("RattleRipperLevel", MM.RattleRipperLevel);
        UpdateGunLevelColors("PowderPopperLevel", MM.PowderPopperLevel);
        UpdateGunLevelColors("QuickdrawBlasterLevel", MM.QuickdrawBlasterLevel);
        UpdateGunLevelColors("BoltBouncerLevel", MM.BoltBouncerLevel);
        UpdateGunLevelColors("BoomBusterLevel", MM.BoomBusterLevel);
        UpdateGunLevelColors("BlastBarrelLevel", MM.BlastBarrelLevel);
        UpdateGunLevelColors("ThunderThumperLevel", MM.ThunderThumperLevel);
        UpdateGunLevelColors("StormshotSniperLevel", MM.StormshotSniperLevel);
        UpdateGunLevelColors("ShadowSlicerLevel", MM.ShadowSlicerLevel);
        UpdateGunLevelColors("EagleEyeLevel", MM.EagleEyeLevel);
    }

    private void UpdateGunLevelColors(string gunLevelName, int level)
    {
        if (levelColors.ContainsKey(level) && gunLevelLists.ContainsKey(gunLevelName))
        {
            Color targetColor = levelColors[level];
            foreach (Image obj in gunLevelLists[gunLevelName])
            {
                if (obj != null)
                {
                    obj.color = targetColor;
                }
            }
        }
    }
}