using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class SlotManager3 : MonoBehaviour, IDropHandler
{
    public Image _icon;
    public Sprite after_img1;
    public Sprite after_img2;
    public Sprite after_img3;
    public Sprite after_img4;
    public Sprite nullImg;
    public static int a3 = DragHandler.a;

    public GameObject slot3;


    GameObject ArrayManager;

    public void OnEndDrag(PointerEventData eventData)
    {
        //slot1.GetComponent<Image>().raycastTarget = true;
    }
    public void OnDrop(PointerEventData eventData)
    {
        ArrayManager = GameObject.Find("ArrayManager");

        //var item = DragHandler._itemBeingDragged;
        a3 = DragHandler.a;

        if (a3 == 1)
        {
            Debug.Log("����");
            _icon.sprite = after_img1;
            ArrayManager.GetComponent<ArrayManager>().CArray();
            //_icon.sprite = item.sprite;
            //_icon.enabled = true;
            //slot1.GetComponent<Image>().raycastTarget = false;

        }
        else if (a3 == 2)
        {
            _icon.sprite = after_img2;
            ArrayManager.GetComponent<ArrayManager>().CArray();
            //slot1.GetComponent<Image>().raycastTarget = false;
        }
        else if (a3 == 3)
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

        // �ʱ�ȭ �� ���ָ� �̹��� ���µ� O/X �̹��� ����
        a3 = 0;
    }
}