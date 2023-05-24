using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.ARFoundation;

public class PlaneCtrl : MonoBehaviour
{

    private ARPlaneManager planeManager;
    public Button turnoff;


    // Start is called before the first frame update
    void Awake()
    {
        planeManager = GetComponent<ARPlaneManager>();
    }
    
    void Start()
    {
        
    }
    public void TurnOff()
    {
        planeManager.enabled = false;

        foreach(ARPlane plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(planeManager.enabled);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
