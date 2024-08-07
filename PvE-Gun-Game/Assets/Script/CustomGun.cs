using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CustomGun : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;

    [Header("Bullet")]
    public GameObject bullet;

    [Header("Bullet Force")]
    public float shootForce, upwardForce;

    [Header("Gun Stats")]
    public float timeBetweenShooting, spread, reloadTime, timeBetweenShots;
    public int magazineSize, bulletsPerTap;
    public bool allowButtonHold;

    int bulletsLeft, bulletsShot;

    [Header("Bools")]
    bool shooting, readyToShoot, reloading;

    [Header("Ref")]
    public Transform attackPoint;
    public Transform cameraTransform;

    [Header("Graphics")]
    public GameObject muzzleFlash;
    public Slider slider;
    public Slider crosshairs1;
    public Slider crosshairs2;
    public Slider crosshairs3;
    public Slider crosshairs4;
    //public TextMeshProUGUI rToReload;
    //public GameObject rToreloadText;

    [Header("Ammo")]
    public bool heavyBullets;
    public bool lightBullets;
    public bool mediumBullets;
    public bool shells;
    public bool rockets;


    //bug fixing :D
    public bool allowInvoke = true;

    private void Awake()
    {
        bulletsLeft = magazineSize;
        readyToShoot = true;
        MM = mainManager.GetComponent<MainManager>();
    }

    private void Update()
    {
        MyInput();
    }
    private void MyInput()
    {

        if (allowButtonHold) shooting = Input.GetKey(KeyCode.Mouse0);
        else shooting = Input.GetKeyDown(KeyCode.Mouse0);

        if (Input.GetKeyDown(KeyCode.R) && bulletsLeft < magazineSize && !reloading) Reload();

        if (readyToShoot && shooting && !reloading && bulletsLeft <= 0) Reload();

        if (readyToShoot && shooting && !reloading && bulletsLeft > 0)
        {
            bulletsShot = 0;

            if (heavyBullets == true && MM.HeavyBullets >= 1)
            {
                MM.HeavyBullets -= 1;
                Shoot();
            }
            if (lightBullets == true && MM.LightBullets >= 1)
            {
                MM.LightBullets -= 1;
                Shoot();
            }
            if (mediumBullets == true && MM.MediumBullets >= 1)
            {
                MM.MediumBullets -= 1;
                Shoot();
            }
            if (shells == true && MM.Shells >= 1)
            {
                MM.Shells -= 1;
                Shoot();
            }
            if (rockets == true && MM.Rockets >= 1)
            {
                MM.Rockets -= 1;
                Shoot();
            }
        }
    }

    private void Shoot()
    {
        readyToShoot = false;

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)); //Just a ray through the middle of your current view
        RaycastHit hit;


        Vector3 targetPoint;
        if (Physics.Raycast(ray, out hit))
            targetPoint = hit.point;
        else
            targetPoint = ray.GetPoint(75); //Just a point far away from the player

        Vector3 directionWithoutSpread = targetPoint - attackPoint.position;

        float x = Random.Range(-spread, spread);
        float y = Random.Range(-spread, spread);

        Vector3 directionWithSpread = directionWithoutSpread + new Vector3(x, y, 0); //Just add spread to last direction

        GameObject currentBullet = Instantiate(bullet, attackPoint.position, Quaternion.identity); //store instantiated bullet in currentBullet
        currentBullet.transform.forward = directionWithSpread.normalized;

        currentBullet.GetComponent<Rigidbody>().AddForce(directionWithSpread.normalized * shootForce, ForceMode.Impulse);
        currentBullet.GetComponent<Rigidbody>().AddForce(Camera.main.transform.up * upwardForce, ForceMode.Impulse);

        if (muzzleFlash != null)
            Instantiate(muzzleFlash, attackPoint.position, Quaternion.identity);

        bulletsLeft--;
        bulletsShot++;
        StartCoroutine(GuiTimer(timeBetweenShooting));
        StartCoroutine(CrossHairTimer(timeBetweenShooting));
        if (allowInvoke)
        {
            Invoke("ResetShot", timeBetweenShooting);
            allowInvoke = false;
        }

        if (bulletsShot < bulletsPerTap && bulletsLeft > 0)
            Invoke("Shoot", timeBetweenShots);
    }

    private IEnumerator GuiTimer(float timeBetweenShots)
    {
        slider.maxValue = timeBetweenShots;
        float frac = timeBetweenShots / 40;
        for (int i = 0; i < 40; i++)
        {
            float percent =(float)i * frac;
            slider.value = percent;
            yield return new WaitForSeconds(frac);
        }
        slider.value = 0;
    }

    private IEnumerator CrossHairTimer(float timeBetweenShots)
    {
        crosshairs1.maxValue = timeBetweenShots;
        float frac = timeBetweenShots / 40;
        for (int i = 40; i > 40; i--)
        {
            float percent = (float)i * frac;
            crosshairs1.value = percent;
            yield return new WaitForSeconds(frac);
        }
        crosshairs1.value = crosshairs1.maxValue;
    }

    private IEnumerator ReloadTimer(float reloadTime)
    {
        slider.maxValue = reloadTime;
        float frac = reloadTime / 100;
        for (int i = 100; i > 0; i--)
        {
            float percent = (float)i * frac;
            slider.value = percent;
            yield return new WaitForSeconds(frac);
        }
        slider.value = slider.maxValue;
    }

    private void ResetShot()
    {
        readyToShoot = true;
        allowInvoke = true;
    }

    private void Reload()
    {
        StartCoroutine(ReloadTimer(reloadTime));
        reloading = true;
        Invoke("ReloadFinished", reloadTime); //Invoke ReloadFinished function with your reloadTime as delay
    }
    private void ReloadFinished()
    {
        bulletsLeft = magazineSize;
        reloading = false;
    }
}
