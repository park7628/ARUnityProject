using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Detailed camera input controller.
/// </summary>
public class DetailedCameraInputController : MonoBehaviour
{
    public float xSpeed = 40.0f;
    public float ySpeed = 40.0f;

    private double x = 80.0f;
    private double y = 50.0f;

    Quaternion rotation;
    Vector3 position;

    private bool isRotating;

    private float distance;
    
    // Use this for initialization
    void Start()
    {
        Cursor.visible = true;

        var angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;

        // Make the rigid body not change rotation
        if (GetComponent<Rigidbody>())
        SetPosition();
    }

    private void SetPosition()
    {
        rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler((float)y, (float)x, 0), Time.deltaTime * ConfigManager.instance.rotationSpeed);

        position = rotation * new Vector3(0.0f, 0.0f, - ConfigManager.instance.distance) + PlanetManager.instance.selectedPlanet.position;

        transform.rotation = rotation;
        transform.position = position;
    }

    void LateUpdate()
    {
        SetPosition();

            x = transform.eulerAngles.y;
            y = transform.eulerAngles.x;
                if (Input.GetMouseButton(0))
                {
                    x += Input.GetAxis("Mouse X") * xSpeed;
                    y -= Input.GetAxis("Mouse Y") * ySpeed;
                }
                if (Input.GetAxis("Mouse ScrollWheel") != 0)
                {
                    float scrollSpeed = Input.GetAxis("Mouse ScrollWheel");
                    ZoomInOut(scrollSpeed);
                }
            

            #if UNITY_IOS || UNITY_ANDROID	
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    x += Input.GetAxis("Mouse X") * xSpeed;
                    y -= Input.GetAxis("Mouse Y") * ySpeed;
                }
            #endif
        
        // Mobile pinch to zoom
    
        MobileZoomInOut();

    }

    private void MobileZoomInOut()
    {
        if (Input.touchCount == 2)
        {
            // Get the first touch
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            // Calculate magnitude

            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;
            ZoomInOut(deltaMagnitudeDiff);
         }
    }

    private void ZoomInOut(float scrollSpeed)
    {
        // minDistanceForSelectedPlanet is used for the same zoom in/out experience for all planets regardless their size
        ConfigManager.instance.distance -= scrollSpeed * ConfigManager.instance.minDistanceForSelectedPlanet * ConfigManager.instance.zoomSpeed;

        ConfigManager.instance.distance = Mathf.Clamp(
            ConfigManager.instance.distance,
            ConfigManager.instance.minDistanceForSelectedPlanet/ConfigManager.instance.minDistanceForPlanets,
            ConfigManager.instance.maxDistanceForPlanets *  ConfigManager.instance.minDistanceForSelectedPlanet);
     }
}
