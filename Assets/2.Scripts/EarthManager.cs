using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthManager : MonoBehaviour
{

    public GameObject earth;
    //private static GameObject arrow1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //toucharrow();
    }



    public void toucharrow()
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
                    if (hit.collider.gameObject.tag == "arrow")
                    {
                        //if (arrow1 != null)
                        //{
                            earth.transform.Rotate(-Vector3.up * 30.0f);
                        //}
                    }
                }
            }
        }
    }

    public void Rearth()
    {
        earth.transform.Rotate(-Vector3.up * 30.0f);
    }


}
