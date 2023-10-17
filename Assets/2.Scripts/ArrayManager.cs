using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ArrayManager : MonoBehaviour
{
    GameObject RemoveSlotMgr;
    GameObject OOImg;

    public void CArray()
    {
        var a1 = SlotManager1.a1;
        var a2 = SlotManager2.a2;
        RemoveSlotMgr = GameObject.Find("RemoveSlotMgr");


        if ((a1 == 2 && a2 == 3) || (a1 == 3 && a2 == 2))
        {
            Debug.Log("이산화탄소 발생");
            GameObject.Find("Canvas").transform.Find("True").gameObject.SetActive(true);
            Invoke("RemoveTF", 1f); // 2초 후 이미지 비활성화
        }
        else if ((a1 == 1 && a2 == 4) || (a1 == 4 && a2 == 1))
        {
            Debug.Log("산소 발생");
            GameObject.Find("Canvas").transform.Find("True").gameObject.SetActive(true);
            Invoke("RemoveTF", 1f); // 2초 후 이미지 비활성화
        }
        else if ((a1 == 1 && a2 == 2) || (a1 == 1 && a2 == 3) || (a1 == 2 && a2 == 1) || (a1 == 3 && a2 == 1) || (a1 == 2 && a2 == 4) || (a1 == 4 && a2 == 2) || (a1 == 3 && a2 == 4) || (a1 == 4 && a2 == 3))
        {
            Debug.Log("오답입니다");
            GameObject.Find("Canvas").transform.Find("False").gameObject.SetActive(true);
            Invoke("RemoveTF", 1f); // 2초 후 이미지 비활성화

        }

    }

    public void RemoveTF()
    {
        GameObject.Find("Canvas").transform.Find("True").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("False").gameObject.SetActive(false);

        RemoveSlotMgr.GetComponent<SlotManager1>().RemoveSlot();
        RemoveSlotMgr.GetComponent<SlotManager2>().RemoveSlot();

    }




}
