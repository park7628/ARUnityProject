using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class SlotManager1 : MonoBehaviour, IDropHandler
{
    public Image _icon;
    public Sprite after_img1;
    public Sprite after_img2;
    public Sprite after_img3;
    public Sprite after_img4;
    public Sprite nullImg;
    public static int a1 = DragHandler.a;
    GameObject ArrayManager;


    public void OnDrop(PointerEventData eventData)
    {
        ArrayManager = GameObject.Find("ArrayManager");

        //var item = DragHandler._itemBeingDragged;
        a1 = DragHandler.a;

        if (a1 == 1)
        {
            _icon.sprite = after_img1;
            ArrayManager.GetComponent<ArrayManager>().CArray();
            //_icon.sprite = item.sprite;
            //_icon.enabled = true;
        }
        else if (a1 == 2)
        {
            _icon.sprite = after_img2;
            ArrayManager.GetComponent<ArrayManager>().CArray();

        }
        else if (a1 == 3)
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

    public void RemoveSlot()
    {
        _icon.sprite = nullImg;

        // 초기화 안 해주면 이미지 없는데 O/X 이미지 나옴
        a1 = 0;
    }
}
