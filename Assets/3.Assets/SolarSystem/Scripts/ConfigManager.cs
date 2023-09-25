using UnityEngine;

public class ConfigManager : MonoBehaviour {


	[Range(3f, 45f)]
	public float distance = 5f;
	[Range(3f, 45f)]
	public float maxDistanceForPlanets = 45f;
	[Range(3f, 45f)]
	public float minDistanceForPlanets = 2f;
	[Range(0.05f, 0.3f)]
	public float zoomSpeed = 0.1f;
	[Range(0.05f, 25)]
  public float rotationSpeed = 0.8f;


	[HideInInspector]
	public float minDistanceForSelectedPlanet = 3f;
	public static ConfigManager instance = null;

	[Header("Mobile settings")]
	
	public float minFov = 40;
	public float maxFov = 80;
	public float mobileMouseZoomSpeed = 1;

	[Header("Orbit speed")]
	[Tooltip("It takes 365.25 days to orbit Sun for Earth. If this value is set to 365.25 it will take 1 second for Earth to orbit Sun.")]

	[Header("Set default values.")]
	public bool defaultPlanetEarthRatios;

	public float orbitSpeedInDaysPerSecond = DefaultValues.orbitSpeedInDaysPerSecond;

	void Awake()
	{
		if(instance == null)
		{
			instance = this;
		}
		else if(instance != this)
		{
			Destroy(gameObject);
		}

		if(defaultPlanetEarthRatios)
		{
			DefaultValues.SetDefaultValues();
		}
	}

}
