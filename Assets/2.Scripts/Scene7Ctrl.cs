using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scene7Ctrl : MonoBehaviour
{
    private static GameObject oxygen;
    private static GameObject cylinder;
    private static GameObject rtube;
    private static GameObject vial;
    //private static GameObject glass;
    public Button button;
    public Animator animator;
    public string animationTrigger;
    public Animator animator1;
    public string animationTrigger1;
    public Animator animator2;
    public string animationTrigger2;
    public TextMeshProUGUI ScriptTxt;
    

    void Start()
    {
        button.interactable = true;
        ScriptTxt.text = "다시 집기병을 물로 가득\r\n채우고 순수한 \r\n이산화탄소만 담는다.";
        oxygen = GameObject.FindWithTag("oxygen");
        cylinder = GameObject.FindWithTag("cylinder");
        vial = GameObject.FindWithTag("vial");
        //glass = GameObject.FindWithTag("glass");
        //oxygen.SetActive(false);
        cylinder.SetActive(false);
        animator2 = cylinder.GetComponent<Animator>();
        animator = oxygen.GetComponent<Animator>();
        animator.SetTrigger(animationTrigger);
        oxygen.GetComponent<Animator>().Play("oxygen");
        animator1 = vial.GetComponent<Animator>();
        button = button.GetComponent<Button>();
        button.onClick.AddListener(PlayAnimation8);

    }
    public void PlayAnimation8()
    {
        button.interactable = false;
        if (vial != null) 
        {
            animator1.SetTrigger(animationTrigger1);
            vial.GetComponent<Animator>().Play("vial2");
            Invoke("watering", 1.0f);
            Invoke("Scaling", 2.5f);
            Invoke("ChangeScene78", 7.5f);

        }
    }
    private void watering()
    {
        cylinder.SetActive(true);
    }
    private void Scaling()
    {
        animator2.SetTrigger(animationTrigger2);
        cylinder.GetComponent<Animator>().Play("vialcylinder");
    }
    private void ChangeScene78()
    {
        GameManager.isScene6 = false;
        GameManager.isScene7 = true;
        button.onClick.RemoveListener(PlayAnimation8);

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

                        PlayAnimation8();

                    }
                }
            }
        }
    }
}
