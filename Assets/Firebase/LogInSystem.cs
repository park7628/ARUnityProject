//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
////using System.Threading.Tasks;


//public class LogInSystem : MonoBehaviour
//{

//    public InputField email;
//    public InputField password;

//    public InputField getEmail;
//    public InputField getPassword;
//    public Text outputText;

//    public static InputField email2;
//    public static InputField password2;
//    // Start is called before the first frame update
//    void Start()
//    {
//        FirebaseLogInManager.Instance2.LoginState += OnChangedState;
//        FirebaseLogInManager.Instance2.Init();
//        email2 = email;
//        password2 = password;
//        //Debug.LogError("LogInSystem : " + email2);
//        //Debug.LogError("LogInSystem : " + password2);
//    }

//    private void OnChangedState(bool sign)
//    {
//        outputText.text = sign ? "로그인 : " : "로그아웃 : ";
//        outputText.text += FirebaseLogInManager.Instance2.UserId;
//    }

//    public void Create()
//    {
//        string e = getEmail.text;
//        string p = getPassword.text;

//        FirebaseLogInManager.Instance2.Create(e, p);
//    }
//    public static void LogIn()
//    {
//        //string e = email.text;
//        //string p = password.text;

//        string e = email2.text;
//        string p = password2.text;
//        Debug.LogError("LogInSystem2 : " + e);
//        Debug.LogError("LogInSystem2 : " + p);
//        FirebaseLogInManager.Instance2.Login(e, p);
//        GameObject.Find("LoginUIButtonManager").GetComponent<LoginUIButtonManager>().aa();
//    }
//    public void LogOut()
//    {
//        FirebaseLogInManager.Instance2.LogOut();
//    }
//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
