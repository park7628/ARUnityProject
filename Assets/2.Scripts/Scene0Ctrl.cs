using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class Scene0Ctrl : MonoBehaviour
{
    
    public static GameObject flask;
    public static GameObject gameobject;

    // Start is called before the first frame update
    void Start()
    {
        flask = GameObject.FindWithTag("flask");
        gameobject = GameObject.FindWithTag("gameobject");
    }

    // Update is called once per frame
    void Update()
    {
    }


    public static void touchYFlask()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit hit;
                Ray touchray = Camera.main.ScreenPointToRay(touch.position);

                if (Physics.Raycast(touchray, out hit))
                {
                    if (hit.collider.gameObject.tag == "Y_Flask")
                    {

                        if (flask != null && gameobject != null) 
                        {
                            flask.GetComponent<Animator>().Play("YFLASK1");
                            gameobject.SetActive(false);
                        }
                        GameManager.isScene0= true;
                    }
                }
            }
        }

        
    }
}
