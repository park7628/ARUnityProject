using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    #region gameobject
    public GameObject Experiment1;
    public GameObject Experiment2;
    public GameObject GroupS;
    public GameObject GroupT1;
    public GameObject GroupT2;
    public GameObject Game;
    public GameObject Information1;
    public GameObject Information2;
    public GameObject GroupS1;
    public GameObject LoginUI;
    public GameObject setE1;
    public GameObject setE2;
    public GameObject setGS;
    public GameObject setGT1;
    public GameObject setGT2;
    public GameObject setG;
    public GameObject setI1;
    public GameObject setI2;
    public GameObject GroupCodeSet;

    // public GameObject setGS1;



    #endregion


    public void Nav1()
    { 
        //다 끄고 실험1 화면만 켜기
        Experiment1.SetActive(true);
        Experiment2.SetActive(false);
        GroupS.SetActive(false);
        GroupT1.SetActive(false);
        GroupT2.SetActive(false);
        Game.SetActive(false);
        Information1.SetActive(false);
        Information2.SetActive(false);
        GroupS1.SetActive(false);

        GroupCodeSet.SetActive(false);
    }

    public void Nav2()
    {
        //다 끄고 그룹 T1 화면만 켜기
        Experiment1.SetActive(false);
        Experiment2.SetActive(false);
        GroupS.SetActive(false);
        GroupT1.SetActive(true);
        GroupT2.SetActive(false);
        Game.SetActive(false);
        Information1.SetActive(false);
        Information2.SetActive(false);
        GroupS1.SetActive(false);
    }

    public void Nav3()
    {
        //다 끄고 게임 화면만 켜기
        Experiment1.SetActive(false);
        Experiment2.SetActive(false);
        GroupS.SetActive(false);
        GroupT1.SetActive(false);
        GroupT2.SetActive(false);
        Game.SetActive(true);
        Information1.SetActive(false);
        Information2.SetActive(false);
        GroupS1.SetActive(false);
    }

    public void Nav4()
    {
        //다 끄고 정보1 화면만 켜기
        Experiment1.SetActive(false);
        Experiment2.SetActive(false);
        GroupS.SetActive(false);
        GroupT1.SetActive(false);
        GroupT2.SetActive(false);
        Game.SetActive(false);
        Information1.SetActive(true);
        Information2.SetActive(false);
        GroupS1.SetActive(false);
    }

    public void experimentC3()
    {
        Experiment1.SetActive(false);
        Experiment2.SetActive(true);
    }

    public void experimentC9()
    {
        //토스트를 이용해 아직 준비가 되어있지 않다고 띄움
    }

    public void Tstudent()
    {
        GroupT1.SetActive(false);
        GroupT2.SetActive(true);
    }

    public void pencil(){
        Information1.SetActive(false);
        Information2.SetActive(true);
    }

    public void infosave(){
        Information1.SetActive(true);
        Information2.SetActive(false);
    }

    public void Logout() {
        Experiment1.SetActive(false);
        Experiment2.SetActive(false);
        GroupS.SetActive(false);
        GroupT1.SetActive(false);
        GroupT2.SetActive(false);
        Game.SetActive(false);
        Information1.SetActive(false);
        Information2.SetActive(false);
        GroupS1.SetActive(false);

        setE1.SetActive(false);
        setE2.SetActive(false);
        setGS.SetActive(false);
        setGT1.SetActive(false);
        setGT2.SetActive(false);
        setG.SetActive(false);
        setI1.SetActive(false);
        setI2.SetActive(false);
        //setGS1.SetActive(false);

        LoginUI.SetActive(true);
    }
}
