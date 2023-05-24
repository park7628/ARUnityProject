using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class Scene0Ctrl : MonoBehaviour
{

    public static GameObject flask;
    public AnimationClip targetAnimation;

    public Button button;

    public static GameObject gameobject;

    public Animator animator;

    public string animationTrigger;

    // Start is called before the first frame update
    void Start()
    {
        flask = GameObject.FindWithTag("flask");
        gameobject = GameObject.FindWithTag("gameobject");

        animator = flask.GetComponent<Animator>();


        button = GetComponent<Button>();
        //button.onClick.AddListener(PlayAnimation);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayAnimation()
    {
        if (flask != null)
        {
            animator.SetTrigger(animationTrigger);
            flask.GetComponent<Animator>().Play("YFLASK1");
            // 오브젝트의 애니메이션 실행
            //flask.GetComponent<Animator>().Play("YFLASK1");
            //flask.GetComponent<Animation>().Play(targetAnimation.name);
        }
    }


    public static void touchYFlask()
    {
        /*if (Input.touchCount > 0)
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
        }*/


    }
}
