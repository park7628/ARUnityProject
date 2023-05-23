using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene5Ctrl : MonoBehaviour
{
    private static GameObject bubble;
    private static GameObject oxygen;

    // Start is called before the first frame update
    void Start()
    {
        bubble = GameObject.FindWithTag("bubble");
        oxygen = GameObject.FindWithTag("oxygen");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static public void touchpinch()
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
                            bubble.SetActive(true); //�Ʒ� �ﰢ �ö�ũ�� ��������ȭ���Ҽ��� ���� �ִϸ��̼�
                            oxygen.SetActive(true);
                            oxygen.GetComponent<Animator>().Play("oxygen");
                        }
                        // ���� ��Ұ� �̵��ؼ� ȣ�� ������ ���� ������ �ִϸ��̼�(���ڱ���?)
                        GameManager.isScene5= true;

                    }
                }
            }
        }
    }
}
