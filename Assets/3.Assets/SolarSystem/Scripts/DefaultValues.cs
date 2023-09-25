using UnityEngine;

public class DefaultValues : MonoBehaviour {

	public const float minimumDistanceForOverviewCamera = 52.5f;
  public const float orbitSpeedInDaysPerSecond = 85.1f;

  private const float mercuryEarthRadius = 0.3829f;

	public static void SetDefaultValues()
	{
		GameObject.Find("Mercury").GetComponent<IndividualPlanetData>().earthRadiusRatio = mercuryEarthRadius;
	}

	public static Quaternion OrbitCameraLightPosition()
	{
		return new Quaternion(5.61f, -89.97f, 4.43f, 0);
	}

	public static Vector3 OverviewCameraPosition()
	{
		return new Vector3(192,72,149);
	}
}
