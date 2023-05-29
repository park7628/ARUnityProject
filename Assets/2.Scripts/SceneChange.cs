using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void Ex1()
    {
        SceneManager.LoadScene("ExperimentPrepare");
    }

    public void Ex2()
    {
        SceneManager.LoadScene("ExperimentO2");
    }
    public void Ex3()
    {
        SceneManager.LoadScene("ExperimentCO2");
    }
    public void ExUiToUi()
    {
        SceneManager.LoadScene("UIscene");
    }
}