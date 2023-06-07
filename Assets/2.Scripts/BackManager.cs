using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackManager : MonoBehaviour
{
    
    public int Exp;
    public GameObject backmanager;

    public static bool isback = false;

    void Start()
    {
        //isback = false;
    }
    public void BackButtonClick()
    {
        //BackManagerUI backManagerUI = backmanager.GetComponent<BackManagerUI>();
        //backManagerUI.isback = true;
        isback = true;
        SceneManager.LoadScene("UIscene");
        DontDestroyOnLoad(backmanager);
        //æ¿¿Ãµø
    }
}