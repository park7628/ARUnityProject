using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginUIButtonManager : MonoBehaviour
{
    public GameObject FirstUI;
    public GameObject LoginUI;

    public void FirstUISetActive()
    {
        FirstUI.SetActive(false);
        LoginUI.SetActive(true);
    }
}
