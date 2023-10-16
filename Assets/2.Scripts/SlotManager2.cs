using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class SlotManager2 : MonoBehaviour, IDropHandler
{
    public Image _icon;
    public Sprite after_img1;
    public Sprite after_img2;
    public Sprite after_img3;
    public Sprite after_img4;
    public static int a2 = DragHandler.a;
    GameObject ArrayManager;


    public void OnDrop(PointerEventData eventData)
    {
        ArrayManager = GameObject.Find("ArrayManager");

        //var item = DragHandler._itemBeingDragged;
        a2 = DragHandler.a;

        if (a2 == 1)
        {
            _icon.sprite = after_img1;
            ArrayManager.GetComponent<ArrayManager>().CArray();

            //_icon.sprite = item.sprite;
            //_icon.enabled = true;
        }
        else if (a2 == 2)
        {
            _icon.sprite = after_img2;
            ArrayManager.GetComponent<ArrayManager>().CArray();
        }
        else if (a2 == 3)
        {
            _icon.sprite = after_img3;
            ArrayManager.GetComponent<ArrayManager>().CArray();

        }
        else
        {
            _icon.sprite = after_img4;
            ArrayManager.GetComponent<ArrayManager>().CArray();
        }
    }
}
