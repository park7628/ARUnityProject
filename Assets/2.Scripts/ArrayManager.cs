using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ArrayManager : MonoBehaviour
{
    GameObject RemoveSlotMgr;
    // GameObject OOImg;
    public GameObject LifeScoreMgr;

    public static int life = 3;

    public void CArray()
    {
        var a1 = SlotManager1.a1;
        var a2 = SlotManager2.a2;
        RemoveSlotMgr = GameObject.Find("RemoveSlotMgr");


        if ((a1 == 2 && a2 == 3) || (a1 == 3 && a2 == 2))
        {
            Debug.Log("이산화탄소 발생");
            GameObject.Find("Canvas").transform.Find("True").gameObject.SetActive(true);
            Co2O2GameManager.missFire[Co2O2GameManager.checkFireRange] = 0;
            Debug.Log("ArrayManger에서 missFire의 값을 0으로 바꿨습니다.");
            // 점수 +10
            LifeScoreMgr.GetComponent<Co2O2GameManager>().GetScore();

            Invoke("RemoveTF", 1f); // 2초 후 이미지 비활성화
        }
        else if ((a1 == 1 && a2 == 4) || (a1 == 4 && a2 == 1))
        {
            Debug.Log("산소 발생");
            GameObject.Find("Canvas").transform.Find("True").gameObject.SetActive(true);

            Co2O2GameManager.missFire[Co2O2GameManager.checkFireRange] = 0;
            Debug.Log("ArrayManger에서 missFire의 값을 0으로 바꿨습니다.");

            // 점수 +10
            LifeScoreMgr.GetComponent<Co2O2GameManager>().GetScore();

            Invoke("RemoveTF", 1f); // 2초 후 이미지 비활성화
        }
        else if ((a1 == 1 && a2 == 2) || (a1 == 1 && a2 == 3) || (a1 == 2 && a2 == 1) || (a1 == 3 && a2 == 1) || (a1 == 2 && a2 == 4) || (a1 == 4 && a2 == 2) || (a1 == 3 && a2 == 4) || (a1 == 4 && a2 == 3))
        {
            Debug.Log("오답입니다");
            GameObject.Find("Canvas").transform.Find("False").gameObject.SetActive(true);
            Co2O2GameManager.missFire[Co2O2GameManager.checkFireRange] = 0; // 밑에서 점수를 뺼거니까 오브젝트가 없어지면서 빠질 점수를 제거
            // 게임오버 후 life가 0일 때 3으로 다시 초기화
            if (life == 0)
            {
                life = 3;
            }

            // 목숨 -1
            //life -= 1; // LifeDown에서 내리는게 더 나을거같음 여기서는 호출만하고
            Debug.Log(life);
            LifeScoreMgr.GetComponent<Co2O2GameManager>().LifeDown();
            

            Invoke("RemoveTF", 0.5f); // 2초 후 이미지 비활성화
            
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
