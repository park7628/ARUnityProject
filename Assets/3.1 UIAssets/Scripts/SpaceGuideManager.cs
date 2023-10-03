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

    public void Gtext6() //지구는 서쪽에서 동쪽(시계 반대 방향)으로 회전합니다. 지구 옆의 화살표를 눌러 지구를 자전시켜 보세요. 트리거 : 화살표 누르기
    {
        //RBT.onClick.AddListener(Gtext7);
        RBT.onClick.RemoveListener(Gtext6);
        RBT.onClick.AddListener(Gtext7);
        //Robj.onClick.RemoveListener(Gtext6);
        text6.SetActive(false);
        text7.SetActive(true);
    }
    public void Gtext7()
    {    //관측자 모형에게 태양과 달이 어떻게 움직이는 것처럼 보이는지 관찰해 봅시다.
         //(캠 화면 위에 낮 -> 밤 -> 낮 -> 밤)
         //360도 이상 돌아갔으면 다 관찰했어요 버튼이 중앙 하단에 뜨도록 한다.
         //지구가 서쪽에서 동쪽으로 자전하기 때문에 태양과 달이 동쪽에서 서쪽으로 움직이는 것처럼 보입니다. ( 중앙에 팝업창으로 정보 전달력을 주면서 닫기 버튼으로 닫을 수 있도록)
        
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
