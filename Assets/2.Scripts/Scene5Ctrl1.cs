using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scene5Ctrl1 : MonoBehaviour
{
    private static GameObject bubble;
    private static GameObject oxygen;
    private static GameObject cylinder;
    public Button button;
    public Animator animator;
    public string animationTrigger;

    public Animator animator1;
    public string animationTrigger1;

    public TextMeshProUGUI ScriptTxt;
    public GameObject WarningPanel;
    public GameObject GuidePanel;

    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        button.interactable = false;
        button.gameObject.SetActive(false);
        WarningPanel.SetActive(true);
        GuidePanel.SetActive(false);


        ScriptTxt.text = "핀치 집게를 조절하여\r\n묽은 과산화 수소수를 \r\n조금씩 흘려 보낸다.";
        bubble = GameObject.FindWithTag("bubble");
        oxygen = GameObject.FindWithTag("oxygen");
        cylinder = GameObject.FindWithTag("cylinder");
        bubble.SetActive(false);
        oxygen.SetActive(false);
        animator = oxygen.GetComponent<Animator>();
        animator1 = cylinder.GetComponent<Animator>();
        button = button.GetComponent<Button>();
        button.onClick.AddListener(PlayAnimation6);

    }
    public void PlayAnimation6()
    {
        button.interactable = false;
        if (oxygen != null)
        {
            bubble.SetActive(true);
            Invoke("isoxygen", 2.5f);
            Invoke("isanimation", 2.5f);

            Invoke("Scaling", 4.2f);
            Invoke("ChangeScene56", 8.0f);
        }

    }
    private void isanimation()
    {
        animator.SetTrigger(animationTrigger);
        oxygen.GetComponent<Animator>().Play("oxygen");
    }
    private void isoxygen()
    {
        ScriptTxt.text = "삼각 플라스크에서 산소가 \r\n만들어지고 호스를 타고 \r\n기체가 이동한다.";
        oxygen.SetActive(true);
    }
    private void Scaling()
    {
        animator1.SetTrigger(animationTrigger1);
        cylinder.GetComponent<Animator>().Play("vialcylinder");

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
