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
            Debug.Log("�̻�ȭź�� �߻�");
            GameObject.Find("Canvas").transform.Find("True").gameObject.SetActive(true);
            Co2O2GameManager.missFire[Co2O2GameManager.checkFireRange] = 0;
            Debug.Log("ArrayManger���� missFire�� ���� 0���� �ٲ���ϴ�.");
            // ���� +10
            LifeScoreMgr.GetComponent<Co2O2GameManager>().GetScore();

            Invoke("RemoveTF", 1f); // 2�� �� �̹��� ��Ȱ��ȭ
        }
        else if ((a1 == 1 && a2 == 4) || (a1 == 4 && a2 == 1))
        {
            Debug.Log("��� �߻�");
            GameObject.Find("Canvas").transform.Find("True").gameObject.SetActive(true);

            Co2O2GameManager.missFire[Co2O2GameManager.checkFireRange] = 0;
            Debug.Log("ArrayManger���� missFire�� ���� 0���� �ٲ���ϴ�.");

            // ���� +10
            LifeScoreMgr.GetComponent<Co2O2GameManager>().GetScore();

            Invoke("RemoveTF", 1f); // 2�� �� �̹��� ��Ȱ��ȭ
        }
        else if ((a1 == 1 && a2 == 2) || (a1 == 1 && a2 == 3) || (a1 == 2 && a2 == 1) || (a1 == 3 && a2 == 1) || (a1 == 2 && a2 == 4) || (a1 == 4 && a2 == 2) || (a1 == 3 && a2 == 4) || (a1 == 4 && a2 == 3))
        {
            Debug.Log("�����Դϴ�");
            GameObject.Find("Canvas").transform.Find("False").gameObject.SetActive(true);
            Co2O2GameManager.missFire[Co2O2GameManager.checkFireRange] = 0; // �ؿ��� ������ �E�Ŵϱ� ������Ʈ�� �������鼭 ���� ������ ����
            // ���ӿ��� �� life�� 0�� �� 3���� �ٽ� �ʱ�ȭ
            if (life == 0)
            {
                life = 3;
            }

            // ��� -1
            //life -= 1; // LifeDown���� �����°� �� �����Ű��� ���⼭�� ȣ�⸸�ϰ�
            Debug.Log(life);
            LifeScoreMgr.GetComponent<Co2O2GameManager>().LifeDown();
            

            Invoke("RemoveTF", 0.5f); // 2�� �� �̹��� ��Ȱ��ȭ
            
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
