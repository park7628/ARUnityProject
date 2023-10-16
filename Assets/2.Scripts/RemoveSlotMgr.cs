using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RemoveSlotMgr : MonoBehaviour
{
    public Image slot1;
    public Image slot2;
    public Sprite nullImg;
    public static int a1 = DragHandler.a;


    public void RemoveSlot()
    {
        slot1.sprite = nullImg;
        slot2.sprite = nullImg;
    }
}
