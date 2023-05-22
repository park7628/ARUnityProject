using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Ctrl : MonoBehaviour
{
    private static GameObject Water;
    private static GameObject Mangan;

    void Start()
    {
        Water = GameObject.FindWithTag("Water");
        Mangan = GameObject.FindWithTag("Mangan");
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
                        if (Water != null)
                        {
                            Water.GetComponent<Animator>().Play("Water");
                        }
                    }
                    if (hit.collider.gameObject.tag == "Mangan")
                    {
                        if (Mangan != null)
                        {
                            Mangan.GetComponent<Animator>().Play("MANG");
                        }
                        GameManager.isScene1 = true;
                    }
                }
            }
        }
    }
}
