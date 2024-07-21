using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] private LayerMask Interactable;
    [SerializeField] private LayerMask Collectable;

    MainManager IM;
    public GameObject mainManager;
    public GameObject player;

    void Start()
    {
        IM = mainManager.GetComponent<MainManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main == null) return;

        RaycastHit hit;

        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * 1000);
        if (Physics.SphereCast(ray, 0.5f, out hit, 10, Interactable + Collectable))
        {

            if (Interactable.value == (1 << hit.collider.gameObject.layer))
            {

                LootBox Lbox = hit.collider.GetComponent<LootBox>();
                if (Lbox != null)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (hit.distance < Lbox.useRange)
                        {
                            Debug.Log("Open");
                            Lbox.OpenBox();

                        }
                    }

                }

                AmmoBox Abox = hit.collider.GetComponent<AmmoBox>();
                if (Abox != null)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (hit.distance < Abox.useRange)
                        {
                            Debug.Log("Open");
                            Abox.OpenBox();

                        }
                    }
                }
            }


        if (Collectable.value == (1 << hit.collider.gameObject.layer))
        {

            CollectWoodPlank WP = hit.collider.GetComponent<CollectWoodPlank>();
            if (WP != null)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (hit.distance < WP.pickUpRange)
                    {
                        Debug.Log("Open");
                        WP.CollectItem();

                    }
                }

            }

            CollectAmmo CA = hit.collider.GetComponent<CollectAmmo>();
            if (CA != null)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (hit.distance < CA.pickUpRange)
                    {
                        Debug.Log("Open");
                        CA.CollectItem();

                    }
                }



            }
        }
        }
    }
}
