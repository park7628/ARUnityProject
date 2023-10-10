using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

public class HealthCheck : MonoBehaviour {

	[Header("Health Check. Make sure all appropriate scripts are attached to objects.")]
	public bool healthCheck;
	private List<UnassignedReferenceException> UnassignedReferenceExceptionList;
	// Use this for initialization
	void Start () {
		UnassignedReferenceExceptionList = new List<UnassignedReferenceException>();
		if(healthCheck)
		{
			var planets = GameObject.FindGameObjectsWithTag(ConstantValues.AstronomicalBodyTag);
			foreach(var planet in planets)
			{
				if(planet.GetComponent<IndividualPlanetData>() == null)
				{
					throw new UnassignedReferenceException(string.Format("Missing script {0} on astronomical body {1}", typeof(IndividualPlanetData).Name, planet.name));
				}
			}
		}
	}
}
