using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

  public Slider slider;

  public GameObject astronomicalBodyUiPanel;

  public GameObject astronomicalBodiesButtons;

  private GameObject[] orbits;

  public GameObject planetInfoPanel;

  public GameObject planetNameForCameraOrbitView;

  public Dropdown marsSatellites;
  public Dropdown jupiterSatellites;
  public static UIManager instance = null;

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
  }

  void Start()
  {
    if (ConfigManager.instance == null)
    {
      Debug.LogError(ConstantValues.MissingConfigManager);
    }
    else
    {
      ConfigManager.instance.orbitSpeedInDaysPerSecond = slider.value;

      slider.onValueChanged.AddListener(delegate
      {
        ConfigManager.instance.orbitSpeedInDaysPerSecond = slider.value;
      });
    }

    orbits = GameObject.FindGameObjectsWithTag(ConstantValues.OrbitTag);
    PlanetManager.instance.SetOverwiewPlanetsRadius();
    TogglePlanetInfoPanel(false);

    //disable ui panel if overview camera is selected by default
    if (CameraManager.instance.cameraMode.Equals(ConstantValues.CameraMode.Overview))
    {
      this.astronomicalBodiesButtons.SetActive(false);
      this.planetInfoPanel.SetActive(false);
    }
  }

  public void ToggleOrbits(bool enable)
  {
    foreach (var orbit in orbits)
    {
      orbit.SetActive(enable);
    }
  }

  public void SwitchToDetailedPlanetView(string astronomicalBody)
  {
    // Call UI Manager to disable orbits (line renderers)
    ToggleOrbits(false);

    TogglePlanetInfoPanel(true);

    CameraManager.instance.SwitchToMainCamera();

    PlanetManager.instance.DisableAllPlanetsExceptSelected(astronomicalBody);

    PlanetManager.instance.ToggleSatellites(true, astronomicalBody);

    PlanetManager.instance.ToggleRotateAround(true);

    PlanetInfo.instance.LoadTextToScrollBar(astronomicalBody);

    PlanetManager.instance.SetRealPlanetRadius(astronomicalBody);

    PlanetManager.instance.AssignPlanetCameraCoordinates(astronomicalBody);

    this.astronomicalBodiesButtons.SetActive(true);
    this.planetInfoPanel.SetActive(true);

  }

  public void SwitchToOrbitView()
  {
    if (CameraManager.instance.cameraMode.Equals(ConstantValues.CameraMode.Detailed))
    {
      ToggleOrbits(true);

      TogglePlanetInfoPanel(false);

      CameraManager.instance.SwitchToOrbitCamera();

      PlanetManager.instance.EnableAllPlanets();

      PlanetManager.instance.SetOverwiewPlanetsRadius();

      PlanetManager.instance.ToggleSatellites(false);

      PlanetManager.instance.ToggleRotateAround(false);

      PlanetManager.instance.DisableSunFlare("Sun");

      Vector3 cameraPosition = DefaultValues.OverviewCameraPosition();
      CameraManager.instance.OrbitCamera.transform.position = new Vector3(cameraPosition.x, cameraPosition.y, cameraPosition.z);

      this.astronomicalBodiesButtons.SetActive(false);
      this.planetInfoPanel.SetActive(false);

    }
  }

  /// <summary>
  /// Changes the satellites.
  /// </summary>
  /// <param name="planet">Planet.</param>
  public void ChangeSatellites(string planet)
  {
    switch (planet)
    {
      case "Mars":
        SwitchToDetailedPlanetView(marsSatellites.captionText.text);
        PlanetManager.instance.EnablePlanet(marsSatellites.captionText.text);
        PlanetManager.instance.EnablePlanet("Mars");
        break;
      case "Jupiter":
        SwitchToDetailedPlanetView(jupiterSatellites.captionText.text);
        PlanetManager.instance.EnablePlanet(jupiterSatellites.captionText.text);
        PlanetManager.instance.EnablePlanet("Jupiter");
        break;
      default:
        break;
    }

  }

  public void TogglePlanetInfoPanel(bool enabled)
  {
    this.planetInfoPanel.SetActive(enabled);
  }

  public void SetHighlightedObjectName(string name)
  {
    this.planetNameForCameraOrbitView.GetComponent<TextMesh>().text = name;
  }

  public void SetLabelNextToObject(string name)
  {
    var objectPosition = PlanetManager.instance.GetPlanet(name);

    this.planetNameForCameraOrbitView.transform.position = new Vector3(objectPosition.transform.position.x - objectPosition.transform.localScale.x * 2,
    objectPosition.transform.position.y - objectPosition.transform.localScale.y * 2,
    objectPosition.transform.position.z);

    this.planetNameForCameraOrbitView.transform.LookAt(CameraManager.instance.OrbitCamera.transform);

    // increase text size based on camera distance

    var distanceBetweenObjectAndCamera = Vector3.Distance(CameraManager.instance.OrbitCamera.transform.position, objectPosition.transform.position);

    this.planetNameForCameraOrbitView.GetComponent<TextMesh>().characterSize = 0.02f * distanceBetweenObjectAndCamera;
  }

  public void DisablePlanetLabel()
  {
    this.planetNameForCameraOrbitView.GetComponent<TextMesh>().text = string.Empty;
  }
}
