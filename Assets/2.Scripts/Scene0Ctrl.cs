using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scene0Ctrl : MonoBehaviour
{

    private static GameObject flask;

    public Button button;

    public static GameObject gameobject;

    public Animator animator;

    public string animationTrigger;

    public TextMeshProUGUI ScriptTxt;

    // Start is called before the first frame update
    void Start()
    {
        button.interactable = true;
        ScriptTxt.text = "��ü �߻� ��ġ����\r\n�ﰢ �ö�ũ�� �и��Ѵ�.";
        flask = GameObject.FindWithTag("flask");
        gameobject = GameObject.FindWithTag("gameobject");

        animator = flask.GetComponent<Animator>();


        button = button.GetComponent<Button>();
        button.onClick.AddListener(PlayAnimation);

    }

    
    // Update is called once per frame
  
    public void PlayAnimation()
    {

        button.interactable = false;
        if (flask != null)
            {
                animator.SetTrigger(animationTrigger);
                flask.GetComponent<Animator>().Play("YFLASK1");
                gameobject.SetActive(false);
                Invoke("ChangeScene01", 4.5f);

                //StartCoroutine(WaitForAnimation(animator));
                // ������Ʈ�� �ִϸ��̼� ����
                //flask.GetComponent<Animator>().Play("YFLASK1");
                //flask.GetComponent<Animation>().Play(targetAnimation.name);
            }
        
    }
    private void ChangeScene01()
    {
        GameManager.isScene0 = true;
        button.onClick.RemoveListener(PlayAnimation);
    }

    /*IEnumerator WaitForAnimation(Animator animator)
    {
        while (animator.GetCurrentAnimatorStateInfo(0).IsName("YFLASK1"))
        {
            //��ȯ ���� �� ����Ǵ� �κ�
            
            yield return null;
        }
        

        while (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < (exitTime + TransitionDuration)) {
        //while (false == animator.IsInTransition(0)) { 

            //yield return new WaitForEndOfFrame();
            gameobject.SetActive(false);
            yield return null;
            }
        //gameobject.SetActive(false);
        
    }
    */
    void Update()
    {
        touchYFlask();
    }
    public void touchYFlask()
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
                        if (flask != null)
                        {
                            animator.SetTrigger(animationTrigger);
                            flask.GetComponent<Animator>().Play("YFLASK1");
                            gameobject.SetActive(false);
                            Invoke("ChangeScene01", 4.5f);

                            //StartCoroutine(WaitForAnimation(animator));
                            // ������Ʈ�� �ִϸ��̼� ����
                            //flask.GetComponent<Animator>().Play("YFLASK1");
                            //flask.GetComponent<Animation>().Play(targetAnimation.name);
                        }
                    }
                }
            }
        }


    }
}
