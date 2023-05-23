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
                            bubble.SetActive(true); //아래 삼각 플라스크에 묽은과산화수소수가 찬다 애니메이션
                            oxygen.SetActive(true);
                            oxygen.GetComponent<Animator>().Play("oxygen");
                        }
                        // 점점 산소가 이동해서 호스 끝에서 공기 나오는 애니메이션(분자구조?)
                        GameManager.isScene5= true;

                    }
                }
            }
        }
    }
}
