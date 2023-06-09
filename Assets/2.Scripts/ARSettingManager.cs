using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARSettingManager : MonoBehaviour
{

    public ARPlaneManager arPlane;
    public Transform Indicator;
    List<ARRaycastHit> indicatorHits = new List<ARRaycastHit>();
    List<ARRaycastHit> originHits = new List<ARRaycastHit>();
    public ARRaycastManager arRaycater;
    public ARSessionOrigin arOrigin;

    //#region 바닥인식화면 ON OFF
    public void ShowPlane(bool b)
    {
        foreach (var plane in arPlane.trackables)
        {
            plane.gameObject.SetActive(b); 
        }
    }
    //#region 바닥 표시기
    //public void PlaceIndicator()
    //{
    //    arRaycater.Raycast(new Vector2(Screen.width * 0.5f, Screen.height * 0.5f), indicatorHits, TrackableType.Planes);

    //    if (indicatorHits.Count > 0)
    //    {
    //        Indicator.position = indicatorHits[0].pose.position;
    //        Indicator.rotation = indicatorHits[0].pose.rotation;
    //    }
    //}

    //public void PlaceIndicatorPrefab()
    //{
    //    Pose hitPose = indicatorHits[0].pose;
    //    Instantiate(spawnPrefab, hit)
    //}
    public void PlaceOrigin()
    {
        arRaycater.Raycast(new Vector2(Screen.width * 0.5f, Screen.height * 0.5f), originHits, TrackableType.Planes);
        if (originHits.Count > 0)
        {
            Pose hitpose = originHits[0].pose;
            arOrigin.MakeContentAppearAt(arOrigin.transform, hitpose.position, hitpose.rotation);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //PlaceIndicator();
    }

    //#endregion
}
