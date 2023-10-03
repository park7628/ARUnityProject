using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public static int SelectedExperiment = 0;

    public void Ex1()
    {
        //SceneManager.LoadScene("ExperimentPrepare");
        SceneManager.LoadScene("ExperimentPrepare");
        SelectedExperiment = 1;
    }

    public void Ex2()
    {
        //SceneManager.LoadScene("ExperimentO2");
        SceneManager.LoadScene("ExperimentPrepare");
        SelectedExperiment = 2;

    }
    public void Ex3()
    {
        SceneManager.LoadScene("Space2");

    }
    public void ExUiToUi()
    {
        SceneManager.LoadScene("UIscene");
    }
}