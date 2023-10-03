using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceGuideManager : MonoBehaviour
{
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;
    public GameObject text9;
    public GameObject Robj, Cobj, Qobj;
    public GameObject Info1, Info2;
    public Button RBT, CBT;
    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        text7.SetActive(false);
        text8.SetActive(false);
        text9.SetActive(false);

        RBT = RBT.GetComponent<Button>();
        CBT = CBT.GetComponent<Button>();

        RBT.onClick.AddListener(Gtext6);
        CBT.onClick.AddListener(TurnOnInfo1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Gtext6() //������ ���ʿ��� ����(�ð� �ݴ� ����)���� ȸ���մϴ�. ���� ���� ȭ��ǥ�� ���� ������ �������� ������. Ʈ���� : ȭ��ǥ ������
    {
        //RBT.onClick.AddListener(Gtext7);
        RBT.onClick.RemoveListener(Gtext6);
        RBT.onClick.AddListener(Gtext7);
        //Robj.onClick.RemoveListener(Gtext6);
        text6.SetActive(false);
        text7.SetActive(true);
    }
    public void Gtext7()
    {    //������ �������� �¾�� ���� ��� �����̴� ��ó�� ���̴��� ������ ���ô�.
         //(ķ ȭ�� ���� �� -> �� -> �� -> ��)
         //360�� �̻� ���ư����� �� �����߾�� ��ư�� �߾� �ϴܿ� �ߵ��� �Ѵ�.
         //������ ���ʿ��� �������� �����ϱ� ������ �¾�� ���� ���ʿ��� �������� �����̴� ��ó�� ���Դϴ�. ( �߾ӿ� �˾�â���� ���� ���޷��� �ָ鼭 �ݱ� ��ư���� ���� �� �ֵ���)
        
        i += 1;
        if (i == 6)
        {
            Cobj.SetActive(true);
            Robj.SetActive(false);
            i = 0;
        }

    }
    public void TurnOnInfo1()
    {
        Info1.SetActive(true);
        CBT.onClick.RemoveListener(TurnOnInfo1);
        CBT.onClick.AddListener(TurnOnInfo2);
    }       
    public void TurnOffInfo1()
    {
        Info1.SetActive(false);
        Cobj.SetActive(false);
        Robj.SetActive(true);
        text7.SetActive(false);
        text8.SetActive(true);
        RBT.onClick.RemoveListener(Gtext7);
        RBT.onClick.AddListener(Gtext8);
    }
    public void Gtext8()
    {
        
        i += 1;
        if (i == 6)
        {
            Cobj.SetActive(true);
            Robj.SetActive(false);
        }

    }
    public void TurnOnInfo2()
    {
        Info2.SetActive(true);
    }
    public void TurnOffInfo2()
    {
        text8.SetActive(false);
        text9.SetActive(true);
        
        Info2.SetActive(false);
        Cobj.SetActive(false);
        Robj.SetActive(true);
        Qobj.SetActive(true);
    }
    public void Gtext9()
    {
        
    }

}
