using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Ctrl : MonoBehaviour
{
    private static GameObject Water;
    private static GameObject liquid1;
    private static GameObject Mangan;
    private static GameObject mangan;

    void Start()
    {
        Water = GameObject.FindWithTag("Water");
        liquid1 = GameObject.FindWithTag("liquid1");
        Mangan = GameObject.FindWithTag("Mangan");
        mangan = GameObject.FindWithTag("mangan");
    }

    void Update()
    {

    }

    public static void touchWATERMANGANIZ()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit hit;
                Ray touchray = Camera.main.ScreenPointToRay(touch.position);

                if (Physics.Raycast(touchray, out hit))
                {
                    if (hit.collider.gameObject.tag == "Water")
                    {
                        if (Water != null && liquid1 != null)
                        {
                            Water.GetComponent<Animator>().Play("Water");
                            liquid1.SetActive(true);
                        }
                    }
                    if (hit.collider.gameObject.tag == "Mangan")
                    {
                        if (Mangan != null && mangan != null)
                        {
                            Mangan.GetComponent<Animator>().Play("MANG");
                            mangan.SetActive(true);
                        }
                        GameManager.isScene1 = true;
                    }
                }
            }
        }
    }
}
