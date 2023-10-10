using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour
{

  public Transform centerMass;
  public Transform revealingLight;

  public float rotationAroundPlanetSpeed = 1.0f;
  public float rotationAroundSunDays = 1.0f;
  public float defaultEarthYear = 365.25f;
  public float satelliteOrbitDistance = 1.8f;
  public float planetSunDistance = 100.0f;
  public float planetSpeedRotation = 1.0f;

  // Use this for initialization
  void Start()
  {

    //transform.position = (transform.position - sun.position).normalized * planetSunDistance + sun.position;
    rotationAroundPlanetSpeed = rotationAroundSunDays / defaultEarthYear;

    // For reveal light - must follow Planet and retain the same position
    if (revealingLight != null)
    {
      revealingLight.transform.LookAt(transform.position);
    }

  }

  // Update is called once per frame
  void LateUpdate()
  {
    var orbitSpeedInDaysPerSecond = ConfigManager.instance?.orbitSpeedInDaysPerSecond != null ? ConfigManager.instance.orbitSpeedInDaysPerSecond : DefaultValues.orbitSpeedInDaysPerSecond;

    transform.RotateAround(centerMass.position, Vector3.up, Time.deltaTime * ((defaultEarthYear / rotationAroundSunDays) * orbitSpeedInDaysPerSecond));

  }

}
