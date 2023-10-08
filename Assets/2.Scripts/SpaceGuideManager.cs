using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceGuideManager : MonoBehaviour
{
    public GameObject Sun;
    public GameObject SunW;
    public GameObject Earth;
    public GameObject EarthW;
    public GameObject Moon;
    public GameObject MoonW;

    public GameObject WCamUI;
    public GameObject InvenPanel;
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
    public GameObject Robj, Cobj, Qobj, Sobj, Crobj;
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

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Gtext1() //Gtext1 이 화면에 뜨는 가이드를 잘 읽고 실험을 진행하세요. 우측 시작 버튼을 눌러 실험을 시작하세요. 트리거 : 시작버튼 누르기
    {
        Sobj.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(true);
        InvenPanel.SetActive(true);
        Crobj.SetActive(true);
    }
    public void Gtext2() //퀴즈에 맞는 별 또는 행성을 알맞은 자리에 넣어주세요. 태양계에서 유일한 별이자 모든 에너지의 근원은? 트리거 : 태양 가져다대기
    {
        Sun.SetActive(true);
        SunW.SetActive(false);
        CrBT.onClick.RemoveListener(Gtext2);
        CrBT.onClick.AddListener(Gtext3);
        text2.SetActive(false);
        text3.SetActive(true);
    }
    public void Gtext3() //퀴즈에 맞는 별 또는 행성을 알맞은 자리에 넣어주세요. 태양으로부터 세번째 행성으로 우리가 살고 있는 행성은? 트리거 : 지구 가져다대기
    {
        Earth.SetActive(true);
        EarthW.SetActive(false);
        CrBT.onClick.RemoveListener(Gtext3);
        CrBT.onClick.AddListener(Gtext4);
        text3.SetActive(false);
        text4.SetActive(true);
    }
    public void Gtext4() //퀴즈에 맞는 별 또는 행성을 알맞은 자리에 넣어주세요. 지구를 중심으로 공전하고 있는 위성은? 트리거 : 달 가져다대기
    {
        Moon.SetActive(true);
        MoonW.SetActive(false);
        CrBT.onClick.RemoveListener(Gtext4);
        CrBT.onClick.AddListener(Gtext5);
        text4.SetActive(false);
        text5.SetActive(true);
        InvenPanel.SetActive(false);
    }
    public void Gtext5() //지구에 살고 있는 관측자입니다. 지구에 관측자를 올려주세요. 트리거 : 관측자 지구에 가져다대기
    {
        
        text5.SetActive(false);
        text6.SetActive(true);
        Robj.SetActive(true);
        WCamUI.SetActive(true);//캠 켜지기
        Crobj.SetActive(false);
        arrow1.SetActive(true);
        arrow2.SetActive(true);
    }
    public void Gtext6() //지구는 서쪽에서 동쪽(시계 반대 방향)으로 회전합니다. 지구 옆의 화살표를 눌러 지구를 자전시켜 보세요. 트리거 : 화살표 누르기
    {
        
        RBT.onClick.RemoveListener(Gtext6);
        RBT.onClick.AddListener(Gtext7);
        text6.SetActive(false);
        text7.SetActive(true);
    }
    public void Gtext7()
    {    //관측자 모형에게 태양과 달이 어떻게 움직이는 것처럼 보이는지 관찰해 봅시다.
         //(캠 화면 위에 낮 -> 밤 -> 낮 -> 밤)
         //360도 이상 돌아갔으면 다 관찰했어요 버튼이 중앙 하단에 뜨도록 한다.
         //지구가 서쪽에서 동쪽으로 자전하기 때문에 태양과 달이 동쪽에서 서쪽으로 움직이는 것처럼 보입니다. ( 중앙에 팝업창으로 정보 전달력을 주면서 닫기 버튼으로 닫을 수 있도록)
        
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
