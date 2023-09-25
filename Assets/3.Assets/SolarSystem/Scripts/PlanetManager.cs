using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

/// <summary>
/// Planet switch.
/// </summary>
public class PlanetManager : MonoBehaviour
{
  GameObject MainCamera;

  [HideInInspector]
  public string planetName;

  public Light SunLight;

  public static PlanetManager instance = null;

  [HideInInspector]
  public Transform selectedPlanet;

  private List<AstronomicalBody> astronomicalBodies;

  private List<GameObject> satellites;

  void Start()
  {
    if (ConfigManager.instance == null)
    {
      Debug.LogError(ConstantValues.MissingConfigManager);
    }
  }
  void Awake()
  {
    if (instance == null)
    {
      instance = this;
    }
    else if (instance != this)
    {
      Destroy(gameObject);
    }

    astronomicalBodies = new List<AstronomicalBody>();
    satellites = new List<GameObject>();
    this.FindAllPlanets();
    this.FindAllSatellites();
    ToggleSatellites(false);
  }

  /// <summary>
  /// Assigns the planet camera coordinates.
  /// </summary>
  /// <param name="selectedPlanetName">Selected planet name.</param>
  public void AssignPlanetCameraCoordinates(string selectedPlanetName)
  {
    planetName = selectedPlanetName;

    GameObject planet = this.GetPlanet(selectedPlanetName);

    if (planet != null)
    {
      this.selectedPlanet = planet.transform;

      // set up initial distance to be minimum distance
      ConfigManager.instance.distance = Mathf.Max(ConfigManager.instance.minDistanceForPlanets * planet.transform.localScale.x, ConfigManager.instance.minDistanceForPlanets);
      ConfigManager.instance.minDistanceForSelectedPlanet = ConfigManager.instance.distance;

      // Switch off flare if sun is selected

      DisableSunFlare(selectedPlanetName);
    }
  }

  public void DisableSunFlare(string selectedPlanetName)
  {
    if (selectedPlanetName == "Sun")
    {
      SunLight.enabled = false;
    }
    else
    {
      SunLight.enabled = true;
    }
  }

  public void ToggleFollowOrbitForEachPlanet(bool enabled)
  {
    foreach (var astronomicalBody in astronomicalBodies)
    {
      if (!enabled)
      {
        astronomicalBody.gameObject.GetComponent<FollowOrbit>().StopAllCoroutines();
      }
      else
      {
        astronomicalBody.gameObject.GetComponent<FollowOrbit>().StartCoroutine(ConstantValues.FollowOrbitCoroutine);
      }
    }
  }

  /// <summary>
  /// Function to set up real planet radius. Use it when switching to detailed camera view.
  /// </summary>
  public void SetRealPlanetRadius(string planetName)
  {
    GameObject planet = this.GetPlanet(planetName);
    float scale = planet.GetComponent<IndividualPlanetData>().earthRadiusRatio;
    planet.gameObject.transform.localScale = new Vector3(scale, scale, scale);

  }

  /// <summary>
  /// Function to set up overview planet radius. Use it when switching to overview camera view.
  /// </summary>
  public void SetOverwiewPlanetsRadius()
  {
    foreach (var astronomicalBody in astronomicalBodies)
    {
      float scale = astronomicalBody.gameObject.GetComponent<IndividualPlanetData>().overwievCameraRatioSize;
      astronomicalBody.gameObject.transform.localScale = new Vector3(scale, scale, scale);
    }
  }

  private void FindAllPlanets()
  {
    foreach (var planet in GameObject.FindGameObjectsWithTag(ConstantValues.AstronomicalBodyTag))
    {
      var meshRenderers = new List<MeshRenderer>();
      var meshRenderer = planet.GetComponent<MeshRenderer>();
      if (meshRenderer != null)
      {
        meshRenderers.Add(meshRenderer);
      }

      // also add all children mesh renderers

      meshRenderers.AddRange(planet.GetComponentsInChildren<MeshRenderer>());
      this.astronomicalBodies.Add(new AstronomicalBody() { gameObject = planet, meshRenderers = meshRenderers }); ;
    }
  }

  private void FindAllSatellites()
  {
    this.satellites.AddRange(GameObject.FindGameObjectsWithTag(ConstantValues.SatelliteTag));
  }

  public void ToggleRotateAround(bool enabled)
  {
    foreach (var astronomicalBody in this.astronomicalBodies)
    {
      var rotateAround = astronomicalBody.gameObject.GetComponent<RotateAround>();
      if (rotateAround)
        astronomicalBody.gameObject.GetComponent<RotateAround>().enabled = enabled;
    }
  }

  public void ToggleSatellites(bool enabled, string planetName = "")
  {
    if (enabled)
    {
      foreach (var satellite in this.satellites)
      {
        if (satellite.gameObject.GetComponentInParent<Transform>().name == planetName)
        {
          satellite.GetComponent<MeshRenderer>().enabled = true;
        }
      }
    }
    else
    {
      this.satellites.ForEach(m => m.GetComponent<MeshRenderer>().enabled = enabled);
    }
  }

  public GameObject GetPlanet(string planetName)
  {
    return GameObject.Find(planetName);
  }

  public void DisableAllPlanetsExceptSelected(string planetName)
  {
    foreach (var astronomicalBody in astronomicalBodies)
    {
      ToggleMovementOnOrbit(astronomicalBody.gameObject, false);
      if (!astronomicalBody.gameObject.name.Equals(planetName))
      {
        astronomicalBody.meshRenderers.ForEach(m => m.enabled = false);

        // toggle children elements for Sun
        if (astronomicalBody.gameObject.name.Equals("Sun"))
        {
          ToggleSun(astronomicalBody, false);
        }
      }
      else
      {
        astronomicalBody.meshRenderers.ForEach(m => m.enabled = true);
        // also enable sun when Sun is selected
        if (planetName.Equals("Sun"))
        {
          ToggleSun(astronomicalBody, true);
        }
      }
    }

    // also enable planet if satelite was selected
    var selectedAstronomicalBody = GetPlanet(planetName);
    if (selectedAstronomicalBody.tag == ConstantValues.SatelliteTag)
    {
      var parentAstronomicalBody = selectedAstronomicalBody.transform.parent.gameObject;
      var parentAstronomicalBodyChildrens = parentAstronomicalBody.GetComponentsInChildren<MeshRenderer>();
      for (int i = 0; i < parentAstronomicalBodyChildrens.Length; i++)
      {
        parentAstronomicalBodyChildrens[i].enabled = true;
      }
    }
  }

  private static void ToggleSun(AstronomicalBody astronomicalBody, bool enabled)
  {
    astronomicalBody.gameObject.SetActive(false);
    foreach (var childrenObject in astronomicalBody.gameObject.transform.GetComponentsInChildren<Transform>())
    {
      childrenObject.gameObject.SetActive(enabled);
    }
  }

  public void EnableAllPlanets()
  {
    foreach (var astronomicalBody in astronomicalBodies)
    {
      astronomicalBody.meshRenderers.ForEach(m => m.enabled = true);
      ToggleMovementOnOrbit(astronomicalBody.gameObject, true);

      // toggle children elements for Sun
      if (astronomicalBody.gameObject.name.Equals("Sun"))
      {
        ToggleSun(astronomicalBody, true);
      }
    }
  }

  public void EnablePlanet(string planetName)
  {
    GameObject planet = this.GetPlanet(planetName);
    planet.gameObject.GetComponent<MeshRenderer>().enabled = true;
  }

  public void ToggleMovementOnOrbit(GameObject astronomicalBody, bool enabled)
  {
    var followOrbit = astronomicalBody.gameObject.GetComponent<FollowOrbit>();
    if (followOrbit != null)
    {
      if (enabled)
      {
        followOrbit.StartCoroutine(ConstantValues.FollowOrbitCoroutine);
      }
      else
      {
        followOrbit.StopCoroutine(ConstantValues.FollowOrbitCoroutine);
      }
    }
  }
}
