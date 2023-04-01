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
            Instantiate(Funnel, placementPose.position, placementPose.rotation);
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
            Instantiate(glass_tube, placementPose.position, placementPose.rotation);
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
            Instantiate(ironring, placementPose.position, placementPose.rotation);
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
            Instantiate(pinch_all, placementPose.position, placementPose.rotation);
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
            Instantiate(retortstand, placementPose.position, placementPose.rotation);
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
            Instantiate(rtube, placementPose.position, placementPose.rotation);
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
            Instantiate(tube1, placementPose.position, placementPose.rotation);
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
            Instantiate(tube2, placementPose.position, placementPose.rotation);
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
            Instantiate(Vial, placementPose.position, placementPose.rotation);
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
            Instantiate(WaterTank, placementPose.position, placementPose.rotation);
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
            Instantiate(Y_Flask, placementPose.position, placementPose.rotation);
        }
    }
}
