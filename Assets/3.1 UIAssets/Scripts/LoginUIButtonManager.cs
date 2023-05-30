using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginUIButtonManager : MonoBehaviour
{
    public GameObject FirstUI;
    public GameObject LoginUI;
    public GameObject FindIDUI;
    public GameObject FindPWUI;
    public GameObject TSChoiceUI;
    public GameObject SAgreeUI;
    public GameObject SAgreeUI1;
    public GameObject SAgreeUI2;
    public GameObject SSignupUI;
    public GameObject TAgreeUI;
    public GameObject TAgreeUI1;
    public GameObject TAgreeUI2;
    public GameObject TSignupUI;
    public GameObject Experiment1;
    public GameObject GroupCodeSet;




    // FirstUI 에서 로그인 버튼 클릭 시 LoginUI로 이동
    // TSChoiceUI에서 로그인 버튼 클릭 시 이전화면(LoginUI)으로 이동
    // FindIDUI, FindPWUI에서 뒤로가기 버튼 클릭 시 LoginUI로 이동
    // SSignupUI, TSignupUI에서 회원가입 버튼 클릭 시 LoginUI로 이동
    public void LoginUISetActive()
    {
        FirstUI.SetActive(false);
        TSChoiceUI.SetActive(false);
        FindIDUI.SetActive(false);
        FindPWUI.SetActive(false);
        SSignupUI.SetActive(false);
        TSignupUI.SetActive(false);

        LoginUI.SetActive(true);
    }

    // FirstUI 에서 회원가입 버튼 클릭 시 TSChoiceUI로 이동
    // TAgreeUI에서 뒤로가기 버튼 클릭 시 TSChoiceUI로 이동
    // SAgreeUI에서 뒤로가기 버튼 클릭 시 TSChoiceUI로 이동
    public void TSChoiceUISetActive()
    {
        FirstUI.SetActive(false);
        TAgreeUI.SetActive(false);
        SAgreeUI.SetActive(false);

        TSChoiceUI.SetActive(true);
    }

    // TSChoiceUI에서 학생 버튼 클릭 시 SAgreeUI로 이동
    // SAgreeUI1, SAgreeUI2에서 확인 버튼 클릭 시 SAgreeUI로 이동
    // SSignupUI에서 뒤로 가기 버튼 클릭 시 SAgreeUI로 이동
    
    public void SAgreeUISetActive()
    {
        TSChoiceUI.SetActive(false);
        SAgreeUI1.SetActive(false);
        SAgreeUI2.SetActive(false);
        SSignupUI.SetActive(false);

        SAgreeUI.SetActive(true);
    }

    // SAgreeUI에서 이용약관 확인 버튼 클릭 시 SAgreeUI1으로 이동
    public void SAgreeUI1SetActive()
    {
        SAgreeUI.SetActive(false);
        SAgreeUI1.SetActive(true);
    }

    // SAgreeUI에서 개인정보 처리방침 확인 버튼 클릭 시 SAgreeUI2로 이동
    public void SAgreeUI2SetActive()
    {
        SAgreeUI.SetActive(false);
        SAgreeUI2.SetActive(true);
    }

    // SAgreeUI에서 다음단계 버튼 클릭 시 SSignupUI로 이동
    public void SSignupUISetActive()
    {
        SAgreeUI.SetActive(false);
        SSignupUI.SetActive(true);
    }

    // TSChoiceUI에서 교사 버튼 클릭 시 TAgreeUI로 이동
    // TAgreeUI1, TAgreeUI2에서 확인 버튼 클릭 시 TAgreeUI로 이동
    // TSignupUI에서 뒤로 가기 버튼 클릭 시 TAgreeUI로 이동
    public void TAgreeUISetActive()
    {
        TSChoiceUI.SetActive(false);
        TAgreeUI1.SetActive(false);
        TAgreeUI2.SetActive(false);
        TSignupUI.SetActive(false);

        TAgreeUI.SetActive(true);
    }    

    // TAgreeUI에서 이용약관 확인 버튼 클릭 시 TAgreeUI1으로 이동
    public void TAgreeUI1SetActive()
    {
        TAgreeUI.SetActive(false);
        TAgreeUI1.SetActive(true);
    }

    // TAgreeUI에서 개인정보 처리방침 확인 버튼 클릭 시 TAgreeUI2로 이동
    public void TAgreeUI2SetActive()
    {
        TAgreeUI.SetActive(false);
        TAgreeUI2.SetActive(true);
    }

    // TAgreeUI에서 다음단계 버튼 클릭 시 TSignupUI로 이동
    public void TSignupUISetActive()
    {
        TAgreeUI.SetActive(false);
        TSignupUI.SetActive(true);
    }

    // LoginUI에서 뒤로가기 버튼 클릭 시 이전화면(FirstUI)으로 이동
    // TSChoiceUI에서 뒤로가기 버튼 클릭 시 이전화면(FirstUI)으로 이동

    public void FirstUISetActive()
    {
        LoginUI.SetActive(false);
        TSChoiceUI.SetActive(false);

        FirstUI.SetActive(true);
    }

    // LoginUI에서 아이디 찾기 버튼 클릭 시 FindIDUI로 이동
    public void FindIDUISetActive()
    {
        LoginUI.SetActive(false);
        FindIDUI.SetActive(true);
    }

    // LoginUI에서 비밀번호 찾기 버튼 클릭 시 FindPWUI로 이동
    public void FindPWUISetActive()
    {
        LoginUI.SetActive(false);
        FindPWUI.SetActive(true);
    }


    // LoginUI에서 로그인 버튼 클릭 시 메인 화면(Experiment1)으로 이동
    public void Experiment1SetActive()
    {
        LoginUI.SetActive(false);
        Experiment1.SetActive(true);
        GroupCodeSet.SetActive(true);
    }

}
