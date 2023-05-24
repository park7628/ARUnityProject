using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4Ctrl : MonoBehaviour
{
    private static GameObject gwasan;
    private static GameObject funnelliquid;

    // Start is called before the first frame update
    void Start()
    {
        gwasan = GameObject.FindWithTag("gwasanhwa");
        funnelliquid = GameObject.FindWithTag("funnelliquid");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
    }
}
