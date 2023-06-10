using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;
using Firebase;
using Firebase.Auth;
using Firebase.Database;
using System.Threading.Tasks;
using System;
using Firebase.Extensions;
//using UnityEditor.VersionControl;

public class DataBase : MonoBehaviour
{
    public string DBurl = "https://arandroid-6daa0-default-rtdb.firebaseio.com/";
    // Start is called before the first frame update

    public static string readEmail;
    public static string readGroup;
    public static string readNum;
    public static string readID;
    public static string readName;
    public static string readPW;
    public static string readYY;
    public static string readMM;
    public static string readDD;

    void Start()
    {
        FirebaseApp.DefaultInstance.Options.DatabaseUrl = new Uri(DBurl);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dataGet(string e, string g, string n, string i, string na, string p, string y, string m, string d)
    {
        readEmail = e;
        readGroup = g;
        readNum = n;
        readID = i;
        readName = na;
        readPW = p;
        readYY = y;
        readMM = m;
        readDD = d;
        
    }

    public void readDB()
    {
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.GetReference("Division");
        reference.GetValueAsync().ContinueWithOnMainThread(task =>
        {
            if (task.IsFaulted) 
            {
                Debug.LogError("데이터 불러오기 실패");
            }

            if (task.IsCanceled)
            {
                Debug.LogError("데이터 불러오기 중지");
            }

            if (task.IsCompleted)
            {

                Debug.LogError("DataBase접근");
                DataSnapshot snapshot = task.Result;
                foreach (var data in snapshot.Children)
                {

                    IDictionary dataGet = (IDictionary)data.Value;
                    //for (int i = 0; i < data.ChildrenCount; i++)
                    //{
                    //    if (FirebaseLogInManager.checkEmail.text == data.Child("Emaile").Value.ToString())
                    //    {
                    //        Debug.LogError(data.Key + " " + data.Child("Email").Value.ToString());
                    //        FirebaseLogInManager.checkUser.text = data.Child("Who").Value.ToString();
                    //        Debug.LogError(FirebaseLogInManager.checkUser.text);
                    //    }
                    //}
                }
                Debug.LogError(readNum);
            }
        });
    }

    public void WriteDBStudent(string emaile, string group, string num, string id, string name, string pw, string yy, string mm, string dd)
    {
        //DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.GetReference("Division");
        string key = reference.Push().Key;

        Dictionary<string, string> userData = new Dictionary<string, string>();
        userData.Add("Emaile", emaile);
        userData.Add("Group", group);
        userData.Add("Num", num);
        userData.Add("ID", id);
        userData.Add("Name", name);
        userData.Add("PW", pw);
        userData.Add("Who", "student");
        userData.Add("YY", yy);
        userData.Add("MM", mm);
        userData.Add("DD", dd);

        Dictionary<string, object> userInfo = new Dictionary<string, object>();
        userInfo.Add(id, userData);

        reference.UpdateChildrenAsync(userInfo).ContinueWithOnMainThread(task =>
        {
            //if (task.IsFaulted)
            //{
            //    Debug.LogError("실패");
            //    return;
            //}
            //if (task.IsCanceled)
            //{
            //    Debug.LogError("취소");
            //    return;
            //}

            if (task.IsCompleted)
            {
                Debug.LogError("잘 전달 됨");
            }
        });

    }

    public void WriteDBTeacher(string emaile,  string id, string name, string pw, string yy, string mm, string dd)
    {
        //DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.GetReference("Division");
        string key = reference.Push().Key;

        Dictionary<string, string> userData = new Dictionary<string, string>();
        userData.Add("Emaile", emaile);
        //userData.Add("Group", group);
        //userData.Add("Num", num);
        userData.Add("ID", id);
        userData.Add("Name", name);
        userData.Add("PW", pw);
        userData.Add("Who", "teacher");
        userData.Add("YY", yy);
        userData.Add("MM", mm);
        userData.Add("DD", dd);

        Dictionary<string, object> userInfo = new Dictionary<string, object>();
        userInfo.Add(id, userData);

        reference.UpdateChildrenAsync(userInfo).ContinueWithOnMainThread(task =>
        {
            //if (task.IsFaulted)
            //{
            //    Debug.LogError("실패");
            //    return;
            //}
            //if (task.IsCanceled)
            //{
            //    Debug.LogError("취소");
            //    return;
            //}

            if (task.IsCompleted)
            {
                Debug.LogError("잘 전달 됨");
            }
        });

    }


    public void InputGroupSetWrite(string groupCode)
    {
        ////DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
        //DatabaseReference reference = FirebaseDatabase.DefaultInstance.GetReference("Division");
        //string key = reference.Push().Key;

        //Dictionary<string, string> userData = new Dictionary<string, string>();
        //userData.Add("GroupCode", groupCode);
        

        //Dictionary<string, object> userInfo = new Dictionary<string, object>();
        //userInfo.Add(FirebaseLogInManager.checkEmail.text, userData);

        //reference.UpdateChildrenAsync(userInfo).ContinueWithOnMainThread(task =>
        //{
        //    //if (task.IsFaulted)
        //    //{
        //    //    Debug.LogError("실패");
        //    //    return;
        //    //}
        //    //if (task.IsCanceled)
        //    //{
        //    //    Debug.LogError("취소");
        //    //    return;
        //    //}

        //    if (task.IsCompleted)
        //    {
        //        Debug.LogError("잘 전달 됨");
        //    }
        //});

    }
}
