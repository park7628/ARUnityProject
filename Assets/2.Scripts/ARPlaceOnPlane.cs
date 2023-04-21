using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARPlaceOnPlane : MonoBehaviour
{
    public ARRaycastManager arRaycaster;
    public GameObject test;
    private ARPlaneManager arPlaneManager;
    GameObject spawnObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlaceObjectByTouch();
        //UndateCenterObject();
    }

    private void PlaceObjectByTouch()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            List<ARRaycastHit> hits = new List<ARRaycastHit>();
            if(arRaycaster.Raycast(touch.position, hits, TrackableType.Planes))
            {
                Pose hitPose = hits[0].pose;

                if(!spawnObject)
                {
                    spawnObject = Instantiate(test, hitPose.position, hitPose.rotation);
                }
                else
                {
                    spawnObject.transform.position = hitPose.position;
                    spawnObject.transform.rotation = hitPose.rotation;

                    foreach (var plane in arPlaneManager.trackables)
                    {
                        plane.gameObject.SetActive(false);
                    }
                }
               
            }
        }
    }
    /*
    private void UndateCenterObject()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRaycaster.Raycast(screenCenter, hits, TrackableType.Planes);

        if (hits.Count >0)
        {
            Pose placementPose = hits[0].pose;
            placeObject.SetActive(true);
            placeObject.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        }
        
        else
        {
            placeObject.SetActive(false);
        }*/
    
}
