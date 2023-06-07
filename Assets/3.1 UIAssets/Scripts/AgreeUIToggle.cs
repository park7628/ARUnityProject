using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgreeUIToggle : MonoBehaviour
{
    public Toggle ToggleS1;
    public Toggle ToggleS2;
    public Toggle ToggleS3;

    public Toggle ToggleT1;
    public Toggle ToggleT2;
    public Toggle ToggleT3;


    public void SAllAgree(bool isOn)
    {
        if(ToggleS1.isOn)
        {
            ToggleS2.isOn = true;
            ToggleS3.isOn = true;
        }
        else
        {
            ToggleS2.isOn = false;
            ToggleS3.isOn = false;
        }
    }

    public void TAllAgree(bool isOn)
    {
        if(ToggleT1.isOn)
        {
            ToggleT2.isOn = true;
            ToggleT3.isOn = true;
        }
        else
        {
            ToggleT2.isOn = false;
            ToggleT3.isOn = false;
        }
    }
}
