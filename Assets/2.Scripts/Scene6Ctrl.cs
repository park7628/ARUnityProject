using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    void Start()
    {
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
        if (vial != null) //rtube 빠지고 
        {
            //animator1.SetTrigger(animationTrigger1);
            //rtube.GetComponent<Animator>().Play("rtube");
            animator2.SetTrigger(animationTrigger2);
            vial.GetComponent<Animator>().Play("vial");
            //animator.enabled = false;
            //oxygen.SetActive(false);
            Invoke("ChangeScene67", 5.0f);
        }

    }

    private void ChangeScene67()
    {
        GameManager.isScene5 = false;
        GameManager.isScene6 = true;
        button.onClick.RemoveListener(PlayAnimation7);

    }

    /*static public void touchvial()
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
                        //집기병이 수조 밖으로 나왔다가 다시 수조에 들어감(물이 다시 가득해짐) 애니메이션
                        GameManager.isScene6 = true;

                    }
                }
            }
        }
    }*/
}
