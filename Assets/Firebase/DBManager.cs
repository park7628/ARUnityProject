using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;
using Firebase;
using Firebase.Database;
using System;
using Firebase.Extensions;

public class DBManager : MonoBehaviour
{
    
    //DatabaseReference reference;
    // Start is called before the first frame update
    public DataBase dataBase;

    public InputField emileInput;
    public InputField groupInput;
    public InputField numInput;
    public InputField idInput;
    public InputField userNameInput;
    public InputField pwInput;
    public InputField yyInput;
    public InputField mmInput;
    public InputField ddInput;

    public InputField emileInputT;
    //public InputField groupInputT;
    //public InputField numInputT;
    public InputField idInputT;
    public InputField userNameInputT;
    public InputField pwInputT;
    public InputField yyInputT;
    public InputField mmInputT;
    public InputField ddInputT;

    public InputField groupCodeSet;



    public void InputStudentData()
    {
        string emaile = emileInput.text;
        string group = groupInput.text;
        string num = numInput.text;
        string id = idInput.text;
        string userName = userNameInput.text;
        string pw = pwInput.text;
        string yy = yyInput.text;
        string mm = mmInput.text;
        string dd = ddInput.text;

        dataBase.WriteDBStudent(emaile, group, num, id, userName, pw, yy, mm, dd);
    }

    public void InputTeacherData()
    {
        string emaile = emileInputT.text;
        //string group = groupInputT.text;
        //string num = numInputT.text;
        string id = idInputT.text;
        string userName = userNameInputT.text;
        string pw = pwInputT.text;
        string yy = yyInputT.text;
        string mm = mmInputT.text;
        string dd = ddInputT.text;

        dataBase.WriteDBTeacher(emaile, id, userName, pw, yy, mm, dd);
    }

    public void InputGuoupSet()
    {
        string code = groupCodeSet.text;

        dataBase.InputGroupSetWrite(code);
    }
    //public void WriteDBStudent(string emaile, string id, string name, string pw , string yy, string mm, string dd)
    //{
    //    //DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
    //    DatabaseReference reference = FirebaseDatabase.DefaultInstance.GetReference("Division");
    //    string key = reference.Push().Key;

    //    Dictionary<string, string> userData = new Dictionary<string, string>();
    //    userData.Add("Emaile", emaile);
    //    //userData.Add("Group", group);
    //    //userData.Add("Num", num);
    //    userData.Add("ID", id);
    //    userData.Add("Name", name);
    //    userData.Add("PW", pw);
    //    userData.Add("Who", "student");
    //    userData.Add("YY", yy);
    //    userData.Add("MM", mm);
    //    userData.Add("DD", dd);
        
    //    Dictionary<string, object> userInfo = new Dictionary<string, object>();
    //    userInfo.Add(key, userData);

    //    reference.UpdateChildrenAsync(userInfo).ContinueWithOnMainThread(task => 
    //    {
    //        if (task.IsFaulted)
    //        {
    //            Debug.LogError("실패");
    //            return;
    //        }
    //        if (task.IsCanceled) {
    //            Debug.LogError("취소");
    //            return; 
    //        }

    //        if(task.IsCompleted)
    //        {
    //            Debug.LogError("잘 전달 됨");
    //        }
    //    });

    //}

    //public void WriteDBTeacher(string emaile, string group, string num, string id, string name, string pw, string yy, string mm, string dd)
    //{
    //    //DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
    //    DatabaseReference reference = FirebaseDatabase.DefaultInstance.GetReference("Division");
    //    string key = reference.Push().Key;

    //    Dictionary<string, string> userData = new Dictionary<string, string>();
    //    userData.Add("Emaile", emaile);
    //    userData.Add("Group", group);
    //    userData.Add("Num", num);
    //    userData.Add("ID", id);
    //    userData.Add("Name", name);
    //    userData.Add("PW", pw);
    //    userData.Add("Who", "teacher");
    //    userData.Add("YY", yy);
    //    userData.Add("MM", mm);
    //    userData.Add("DD", dd);

    //    Dictionary<string, object> userInfo = new Dictionary<string, object>();
    //    userInfo.Add(key, userData);

    //    reference.UpdateChildrenAsync(userInfo).ContinueWithOnMainThread(task =>
    //    {
    //        if (task.IsFaulted)
    //        {
    //            Debug.LogError("실패");
    //            return;
    //        }
    //        if (task.IsCanceled)
    //        {
    //            Debug.LogError("취소");
    //            return;
    //        }

    //        if (task.IsCompleted)
    //        {
    //            Debug.LogError("잘 전달 됨");
    //        }
    //    });

    //}

    public void ReadDB()
    {

    }
    void Start()
    {
        //FirebaseApp.DefaultInstance.Options.DatabaseUrl = new Uri(DBurl);
        //WriteDB();
        //ReadDB();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
