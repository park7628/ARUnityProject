using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scene5Ctrl : MonoBehaviour
{
    private static GameObject bubble;
    private static GameObject oxygen;
    private static GameObject cylinder;
    public Button button;
    public Animator animator;
    public string animationTrigger;

    public TextMeshProUGUI ScriptTxt;
    public GameObject WarningPanel;

    public GameObject GuidePanel;

    // Start is called before the first frame update
    void Start()
    {
        button.interactable = false;
        button.gameObject.SetActive(false);
        WarningPanel.SetActive(true);
        GuidePanel.SetActive(false);
            
        
        ScriptTxt.text = "핀치 집게를 조절하여\r\n진한 식초를 \r\n조금씩 흘려 보낸다.";
        bubble = GameObject.FindWithTag("bubble");
        oxygen = GameObject.FindWithTag("oxygen");
        cylinder = GameObject.FindWithTag("cylinder");
        bubble.SetActive(false);
        oxygen.SetActive(false);
        animator = oxygen.GetComponent<Animator>();
        button = button.GetComponent<Button>();
        button.onClick.AddListener(PlayAnimation6);

    }
    public void PlayAnimation6()
    {
        if (oxygen != null)
        {
            bubble.SetActive(true);
            Invoke("isoxygen", 2.5f);
            Invoke("isanimation", 2.5f);
            InvokeRepeating("Scaling", 4.2f, 1.5f);
            Invoke("ChangeScene56", 10.0f);
        }

    }
    private void isanimation()
    {
        animator.SetTrigger(animationTrigger);
        oxygen.GetComponent<Animator>().Play("oxygen");
    }
    private void isoxygen()
    {
        ScriptTxt.text = "삼각 플라스크에서 \r\n이산화탄소가 만들어지고 \r\n호스를 타고 기체가 \r\n이동한다.";
        oxygen.SetActive(true);
    }
    private void Scaling()
    {

        cylinder.transform.localScale -= new Vector3(0.0f, 0.005f, 0.0f);
        //if (i < 6)
        //{
        //    cylinder.transform.localScale -= new Vector3(0.0f, 0.005f, 0.0f);
        //}
        //i++;
    }
    private void ChangeScene56()
    {
        GameManager.isScene4 = false;
        GameManager.isScene5 = true;
        button.onClick.RemoveListener(PlayAnimation6);
    }
    // Update is called once per frame
    void Update()
    {
        touchpinch();
    }

    public void touchpinch()
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
                    if (hit.collider.gameObject.tag == "pinch")
                    {
                        if (bubble != null && oxygen != null)
                        {
                            PlayAnimation6();
                        }

                    }
                }
            }
        }
    }
}
