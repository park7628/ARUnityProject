using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scene6Ctrl : MonoBehaviour
{
    private static GameObject oxygen;
    private static GameObject cylinder;
    //private static GameObject rtube;
    private static GameObject vial;
    //private static GameObject glass;
    public Button button;
    public Animator animator;
    public string animationTrigger;
    //public Animator animator1;
    public Animator animator2;
    //public string animationTrigger1;
    public string animationTrigger2;
    public TextMeshProUGUI ScriptTxt;

    void Start()
    {
        button.interactable = true;
        ScriptTxt.text = "처음 집기병에 찬 기체는\r\n원래 플라스크 안에 있던 \r\n기체이기 때문에 버린다.";
        oxygen = GameObject.FindWithTag("oxygen");
        cylinder = GameObject.FindWithTag("cylinder");
        //rtube = GameObject.FindWithTag("rtube");
        vial = GameObject.FindWithTag("vial");
        //glass = GameObject.FindWithTag("glass");
        //oxygen.SetActive(false);
        cylinder.SetActive(false);
        animator = oxygen.GetComponent<Animator>();
        animator.SetTrigger(animationTrigger);
        oxygen.GetComponent<Animator>().Play("oxygen");
        //animator1 = rtube.GetComponent<Animator>();
        animator2 = vial.GetComponent<Animator>();
        button = button.GetComponent<Button>();
        button.onClick.AddListener(PlayAnimation7);

    }
    public void PlayAnimation7()
    {
        button.interactable = false;
        if (vial != null) 
        {
            //animator1.SetTrigger(animationTrigger1);
            //rtube.GetComponent<Animator>().Play("rtube");
            animator2.SetTrigger(animationTrigger2);
            vial.GetComponent<Animator>().Play("vial");
            //animator.enabled = false;
            //oxygen.SetActive(false);
            Invoke("ChangeScene67", 3.0f);
        }

    }

    private void ChangeScene67()
    {
        GameManager.isScene5 = false;
        GameManager.isScene6 = true;
        button.onClick.RemoveListener(PlayAnimation7);

    }
    void Update()
    {
        touchvial();
    }

    public void touchvial()
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
                    if (hit.collider.gameObject.tag == "vial")
                    {
                        PlayAnimation7();
                    }
                }
            }
        }
    }
}
