using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.XR.ARFoundation;

using UnityEngine.XR.ARSubsystems;



public class TouchManager : MonoBehaviour

{

    //������ ��ü 

    //private GameObject placeObject;

    private ARRaycastManager raycastMgr;

    private List<ARRaycastHit> hits = new List<ARRaycastHit>();



    private bool Touched = false;

    private GameObject SelectedObj;

    [SerializeField] private Camera arCamera;



    void Start()
    {
        /*
        // ������ ť�긦 �Ҵ�

        placeObject = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // ť���� ũ�⸦ ���� 

        placeObject.transform.localScale = Vector3.one * 0.05f;
        */

        // AR Raycast Manager ���� 

        raycastMgr = GetComponent<ARRaycastManager>();

    }
    void Update()
    {

        if (Input.touchCount == 0) return;

        Touch touch = Input.GetTouch(0);



        //��ġ ���۽�

        if (touch.phase == TouchPhase.Began)
        {



            Ray ray;

            RaycastHit hitobj;



            ray = arCamera.ScreenPointToRay(touch.position);



            //Ray�� ���� ������Ʈ �ν�

            if (Physics.Raycast(ray, out hitobj))

            {

                //��ġ�� ���� ������Ʈ �̸��� Cube�� �����ϸ�
                /*
                if (hitobj.collider.name.Contains("Cube"))

                {
                */

                    //�� ������Ʈ�� SelectObj�� ���´� //��ġ�ϰ� �ִ´�

                    SelectedObj = hitobj.collider.gameObject;

                    Touched = true;

                /*}*/

                //�ƴϸ� ������Ʈ ���� �ƴ� �� ����
                /*
                else

                {

                    if (raycastMgr.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))

                    {

                        Instantiate(placeObject, hits[0].pose.position, hits[0].pose.rotation);

                    }

                }*/

            }

        }

        //��ġ�� ������ ��ġ ��.

        if (touch.phase == TouchPhase.Ended)

        {

            Touched = false;

        }



        if (raycastMgr.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))

        {

            //��ġ �� �ش� ������Ʈ ��ġ �ʱ�ȭ

            if (Touched)

            {

                SelectedObj.transform.position = hits[0].pose.position;

            }

        }

    }



}