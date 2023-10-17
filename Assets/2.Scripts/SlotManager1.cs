using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class SlotManager1 : MonoBehaviour, IDropHandler
{
    public Image _icon;
    public Sprite after_img1;
    public Sprite after_img2;
    public Sprite after_img3;
    public Sprite after_img4;
    public Sprite nullImg;
    public static int a1 = DragHandler.a;

    public GameObject slot1;
    

    GameObject ArrayManager;

    public void OnEndDrag(PointerEventData eventData)
    {
        //slot1.GetComponent<Image>().raycastTarget = true;
    }
    public void OnDrop(PointerEventData eventData)
    {
        ArrayManager = GameObject.Find("ArrayManager");

        //var item = DragHandler._itemBeingDragged;
        a1 = DragHandler.a;

        if (a1 == 1)
        {
            Debug.Log("접촉");
            _icon.sprite = after_img1;
            ArrayManager.GetComponent<ArrayManager>().CArray();
            //_icon.sprite = item.sprite;
            //_icon.enabled = true;
            //slot1.GetComponent<Image>().raycastTarget = false;

        }
        else if (a1 == 2)
        {
            _icon.sprite = after_img2;
            ArrayManager.GetComponent<ArrayManager>().CArray();
            //slot1.GetComponent<Image>().raycastTarget = false;
        }
        else if (a1 == 3)
        {
            _icon.sprite = after_img3;
            ArrayManager.GetComponent<ArrayManager>().CArray();
            //slot1.GetComponent<Image>().raycastTarget = false;
        }
        else
        {
            _icon.sprite = after_img4;
            ArrayManager.GetComponent<ArrayManager>().CArray();
            //slot1.GetComponent<Image>().raycastTarget = false;
        }
    }

    public void RemoveSlot()
    {
        _icon.sprite = nullImg;

        // 초기화 안 해주면 이미지 없는데 O/X 이미지 나옴
        a1 = 0;
    }
}
