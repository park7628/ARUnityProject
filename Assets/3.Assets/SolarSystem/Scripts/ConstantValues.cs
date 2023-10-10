using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantValues : MonoBehaviour {

	public const string OrbitTag = "Orbit";
	public const string AstronomicalBodyTag = "AstronomicalBody";
	public const string FollowOrbitCoroutine = "MoveOnOrbit";
	public const string SatelliteTag = "Satellite";

	public const string SunLight = "SunLight";

	public enum CameraMode { Overview, Detailed};

  #region Errors
  public const string MissingConfigManager = "Config manager is missing. Please add empty game object and attach ConfigManager script. You can also preview Main scene that is localed under Assets - Scenes - Main, for guidance.";
  #endregion
}
