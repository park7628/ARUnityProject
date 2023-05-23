using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3Ctrl : MonoBehaviour
{
    private static GameObject flask;
    private static GameObject gameobject;

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

    static public void touchYFlask()
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
                                gameobject.SetActive(true);
                            }
                            GameManager.isScene3 = true;
                        }

                        //삼각 플라스크가 장치 원래 자리에 돌아간다
                }
            }
        }
    }
}
