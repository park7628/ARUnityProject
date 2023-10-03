using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronomicalBody {

	/// <summary>
	/// Hold reference for mesh renderer for planet
	/// </summary>
	/// <value></value>
	public List<MeshRenderer> meshRenderers {get;set;}

	/// <summary>
	/// Planet game object.
	/// </summary>
	/// <value></value>
	public GameObject gameObject {get;set;}
}
