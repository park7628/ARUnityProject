using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class LabEquipmentButton : MonoBehaviour
{

    public ARRaycastManager arRaycaster;
    public GameObject Funnel;
    public GameObject glass_tube;
    public GameObject ironring;
    public GameObject pinch_all;
    public GameObject retortstand;
    public GameObject rtube;
    public GameObject tube1;
    public GameObject tube2;
    public GameObject Vial;
    public GameObject WaterTank;
    public GameObject Y_Flask;

    public void OnClickFunnel()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRaycaster.Raycast(screenCenter, hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            Pose placementPose = hits[0].pose;
            

            Funnel.SetActive(true);
            Vector3 newPosition = new Vector3(placementPose.position.x, placementPose.position.y + 0.5f, placementPose.position.z); //새로 수정
            Instantiate(Funnel, newPosition, placementPose.rotation); // 새로수정

            //Instantiate(Funnel, placementPose.position, placementPose.rotation);
            
        }
    }

    public void OnClickGlasstube()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRaycaster.Raycast(screenCenter, hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            Pose placementPose = hits[0].pose;
            

            glass_tube.SetActive(true);
            Vector3 newPosition = new Vector3(placementPose.position.x, placementPose.position.y + 0.5f, placementPose.position.z);
            Instantiate(glass_tube, newPosition, placementPose.rotation);

            //Instantiate(glass_tube, placementPose.position, placementPose.rotation);
        }
    }

    public void OnClickIronring()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRaycaster.Raycast(screenCenter, hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            Pose placementPose = hits[0].pose;
            

            ironring.SetActive(true);
            Vector3 newPosition = new Vector3(placementPose.position.x, placementPose.position.y + 0.5f, placementPose.position.z);
            Instantiate(ironring, newPosition, placementPose.rotation);

            //Instantiate(ironring, placementPose.position, placementPose.rotation);
        }
    }

    public void OnClickPinchall()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRaycaster.Raycast(screenCenter, hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            Pose placementPose = hits[0].pose;
            

            pinch_all.SetActive(true);
            Vector3 newPosition = new Vector3(placementPose.position.x, placementPose.position.y + 0.5f, placementPose.position.z);
            Instantiate(pinch_all, newPosition, placementPose.rotation);

            //Instantiate(pinch_all, placementPose.position, placementPose.rotation);
        }
    }

    public void OnClickRetortstand()
    {   
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRaycaster.Raycast(screenCenter, hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            Pose placementPose = hits[0].pose;
            

            retortstand.SetActive(true);
            Vector3 newPosition = new Vector3(placementPose.position.x, placementPose.position.y + 0.5f, placementPose.position.z);
            Instantiate(retortstand, newPosition, placementPose.rotation);

            //Instantiate(retortstand, placementPose.position, placementPose.rotation);
        }
    }

    public void OnClickRtube()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRaycaster.Raycast(screenCenter, hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            Pose placementPose = hits[0].pose;
            

            rtube.SetActive(true);
            Vector3 newPosition = new Vector3(placementPose.position.x, placementPose.position.y + 0.5f, placementPose.position.z);
            Instantiate(rtube, newPosition, placementPose.rotation);

            //Instantiate(rtube, placementPose.position, placementPose.rotation);
        }
    }

    public void OnClickTube1()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRaycaster.Raycast(screenCenter, hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            Pose placementPose = hits[0].pose;
            

            tube1.SetActive(true);
            Vector3 newPosition = new Vector3(placementPose.position.x, placementPose.position.y + 0.5f, placementPose.position.z);
            Instantiate(tube1, newPosition, placementPose.rotation);

            //Instantiate(tube1, placementPose.position, placementPose.rotation);
        }
    }

    public void OnClickTube2()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRaycaster.Raycast(screenCenter, hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            Pose placementPose = hits[0].pose;
            

            tube2.SetActive(true);
            Vector3 newPosition = new Vector3(placementPose.position.x, placementPose.position.y + 0.5f, placementPose.position.z);
            Instantiate(tube2, newPosition, placementPose.rotation);

            //Instantiate(tube2, placementPose.position, placementPose.rotation);
        }
    }

    public void OnClickVial()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRaycaster.Raycast(screenCenter, hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            Pose placementPose = hits[0].pose;
            

            Vial.SetActive(true);
            Vector3 newPosition = new Vector3(placementPose.position.x, placementPose.position.y + 0.55f, placementPose.position.z);
            Instantiate(Vial, newPosition, placementPose.rotation);

            //Instantiate(Vial, placementPose.position, placementPose.rotation);
        }
    }

    public void OnClickWatertank()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRaycaster.Raycast(screenCenter, hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            Pose placementPose = hits[0].pose;
            

            WaterTank.SetActive(true);
            Vector3 newPosition = new Vector3(placementPose.position.x, placementPose.position.y + 0.65f, placementPose.position.z);
            Instantiate(WaterTank, newPosition, placementPose.rotation);

            //Instantiate(WaterTank, placementPose.position, placementPose.rotation);
        }
    }

    public void OnClickYflask()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRaycaster.Raycast(screenCenter, hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            Pose placementPose = hits[0].pose;
            

            Y_Flask.SetActive(true);
            Vector3 newPosition = new Vector3(placementPose.position.x, placementPose.position.y + 0.55f, placementPose.position.z);
            Instantiate(Y_Flask, newPosition, placementPose.rotation);

            //Instantiate(Y_Flask, placementPose.position, placementPose.rotation);
        }
    }
}
