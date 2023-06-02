using UnityEngine;
using UnityEngine.SceneManagement;

public class BackManager : MonoBehaviour
{
    private BackManagerUI backManagerUI;

    private void Start()
    {


        backManagerUI = FindObjectOfType<BackManagerUI>();
        //BackManagerUI.LoginUIButtonManager = GameObject.FindWithTag("LoginUIButtonManager");
        //BackManagerUI.MainUI = GameObject.FindWithTag("MainUI");

        if (backManagerUI == null)
        {
            // BackManagerUI 오브젝트가 없는 경우, BackManagerUI 오브젝트 생성
            GameObject backManagerUIObject = new GameObject("BackManagerUI");
            backManagerUI = backManagerUIObject.AddComponent<BackManagerUI>();
            DontDestroyOnLoad(backManagerUIObject);
        }
    }

    public void BackButtonClick()
    {
        backManagerUI.BacktoStartScene();
    }
}