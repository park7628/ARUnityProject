using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scene2Ctrl : MonoBehaviour
{
    private static GameObject gum;
    public Button button;
    public Animator animator;
    public string animationTrigger;

    public static GameObject flask;
    public TextMeshProUGUI ScriptTxt;

    void Start()
    {
        button.interactable = true;
        ScriptTxt.text = "��ü�� ���� �ʵ���\r\n��������\r\n�ö�ũ �Ա��� �� ���´�.";
        gum = GameObject.FindWithTag("gum_cover");
        flask = GameObject.FindWithTag("flask");

        animator = flask.GetComponent<Animator>();

        button = button.GetComponent<Button>();
        button.onClick.AddListener(PlayAnimation3);
    }
 

    public void PlayAnimation3()
    {
        button.interactable = false;
        //UnityEngine.Debug.Log("Scene2��ư Ŭ��");
        if (gum != null)
            {
                animator.SetTrigger(animationTrigger);
                flask.GetComponent<Animator>().Play("gum");
            if (gum.GetComponent<Outline>().enabled)
            {
                gum.GetComponent<Outline>().enabled = false;
            }
            if (gum.GetComponent<ObjectFlickering>().enabled)
            {
                gum.GetComponent<ObjectFlickering>().enabled = false;
            }
            if (flask.GetComponent<Outline>().enabled)
            {
                flask.GetComponent<Outline>().enabled = false;
            }
            if (flask.GetComponent<ObjectFlickering>().enabled)
            {
                flask.GetComponent<ObjectFlickering>().enabled = false;
            }
            Invoke("ChangeScene23", 3.5f);


            }
        
    }
    private void ChangeScene23()
    {
        
        
        GameManager.isScene1 = false;
        GameManager.isScene2 = true;
        button.onClick.RemoveListener(PlayAnimation3);


    }
    void Update()
    {
        touchgum_cover();
    }
    public void touchgum_cover()
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
                    if (hit.collider.gameObject.tag == "flask" || hit.collider.gameObject.tag == "gum_cover")
                    {
                        if (gum != null)
                        {
                            PlayAnimation3();
                        }
                       
                    }
                }
            }
        }
    }
}
