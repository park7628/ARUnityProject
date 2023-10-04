using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Scene9Ctrl1 : MonoBehaviour
{

    public Button button;

    private static GameObject watchglass;
    private static GameObject incense;

    public Animator animator1;
    public Animator animator2;
    public string animationTrigger1;
    public string animationTrigger2;
    public GameObject fire;

    public TextMeshProUGUI ScriptTxt;

    // Start is called before the first frame update
    void Start()
    {
        button.interactable = true;
        ScriptTxt.text = "이산화탄소의 성질을 알아보기 위해 향을 집기병 안에 넣어본다. 향의 불이 꺼지는 것을 확인 할 수 있다.";
        watchglass = GameObject.FindWithTag("glass2");
        incense = GameObject.FindWithTag("incense");

        animator1 = watchglass.GetComponent<Animator>();
        animator2 = incense.GetComponent<Animator>();

        button = button.GetComponent<Button>();

        button.onClick.AddListener(PlayAnimation10);
    }

    private void PlayAnimation10()
    {

        //UnityEngine.Debug.Log("애니메이션 함수 들어옴");

        if (watchglass != null && incense != null)
        {
            //UnityEngine.Debug.Log("settrigger");
            animator1.SetTrigger(animationTrigger1);
            watchglass.GetComponent<Animator>().Play("scene9glass");
            if (watchglass.GetComponent<Outline>().enabled)
            {
                watchglass.GetComponent<Outline>().enabled = false;
            }
            if (watchglass.GetComponent<ObjectFlickering>().enabled)
            {
                watchglass.GetComponent<ObjectFlickering>().enabled = false;
            }

            button.onClick.AddListener(PlayAnimation11);
            button.onClick.RemoveListener(PlayAnimation10);
        }

    }

    private void PlayAnimation11()
    {

        //UnityEngine.Debug.Log("애니메이션 함수 들어옴");
        button.interactable = false;

        if (watchglass != null && incense != null)
        {
            //UnityEngine.Debug.Log("settrigger");
            animator2.SetTrigger(animationTrigger2);
            incense.GetComponent<Animator>().Play("incense");

            if (incense.GetComponent<Outline>().enabled)
            {
                incense.GetComponent<Outline>().enabled = false;
            }
            if (incense.GetComponent<ObjectFlickering>().enabled)
            {
                incense.GetComponent<ObjectFlickering>().enabled = false;
            }

            Invoke("firefalse", 2.0f );
        }

    }

    private void firefalse()
    {
        fire.SetActive(false);
        Invoke("ChangeScene910", 3.0f);
    }

    private void ChangeScene910()
    {
        GameManager.isScene8 = false;
        GameManager.isScene9 = true;

        button.onClick.RemoveListener(PlayAnimation11);
    }

    // Update is called once per frame
    void Update()
    {
        touchWATCHINCENSE();
    }

    private void touchWATCHINCENSE()
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
                    if (hit.collider.gameObject.tag == "glass2")
                    {
                        if (watchglass != null && incense != null)
                        {
                            PlayAnimation10();
                        }
                    }
                    else if (hit.collider.gameObject.tag == "incense")
                    {
                        if (watchglass != null && incense != null)
                        {
                            PlayAnimation11();
                        }

                    }
                }
            }
        }
    }
}
