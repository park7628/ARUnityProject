using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExpSceneManager : MonoBehaviour
{

    public void PrepareCompleteButtonClick()
    {

        switch (SceneChange.SelectedExperiment)
        {
            case 1:
                SceneManager.LoadScene("ExperimentO2");
                break;
            case 2:
                SceneManager.LoadScene("ExperimentCO2");
                break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}