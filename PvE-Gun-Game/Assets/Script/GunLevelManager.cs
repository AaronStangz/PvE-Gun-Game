using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunLevelManager : MonoBehaviour
{
    public GameObject mainManager;
    private MainManager MM;

    public List<Image> BlackhawkS14Level;
    public List<Image> SentinelS37Level;
    public List<Image> VanguardM17Level;
    public List<Image> ValkyrieM76Level;
    public List<Image> ReaperP12Level;
    public List<Image> PredatorP63Level;
    public List<Image> ThunderboltA16Level;
    public List<Image> GuardianA37Level;
    public List<Image> PhantomS47Level;
    public List<Image> HavocS13Level;
    public List<Image> SabreR23Level;
    public List<Image> TitanR30Level;

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
            { "BlackhawkS14Level", BlackhawkS14Level },
            { "SentinelS37Level", SentinelS37Level },
            { "VanguardM17Level", VanguardM17Level },
            { "ValkyrieM76Level", ValkyrieM76Level },
            { "ReaperP12Level", ReaperP12Level },
            { "PredatorP63Level", PredatorP63Level },
            { "ThunderboltA16Level", ThunderboltA16Level },
            { "GuardianA37Level", GuardianA37Level },
            { "PhantomS47Level", PhantomS47Level },
            { "HavocS13Level", HavocS13Level },
            { "SabreR23Level", SabreR23Level },
            { "TitanR30Level", TitanR30Level }
        };
    }

    void Update()
    {
        UpdateGunLevelColors("BlackhawkS14Level", MM.BlackhawkS14Level);
        UpdateGunLevelColors("SentinelS37Level", MM.SentinelS37Level);
        UpdateGunLevelColors("VanguardM17Level", MM.VanguardM17Level);
        UpdateGunLevelColors("ValkyrieM76Level", MM.ValkyrieM76Level);
        UpdateGunLevelColors("ReaperP12Level", MM.ReaperP12Level);
        UpdateGunLevelColors("PredatorP63Level", MM.PredatorP63Level);
        UpdateGunLevelColors("ThunderboltA16Level", MM.ThunderboltA16Level);
        UpdateGunLevelColors("GuardianA37Level", MM.GuardianA37Level);
        UpdateGunLevelColors("PhantomS47Level", MM.PhantomS47Level);
        UpdateGunLevelColors("HavocS13Level", MM.HavocS13Level);
        UpdateGunLevelColors("SabreR23Level", MM.SabreR23Level);
        UpdateGunLevelColors("TitanR30Level", MM.TitanR30Level);
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