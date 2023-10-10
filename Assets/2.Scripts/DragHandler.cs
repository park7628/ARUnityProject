using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using static UnityEditor.Progress;

public class DragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
{
    Transform _startParent;
    public static GameObject _itemBeingDragged;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
