using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;

public class BackManagerUI : MonoBehaviour
{

    // 특정 오브젝트를 참조하는 변수

    //GameObject BackManager;
    int chooseexp;
    public GameObject Experiment1;
    public GameObject Experiment2;

    public GameObject O2Start;
    public GameObject CO2Start;
    public GameObject SpaceStart;

    /*public bool isback = false;
    void Start()
    {
        //O2Start = GameObject.Find("O2Start");
        //CO2Start = GameObject.Find("CO2Start");

        //if (isback)
        //{
        isback = false;
        UnityEngine.Debug.Log("BackManager 찾기");
            BackManager = GameObject.Find("BackManager");
            if (BackManager != null)
            {
                UnityEngine.Debug.Log("BackManager not null");
                isback = BackManager.GetComponent<BackManagerUI>().isback;
                
                if (isback)
                {
                    UnityEngine.Debug.Log("isback true");
                    chooseexp = BackManager.GetComponent<BackManager>().Exp;
                UnityEngine.Debug.Log(chooseexp);
                if (O2Start != null && CO2Start != null)
                {
                    BacktoStartScene();
                }
                }
            
            isback = false;
        }
        //Destroy(BackManager);
        //}

    }*/

    void Start()
    {
        //O2Start = GameObject.Find("O2Start");
        //CO2Start = GameObject.Find("CO2Start");

        if (BackManager.isback)
        {
            if (O2Start != null && CO2Start != null && SpaceStart != null)
            {
                BacktoStartScene();
            }
        }


    }


    public void BacktoStartScene()
    {

        if (SceneChange.SelectedExperiment == 1)
        {
            O2Start.SetActive(true);
            Experiment1.SetActive(false);
            Experiment2.SetActive(false);
        }

        else if (SceneChange.SelectedExperiment == 2)
        {
            CO2Start.SetActive(true);
            Experiment1.SetActive(false);
            Experiment2.SetActive(false);
        }

        else if (SceneChange.SelectedExperiment == 3)
        {
            SpaceStart.SetActive(true);
            Experiment1.SetActive(false);
            Experiment2.SetActive(false);
        }
    }

}
