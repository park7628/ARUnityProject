using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scene3Ctrl1 : MonoBehaviour
{
    private static GameObject flask;
    private static GameObject gameobject;
    public Button button;
    public Animator animator;
    public string animationTrigger;
    public TextMeshProUGUI ScriptTxt;

    // Start is called before the first frame update
    void Start()
    {

        ScriptTxt.text = "삼각 플라스크를 \r\n장치에 다시 연결한다.";
        flask = GameObject.FindWithTag("flask");
        gameobject = GameObject.FindWithTag("gameobject");
        gameobject.SetActive(false);
        animator = flask.GetComponent<Animator>();


        button = button.GetComponent<Button>();
        button.onClick.AddListener(PlayAnimation4);
    }

    public void PlayAnimation4()
    {
            if (flask != null)
            {
                animator.SetTrigger(animationTrigger);
                flask.GetComponent<Animator>().Play("yflask");
                Invoke("isgameObject", 1.7f);
                Invoke("ChangeScene34", 2.8f);
            }
        
    }
    private void isgameObject()
    {
        //gameobject.GetComponent<MeshRenderer>().enabled = true;
        gameobject.SetActive(true);
    }

    private void ChangeScene34()
    {
        GameManager.isScene2 = false;
        GameManager.isScene3 = true;
        button.onClick.RemoveListener(PlayAnimation4);
    }


    /*
    static public void touchYFlask()
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
                        if (hit.collider.gameObject.tag == "Y_Flask")
                        {

                            if (flask != null && gameobject != null)
                            {
                                flask.GetComponent<Animator>().Play("YFLASK1");
                                gameobject.SetActive(true);
                            }
                            GameManager.isScene3 = true;
                        }

                        //삼각 플라스크가 장치 원래 자리에 돌아간다
                }
            }
        }
    }*/
}
