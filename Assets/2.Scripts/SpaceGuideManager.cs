using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceGuideManager : MonoBehaviour
{
    public GameObject Sun;
    public GameObject SunW;
    private static GameObject SunP;
    public GameObject Earth;
    public GameObject EarthW;
    private static GameObject EarthP;
    public GameObject Moon;
    public GameObject MoonW;
    private static GameObject MoonP;
    public GameObject Human;
    public GameObject HumanW;
    private static GameObject HumanP;

    public GameObject WCamUI;
    public GameObject InvenPanel;
    public GameObject InvelPanel2;
    public GameObject arrow1;
    public GameObject arrow2;

    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;
    public GameObject text9;
    public GameObject Robj, Cobj, Qobj, Sobj, Crobj, Hobj;
    public GameObject Info1, Info2;
    public Button SBT, RBT, CBT, CrBT;
    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        //text1.SetActive(false);
        //text2.SetActive(false);
        //text3.SetActive(false);
        //text4.SetActive(false);
        //text5.SetActive(false);
        //text6.SetActive(false);
        //text7.SetActive(false);
        //text8.SetActive(false);
        //text9.SetActive(false);

        Sun.SetActive(false);
        Earth.SetActive(false);
        Moon.SetActive(false);

        SBT = SBT.GetComponent<Button>();
        RBT = RBT.GetComponent<Button>();
        CBT = CBT.GetComponent<Button>();
        CrBT = CrBT.GetComponent<Button>();


        SBT.onClick.AddListener(Gtext1);
        RBT.onClick.AddListener(Gtext6);
        CBT.onClick.AddListener(TurnOnInfo1);
        CrBT.onClick.AddListener(Gtext2);
        Robj.SetActive(false);
        Crobj.SetActive(false);
    }

    public void ShowHelpButton(Toggle toggletest)
    {
        if (toggletest.isOn)
            Hobj.SetActive(true);
        else 
            Hobj.SetActive(false);
    }

    public void Gtext1() //Gtext1 �� ȭ�鿡 �ߴ� ���̵带 �� �а� ������ �����ϼ���. ���� ���� ��ư�� ���� ������ �����ϼ���. Ʈ���� : ���۹�ư ������
    {
        Sobj.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(true);
        InvenPanel.SetActive(true);
        Crobj.SetActive(true);
    }
    public void Gtext2() //��� �´� �� �Ǵ� �༺�� �˸��� �ڸ��� �־��ּ���. �¾�迡�� ������ ������ ��� �������� �ٿ���? Ʈ���� : �¾� �����ٴ��
    {
        SunP = GameObject.FindWithTag("SunP");
        if(SunP != null)
        {
            Destroy(SunP);
        }
        Sun.SetActive(true);
        SunW.SetActive(false);
        CrBT.onClick.RemoveListener(Gtext2);
        CrBT.onClick.AddListener(Gtext3);
        text2.SetActive(false);
        text3.SetActive(true);
    }
    public void Gtext3() //��� �´� �� �Ǵ� �༺�� �˸��� �ڸ��� �־��ּ���. �¾����κ��� ����° �༺���� �츮�� ��� �ִ� �༺��? Ʈ���� : ���� �����ٴ��
    {
        EarthP = GameObject.FindWithTag("EarthP");
        if (EarthP != null)
        {
            Destroy(EarthP);
        }
        Earth.SetActive(true);
        EarthW.SetActive(false);
        CrBT.onClick.RemoveListener(Gtext3);
        CrBT.onClick.AddListener(Gtext4);
        text3.SetActive(false);
        text4.SetActive(true);
    }
    public void Gtext4() //��� �´� �� �Ǵ� �༺�� �˸��� �ڸ��� �־��ּ���. ������ �߽����� �����ϰ� �ִ� ������? Ʈ���� : �� �����ٴ��
    {
        MoonP = GameObject.FindWithTag("MoonP");
        if (MoonP != null)
        {
            Destroy(MoonP);
        }
        Moon.SetActive(true);
        MoonW.SetActive(false);
        CrBT.onClick.RemoveListener(Gtext4);
        CrBT.onClick.AddListener(Gtext5);
        text4.SetActive(false);
        text5.SetActive(true);
        InvenPanel.SetActive(false);
        InvelPanel2.SetActive(true);
    }

    /*public void Gtext4_1()
    {
        Human.SetActive(true);
        HumanW.SetActive(false);
        CrBT.onClick.RemoveListener(Gtext4_1);
        CrBT.onClick.AddListener(Gtext5);

        InvelPanel2.SetActive(false);
        
    }*/

    public void Gtext5() //������ ��� �ִ� �������Դϴ�. ������ �����ڸ� �÷��ּ���. Ʈ���� : ������ ������ �����ٴ��
    {
        Human.SetActive(true);
        HumanW.SetActive(false);
        HumanP = GameObject.FindWithTag("HumanP");
        if (HumanP != null)
        {
            Destroy(HumanP);
        }
        InvelPanel2.SetActive(false);

        text5.SetActive(false);
        text6.SetActive(true);
        Robj.SetActive(true);
        WCamUI.SetActive(true);//ķ ������
        Crobj.SetActive(false);
        arrow1.SetActive(true);
        arrow2.SetActive(true);
    }
    public void Gtext6() //������ ���ʿ��� ����(�ð� �ݴ� ����)���� ȸ���մϴ�. ���� ���� ȭ��ǥ�� ���� ������ �������� ������. Ʈ���� : ȭ��ǥ ������
    {
        
        RBT.onClick.RemoveListener(Gtext6);
        RBT.onClick.AddListener(Gtext7);
        text6.SetActive(false);
        text7.SetActive(true);
    }
    public void Gtext7()
    {    //������ �������� �¾�� ���� ��� �����̴� ��ó�� ���̴��� ������ ���ô�.
         //(ķ ȭ�� ���� �� -> �� -> �� -> ��)
         //360�� �̻� ���ư����� �� �����߾�� ��ư�� �߾� �ϴܿ� �ߵ��� �Ѵ�.
         //������ ���ʿ��� �������� �����ϱ� ������ �¾�� ���� ���ʿ��� �������� �����̴� ��ó�� ���Դϴ�. ( �߾ӿ� �˾�â���� ���� ���޷��� �ָ鼭 �ݱ� ��ư���� ���� �� �ֵ���)
        
        i += 1;
        if (i == 12)
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
        if (i == 12)
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
