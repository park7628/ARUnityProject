using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class SlotManager : MonoBehaviour, IDropHandler
{
    public Image _icon;
    public Sprite after_img;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("SlotManagerScript");
        var item = DragHandler._itemBeingDragged;
        if (item != null)
        {
            _icon.sprite = after_img;
            Debug.Log("change");
            //_icon.sprite = item.sprite;
            _icon.enabled = true;
        }
        else
        {
            _icon.sprite = after_img;

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
