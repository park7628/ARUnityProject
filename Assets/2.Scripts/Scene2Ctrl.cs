using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Scene2Ctrl : MonoBehaviour
{
    private static GameObject gum;
    public Button button;
    public Animator animator;
    public string animationTrigger;

    public static GameObject flask;

    void Start()
    {
        
        gum = GameObject.FindWithTag("gum_cover");
        flask = GameObject.FindWithTag("flask");

        animator = flask.GetComponent<Animator>();

        button = button.GetComponent<Button>();
        button.onClick.AddListener(PlayAnimation3);
    }
 

    public void PlayAnimation3()
    {
        
            UnityEngine.Debug.Log("Scene2버튼 클릭");
            if (gum != null)
            {
                animator.SetTrigger(animationTrigger);
                flask.GetComponent<Animator>().Play("gum");
                
                Invoke("ChangeScene23", 5.0f);


            }
        
    }
    private void ChangeScene23()
    {
        
        
        GameManager.isScene1 = false;
        GameManager.isScene2 = true;
        button.onClick.RemoveListener(PlayAnimation3);


    }

    /*public static void touchgum_cover()
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
                    if (hit.collider.gameObject.tag == "gum_cover")
                    {
                        if (gum != null)
                        {
                            gum.GetComponent<Animator>().Play("yflask");
                            
                        }
                        GameManager.isScene2 = true;
                    }
                }
            }
        }
    }*/
}
