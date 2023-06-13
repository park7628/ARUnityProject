using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Auth;
using UnityEngine.UI;
using System;

public class FirebaseLogInManager : MonoBehaviour
{
    public GameObject LoginUI;
    public GameObject Experiment1;
    public GameObject GroupCodeSet;
    public GameObject bgmsound;

    private FirebaseAuth auth;
    private FirebaseUser user;

    public static InputField checkEmail;
    public static InputField checkPassword;
    public static InputField checkUser;

    public InputField email;
    public InputField password;

    public InputField getEmail;
    public InputField getPassword;

    public InputField getEmailT;
    public InputField getPasswordT;
    public LoginUIButtonManager loginUIButtonManager;

    public static bool aa;
    // Start is called before the first frame update
    void Start()
    {
        auth = FirebaseAuth.DefaultInstance;
        aa = false;
    }

    public void checkString()
    {
        checkEmail = email;
        //checkPassword = password;

        Debug.LogError(checkEmail.text);
    }
    public void Create()
    {
        auth.CreateUserWithEmailAndPasswordAsync(getEmail.text, getPassword.text).ContinueWith(task =>
        {
            if (task.IsCanceled)
            {
                Debug.LogError("회원가입 취소");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("회원가입 실패");
                return;
            }

            FirebaseUser newUser = task.Result.User;
            //newUser.User.DisplayName, newUser.User.UserId);
            Debug.LogError("회원가입 완료");
        });
    }

    public void CreateTeacher()
    {
        auth.CreateUserWithEmailAndPasswordAsync(getEmailT.text, getPasswordT.text).ContinueWith(task =>
        {
            if (task.IsCanceled)
            {
                Debug.LogError("회원가입 취소");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("회원가입 실패");
                return;
            }

            FirebaseUser newUser = task.Result.User;
            //newUser.User.DisplayName, newUser.User.UserId);
            Debug.LogError("회원가입 완료");
        });
    }

    public void Login(Action<bool> isSignedIn)
    {
        auth.SignInWithEmailAndPasswordAsync(email.text, password.text).ContinueWith(task =>
        {
            if (task.IsCanceled)
            {
                Debug.LogError("로그인 취소");
                isSignedIn?.Invoke(false);
            }
            else if (task.IsFaulted)
            {
                Debug.LogError("로그인 실패");
                isSignedIn?.Invoke(false);
            }
            else
            {
                Debug.LogError("로그인 완료");
                isSignedIn?.Invoke(true);
            }            
        });
    }

    public void LogOut()
    {
        auth.SignOut();
        Debug.Log("로그아웃");
    }
}