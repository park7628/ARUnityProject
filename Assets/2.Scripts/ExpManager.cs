using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ExpManager : MonoBehaviour
{

    private GameObject Obj;
    Vector3 pos = new Vector3(0, 0, 0);

    public ARRaycastManager arRaycaster;
    //private int buttonpress;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    public void OnClickListener()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> press = new List<ARRaycastHit>();
        arRaycaster.Raycast(screenCenter, press, TrackableType.Planes);
        /*
        buttonpress++;
         */
        switch (press.Count) //buttonpress
        {
            case 1:
                pos = new Vector3(-0.184f, 0.4271f, 0);
                Obj = GameObject.Find("funnel");
                Obj.transform.position = Vector3.Lerp(Obj.transform.position, pos, 1f);
                Debug.Log("1 움직임");
                break;

            case 2:
                pos = new Vector3(-0.1839f, 0.26259f, 0);
                Obj = GameObject.Find("tube1");
                Obj.transform.position = Vector3.Lerp(Obj.transform.position, pos, 1f);
                Debug.Log("2 움직임");
                break;

            case 3:
                pos = new Vector3(-0.2018f, 0.2631f, 0);
                Obj = GameObject.Find("pinch_all");
                Obj.transform.position = Vector3.Lerp(Obj.transform.position, pos, 1f);
                Debug.Log("3 움직임");
                break;

            case 4:
                pos = new Vector3(-0.1839f, 0.1557f, 0);
                Obj = GameObject.Find("glasstube");
                Obj.transform.position = Vector3.Lerp(Obj.transform.position, pos, 1f);
                Debug.Log("4 움직임");
                break;

            case 5:
                pos = new Vector3(-0.2029f, 0.131f, -0.0065f);
                Obj = GameObject.Find("YFlask");
                Obj.transform.position = Vector3.Lerp(Obj.transform.position, pos, 1f);
                Debug.Log("5 움직임");
                break;

            case 6:
                pos = new Vector3(0.043f, 0.1154f, 0.001878f);
                Obj = GameObject.Find("tube2");
                Obj.transform.position = Vector3.Lerp(Obj.transform.position, pos, 1f);
                Debug.Log("6 움직임");
                break;

            case 7:
                pos = new Vector3(0.1894f, 0.0911f, 0.0006f);
                Obj = GameObject.Find("rtube");
                Obj.transform.position = Vector3.Lerp(Obj.transform.position, pos, 1f);
                Debug.Log("7 움직임");
                break;

            case 8:
                pos = new Vector3(0.228f, 0.014f, 0);
                Obj = GameObject.Find("watertank");
                Obj.transform.position = Vector3.Lerp(Obj.transform.position, pos, 1f);
                Debug.Log("8 움직임");
                break;

            case 9:
                pos = new Vector3(0.3206f, 0.2224f, 0);
                Obj = GameObject.Find("vial");
                Obj.transform.position = Vector3.Lerp(Obj.transform.position, pos, 1f);
                Debug.Log("9 움직임");
                break;
            
             
        }



    }


}
