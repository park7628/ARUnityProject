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
                Debug.Log("�α׾ƿ�");
                LoginState?.Invoke(false);
            }
            user = auth.CurrentUser;
            if (signed)
            {
                Debug.Log("�α���");
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
                Debug.LogError("ȸ������ ���");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("ȸ������ ����");
                return;
            }

            FirebaseUser newUser = task.Result.User;
            //newUser.User.DisplayName, newUser.User.UserId);
            Debug.LogError("ȸ������ �Ϸ�");
        });
    }

    public void Login(string email, string password)
    {
        auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(task =>
        {
            if (task.IsCanceled)
            {
                Debug.LogError("�α��� ���");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("�α��� ����");
                return;
            }

            FirebaseUser newUser = task.Result.User;
            //FirebaseUser newUser = task.Result;
            Debug.LogError("�α��� �Ϸ�");
        });
    }

    public void LogOut()
    {
        auth.SignOut();
        Debug.Log("�α׾ƿ�");
    }
}