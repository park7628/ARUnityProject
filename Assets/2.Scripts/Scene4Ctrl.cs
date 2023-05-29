using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scene4Ctrl : MonoBehaviour
{
    private static GameObject gwasan;
    private static GameObject funnelliquid;

    public Button button;
    public Animator animator;
    public string animationTrigger;
    public TextMeshProUGUI ScriptTxt;

    // Start is called before the first frame update
    void Start()
    {
        ScriptTxt.text = "진한 식초를 \r\n깔때기에 붓는다.";
        gwasan = GameObject.FindWithTag("gwasanhwa");
        funnelliquid = GameObject.FindWithTag("funnelliquid");
        funnelliquid.SetActive(false);

        animator = gwasan.GetComponent<Animator>();


        button = button.GetComponent<Button>();
        button.onClick.AddListener(PlayAnimation5);
    }

    public void PlayAnimation5()
    {


        if (gwasan != null)
        {
            animator.SetTrigger(animationTrigger);
            gwasan.GetComponent<Animator>().Play("gwasanhwa");
            Invoke("isliquid", 2.5f);
            Invoke("ChangeScene45", 5.5f);
        }

    }
    private void isliquid()
    {
        //gameobject.GetComponent<MeshRenderer>().enabled = true;
        funnelliquid.SetActive(true);
    }

    private void ChangeScene45()
    {

        GameManager.isScene3 = false;
        GameManager.isScene4 = true;
        button.onClick.RemoveListener(PlayAnimation5);
    }

    // Update is called once per frame

    /*
    static public void touchGWASANHWA()
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
                    if (hit.collider.gameObject.tag == "gwasanhwa") //오브젝트 추가 필요
                    {

                        if (gwasan != null && funnelliquid != null)
                        {
                            gwasan.GetComponent<Animator>().Play("gwasanhwa"); //과산화 수소수 비커 움직임
                            funnelliquid.SetActive(true); //묽은 과산화 수소수가 깔때기에 담긴다 애니메이션
                        }
                        
                        GameManager.isScene4= true;

                    }
                }
            }
        }
    }*/
}
