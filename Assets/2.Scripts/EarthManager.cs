using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthManager : MonoBehaviour
{

    public GameObject earth;

    public GameObject Day;
    public GameObject Night;

    private int count = 0;
    private int count1 = 0;

    //private static GameObject arrow1;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        toucharrow();
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
                        count1 += 1;
                        earth.transform.Rotate(-Vector3.up * 7.5f);

                        if (count % 12 == 4)
                        {
                            Day.SetActive(false);
                            Night.SetActive(true);
                        }

                        else if (count % 12 == 10)
                        {
                            Day.SetActive(true);
                            Night.SetActive(false);
                        }

                    }
                }
            }
        }
    }

    public void Rearth()
    {
        count += 1;
        earth.transform.Rotate(-Vector3.up * 30.0f);

        if (count % 12 == 4)
        {
            Day.SetActive(false);
            Night.SetActive(true);
        }
        else if (count % 12 == 10)
        {
            Day.SetActive(true);
            Night.SetActive(false);
        }
    }


}