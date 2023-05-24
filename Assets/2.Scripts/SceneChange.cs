using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void Ex1()
    {
        SceneManager.LoadScene("Experiment");
    }

    public void Ex2()
    {
        SceneManager.LoadScene("ExperimentScript");
    }
}