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
                    if (hit.collider.gameObject.tag == "gwasanhwa") //������Ʈ �߰� �ʿ�
                    {

                        if (gwasan != null && funnelliquid != null)
                        {
                            gwasan.GetComponent<Animator>().Play("gwasanhwa"); //����ȭ ���Ҽ� ��Ŀ ������
                            funnelliquid.SetActive(true); //���� ����ȭ ���Ҽ��� �򶧱⿡ ���� �ִϸ��̼�
                        }
                        
                        GameManager.isScene4= true;

                    }
                }
            }
        }
    }
}
