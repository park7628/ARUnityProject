using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
{
    Transform _startParent;
    public static GameObject _itemBeingDragged;

    public static int a = 0;


    public void OnBeginDrag(PointerEventData eventData)
    {
        
        _itemBeingDragged = gameObject;
        //_startParent = transform.parent;
        transform.SetParent(GameObject.FindGameObjectWithTag("UI Canvas").transform);
        GetComponent<Image>().raycastTarget = false;
        //_itemBeingDragged = gameObject;
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        // 현재 드래그되고있는 오브젝트 가져오기
        GameObject tempBtn = EventSystem.current.currentSelectedGameObject;

        // 태그로 비교
        if (tempBtn.CompareTag("hydrogenBtn"))
        {
            a = 1;
        }
        else if (tempBtn.CompareTag("hydrochloricBtn"))
        {
            a = 2;
        }
        else if (tempBtn.CompareTag("manganeseBtn"))
        {
            a = 3;
        }
        else if (tempBtn.CompareTag("limestoneBtn"))
        {
            a = 4;
        }

        transform.position = eventData.position;
    }


    // 드래그 후 놓았을 때 제자리로
    public void OnEndDrag(PointerEventData eventData)
    {
        _startParent = transform.parent;
        transform.SetParent(_startParent);
        transform.localPosition = Vector3.zero;

        _itemBeingDragged = null;

        GetComponent<Image>().raycastTarget = true;
    }
}
