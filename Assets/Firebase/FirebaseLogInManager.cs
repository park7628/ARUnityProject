using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Auth;
using System.Xml.Serialization;
using System;
//using UnityEngine.UI;


public class FirebaseLogInManager
{
    private static FirebaseLogInManager instance2 = null;

    public static FirebaseLogInManager Instance2
    {
        get
        {
            if (instance2 == null)
            {
                instance2 = new FirebaseLogInManager();
            }

            return instance2;
        }
    }
    private FirebaseAuth auth;
    private FirebaseUser user;


    public Action<bool> LoginState;

    public void Init()
    {
        auth = FirebaseAuth.DefaultInstance;
        //LoginState = loginStateCallback;
        if (auth.CurrentUser != null)
        {
            LogOut();
        }
        auth.StateChanged += OnChanged;

    }

    private void OnChanged(object sender, EventArgs e)
    {
        if (auth.CurrentUser != null)
        {
            bool signed = (auth.CurrentUser != user && auth.CurrentUser != null);
            if (!signed && user != null)
            {
                Debug.Log("로그아웃");
                LoginState?.Invoke(false);
            }
            user = auth.CurrentUser;
            if (signed)
            {
                Debug.Log("로그인");
                LoginState?.Invoke(false);
            }
        }
    }

    public string UserId
    {
        get { return user != null ? user.UserId : string.Empty; }
    }
    //public InputField email;
    //public InputField password;

    //public InputField getEmail;
    //public InputField getPassword;

    // Start is called before the first frame update
    //void Start()
    //{
    //    auth = FirebaseAuth.DefaultInstance;   
    //}

    public void Create(string getEmail, string getPassword)
    {
        auth.CreateUserWithEmailAndPasswordAsync(getEmail, getPassword).ContinueWith(task =>
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

    public void Login(string email, string password)
    {
        auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(task =>
        {
            if (task.IsCanceled)
            {
                Debug.LogError("로그인 취소");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("로그인 실패");
                return;
            }

            FirebaseUser newUser = task.Result.User;
            //FirebaseUser newUser = task.Result;
            Debug.LogError("로그인 완료");
        });
    }

    public void LogOut()
    {
        auth.SignOut();
        Debug.Log("로그아웃");
    }
}