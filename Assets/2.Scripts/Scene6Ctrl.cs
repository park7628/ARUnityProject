using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6Ctrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static public void touchvial()
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
    }
}
