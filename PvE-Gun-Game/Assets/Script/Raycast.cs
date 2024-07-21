using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] private LayerMask Interactable;
    [SerializeField] private LayerMask Collectable;

    MainManger IM;
    public GameObject mainManger;
    public GameObject player;

    void Start()
    {
        IM = mainManger.GetComponent<MainManger>();

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

                LootBox box = hit.collider.GetComponent<LootBox>();
                if (box != null)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (hit.distance < box.useRange)
                        {
                            Debug.Log("Open");
                            box.OpenBox();

                        }
                    }

                }
            }

        }


    }
}
