using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2Ctrl : MonoBehaviour
{
    private static GameObject gum;
    

    void Start()
    {
        gum = GameObject.FindWithTag("gum_cover");
        
    }

    void Update()
    {

    }

    public static void touchgum_cover()
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
                    if (hit.collider.gameObject.tag == "gum_cover")
                    {
                        if (gum != null)
                        {
                            gum.GetComponent<Animator>().Play("yflask");
                            
                        }
                        GameManager.isScene2 = true;
                    }
                }
            }
        }
    }
}
