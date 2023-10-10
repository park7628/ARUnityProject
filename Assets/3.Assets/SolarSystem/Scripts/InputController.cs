using UnityEngine;

public class InputController : MonoBehaviour {

	private double x = 30.0f;
    private double y = 20.0f;

	private bool isRotating;

	public float xSpeed = 10.0f;
    public float ySpeed = 10.0f;

	Quaternion rotation;

	[HideInInspector]
	public Vector3 position;

	float distance = 150;

	float zoomSpeed = 5;

	LineRenderer currentSelectedLineRenderer = null;

	// Use this for initialization
	void Start () {
		var angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if(this.GetComponent<Camera>().isActiveAndEnabled)
		{
			SetTheCameraPositionBasedOnInput();
			ObjectInfo();
		}
	}

	void SetTheCameraPositionBasedOnInput()
	{
    var orbitSpeedInDaysPerSecond = ConfigManager.instance?.orbitSpeedInDaysPerSecond != null ? ConfigManager.instance.orbitSpeedInDaysPerSecond : DefaultValues.orbitSpeedInDaysPerSecond;

    rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler((float)y, (float)x, 0), Time.deltaTime * orbitSpeedInDaysPerSecond);

		position = rotation * new Vector3(0.0f, 0.0f, - distance);

		transform.rotation = rotation;
        transform.position = position;

		x = transform.eulerAngles.y;
        y = transform.eulerAngles.x;

		if (Input.GetMouseButton(0))
        {
            x += Input.GetAxis("Mouse X") * xSpeed;
            y -= Input.GetAxis("Mouse Y") * ySpeed;
        }

		#if UNITY_IOS || UNITY_ANDROID	
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            x += Input.GetAxis("Mouse X") * xSpeed;
            y -= Input.GetAxis("Mouse Y") * ySpeed;
        }
		#endif

		if (Input.GetAxis("Mouse ScrollWheel") > 0 && !ZoomLevelReached())
        {
            distance -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        }
		else if(Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			distance -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
		}

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

			distance += deltaMagnitudeDiff;
         }
    }

	/// <summary>
	/// Performing action when planet is selected on overview camera mode
	/// </summary>
	void ObjectInfo()
	{
		Ray ray = CameraManager.instance.OrbitCamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
		var objectsHighligthed = Physics.RaycastAll(ray);
        var raycast = Physics.Raycast(ray, 500, LayerMask.NameToLayer("UI"));
		if(raycast)
		{
			SoundManager.instance.PlayHoverEffectSound(true);

			var objectHighlighted = objectsHighligthed[0].collider.transform;
			var selectedObject = PlanetManager.instance.GetPlanet(objectHighlighted.name);

			// special requirement for Sun

			if(selectedObject && selectedObject.name.Equals("Sun"))
			{
				UIManager.instance.SetHighlightedObjectName(objectHighlighted.name);
				UIManager.instance.SetLabelNextToObject(objectHighlighted.name);

				// Switch to detailed camera view when clicked
				if(Input.GetMouseButtonUp(0))
				{
					UIManager.instance.SwitchToDetailedPlanetView(selectedObject.name);
				}

				return;
			}

			if(selectedObject)
			{
				var followOrbitComponent = selectedObject.GetComponent<FollowOrbit>();

				var orbitToFollow = followOrbitComponent != null? followOrbitComponent.orbitToFollow : null;

				if(orbitToFollow)
				{
					// now we have an access to line renderer component
					var lineRenderer = GameObject.Find(orbitToFollow.name);

					if(lineRenderer)
					{
						currentSelectedLineRenderer = lineRenderer.GetComponent<LineRenderer>();
            lineRenderer.GetComponent<LineRenderer>().startWidth = 0.45f;
            lineRenderer.GetComponent<LineRenderer>().endWidth = 0.45f;
            
            // set name on UI panel
            UIManager.instance.SetHighlightedObjectName(objectHighlighted.name);
						UIManager.instance.SetLabelNextToObject(objectHighlighted.name);
					}
				}
			}

			// Switch to detailed camera view when clicked
			if(raycast && Input.GetMouseButtonUp(0))
			{
				UIManager.instance.SwitchToDetailedPlanetView(selectedObject.name);
				UIManager.instance.DisablePlanetLabel();
			}
		}
		else
		{
			SoundManager.instance.PlayHoverEffectSound(false);

			// set line renderer to default state
			if(currentSelectedLineRenderer != null)
			{
        currentSelectedLineRenderer.startWidth = 0.25f;
        currentSelectedLineRenderer.endWidth = 0.25f;

        UIManager.instance.DisablePlanetLabel();
			}
		}
	} 

	private bool ZoomLevelReached()
	{
		if(Vector3.Distance(this.GetComponent<Camera>().transform.position, PlanetManager.instance.GetPlanet("Sun").transform.position) <= DefaultValues.minimumDistanceForOverviewCamera)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}
