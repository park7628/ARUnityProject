using UnityEngine;

public class ObjectRotation : MonoBehaviour {

	public float planetSpeedRotation = 0.05f;

  // Update is called once per frame
  void LateUpdate () {

    var orbitSpeedInDaysPerSecond = ConfigManager.instance?.orbitSpeedInDaysPerSecond != null ? ConfigManager.instance.orbitSpeedInDaysPerSecond : DefaultValues.orbitSpeedInDaysPerSecond;

    transform.Rotate(-Vector3.up * Time.deltaTime * planetSpeedRotation * orbitSpeedInDaysPerSecond);
	}
}
