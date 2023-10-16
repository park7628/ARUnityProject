﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class SpaceEquipmentButton : MonoBehaviour
{
    public ARRaycastManager arRaycaster;
    public GameObject SunP;
    public GameObject EarthP;
    public GameObject MoonP;


    public void OnClickSunP()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRaycaster.Raycast(screenCenter, hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            Pose placementPose = hits[0].pose;


            SunP.SetActive(true);
            //Vector3 newPosition = new Vector3(placementPose.position.x, placementPose.position.y + 0.5f, placementPose.position.z); //���� ����
            //Instantiate(Funnel, newPosition, placementPose.rotation); // ���μ��� // 테이블에서는 0.3f..?

            Instantiate(SunP, placementPose.position, placementPose.rotation);

        }
    }

    public void OnClickEarthP()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRaycaster.Raycast(screenCenter, hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            Pose placementPose = hits[0].pose;


            EarthP.SetActive(true);
            //Vector3 newPosition = new Vector3(placementPose.position.x, placementPose.position.y + 0.5f, placementPose.position.z);
            //Instantiate(glass_tube, newPosition, placementPose.rotation);

            Instantiate(EarthP, placementPose.position, placementPose.rotation);
        }
    }

    public void OnClickMoonP()
    {
        Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        arRaycaster.Raycast(screenCenter, hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            Pose placementPose = hits[0].pose;


            MoonP.SetActive(true);
            //Vector3 newPosition = new Vector3(placementPose.position.x, placementPose.position.y + 0.5f, placementPose.position.z);
            //Instantiate(ironring, newPosition, placementPose.rotation);

            Instantiate(MoonP, placementPose.position, placementPose.rotation);
        }
    }

}