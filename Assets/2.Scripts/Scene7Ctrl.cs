using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene7Ctrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static public void touchglass_plate()
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
                    if (hit.collider.gameObject.tag == "glass_plate") //유리판 추가 필요
                    {
                        //집기병 입구가 유리판으로 막힘 애니메이션
                        GameManager.isScene7= true;

                    }
                }
            }
        }
    }
}
