using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4Ctrl : MonoBehaviour
{
    public static GameObject gwasan;

    // Start is called before the first frame update
    void Start()
    {
        gwasan = GameObject.FindWithTag("gwasanhwa");
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

                        if (gwasan != null)
                        {
                            gwasan.GetComponent<Animator>().Play("gwasanhwa");
                            
                        }
                        //묽은 과산화 수소수가 깔때기에 담긴다 애니메이션
                        GameManager.isScene4= true;

                    }
                }
            }
        }
    }
}
