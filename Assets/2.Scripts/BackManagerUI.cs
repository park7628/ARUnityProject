using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;

public class BackManagerUI : MonoBehaviour
{

    // 특정 오브젝트를 참조하는 변수


    private static BackManagerUI instance;

    public GameObject LoginUIButtonManager;
    public GameObject MainUI;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            DontDestroyOnLoad(LoginUIButtonManager);
            DontDestroyOnLoad(MainUI);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void BacktoStartScene() {
       
        if (SceneChange.SelectedExperiment == 1)
        {

            LoginUIButtonManager.GetComponent<LoginUIButtonManager>().LoginUISetActive();
            LoginUIButtonManager.GetComponent<LoginUIButtonManager>().Experiment1SetActive();
            MainUI.GetComponent<MainUI>().experimentC3();
            MainUI.GetComponent<MainUI>().O2StartActive();
        }
    
        else if (SceneChange.SelectedExperiment == 2)
        {

            LoginUIButtonManager.GetComponent<LoginUIButtonManager>().LoginUISetActive();
            LoginUIButtonManager.GetComponent<LoginUIButtonManager>().Experiment1SetActive();
            MainUI.GetComponent<MainUI>().experimentC3();
            MainUI.GetComponent<MainUI>().CO2StartActive();

        }

    }

   
}
