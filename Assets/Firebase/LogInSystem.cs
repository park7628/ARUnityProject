using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LogInSystem : MonoBehaviour
{

    public InputField email;
    public InputField password;

    public InputField getEmail;
    public InputField getPassword;
    public Text outputText;

    // Start is called before the first frame update
    void Start()
    {
        FirebaseLogInManager.Instance2.LoginState += OnChangedState;
        FirebaseLogInManager.Instance2.Init();
    }

    private void OnChangedState(bool sign)
    {
        outputText.text = sign ? "로그인 : " : "로그아웃 : ";
        outputText.text += FirebaseLogInManager.Instance2.UserId;
    }

    public void Create()
    {
        string e = getEmail.text;
        string p = getPassword.text;

        FirebaseLogInManager.Instance2.Create(e, p);
    }
    public void LogIn()
    {
        string e = email.text;
        string p = password.text;

        FirebaseLogInManager.Instance2.Login(e, p);
    }
    public void LogOut()
    {
        FirebaseLogInManager.Instance2.LogOut();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
