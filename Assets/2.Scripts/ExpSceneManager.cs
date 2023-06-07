using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExpSceneManager : MonoBehaviour
{
   //public BackManager bm;

    void Start()
    {
        /*switch (SceneChange.SelectedExperiment)
        {
            case 1:
                bm.Exp = 1;
                break;
            case 2:
                bm.Exp = 2;
                break;
        }
        */
        BackManager.isback = false;

    }
    
    public void PrepareCompleteButtonClick()
    {

        switch (SceneChange.SelectedExperiment)
        {
            case 1:
                //BackManager.isback = false;
                SceneManager.LoadScene("ExperimentO2");
                break;
            case 2:
                //BackManager.isback = false;
                SceneManager.LoadScene("ExperimentCO2");
                break;
        }
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

    }
}