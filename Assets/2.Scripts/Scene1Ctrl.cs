using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
//using static System.Net.Mime.MediaTypeNames;
using TMPro;
public class Scene1Ctrl : MonoBehaviour
{ 
    private static GameObject Water;
    private static GameObject liquid1;
    private static GameObject Mangan;
    private static GameObject mangan;

    public Animator animator1;
    public Animator animator2;

    public Button button;

    public string animationTrigger1;
    public string animationTrigger2;

    public TextMeshProUGUI ScriptTxt;
    void Start()
    {
        ScriptTxt.text = "삼각 플라스크에 물을 조금 넣은 뒤 탄산 수소 나트륨을 4~5숟가락 넣는다.";
        Water = GameObject.FindWithTag("WATER");
        liquid1 = GameObject.FindWithTag("liquid1");
        Mangan = GameObject.FindWithTag("MANGANIZ");
        mangan = GameObject.FindWithTag("mangan");

        animator1 = Water.GetComponent<Animator>();
        animator2 = Mangan.GetComponent<Animator>();

        button = button.GetComponent<Button>();

        //UnityEngine.Debug.Log("버튼 가져옴");
        button.onClick.AddListener(PlayAnimation1);
        //UnityEngine.Debug.Log("addlistener 추가");


    }


    private void PlayAnimation1()
    {

            
            //UnityEngine.Debug.Log("애니메이션 함수 들어옴");

            if (Water != null && liquid1 != null)
            {
                //UnityEngine.Debug.Log("settrigger");
                animator1.SetTrigger(animationTrigger1);
                Water.GetComponent<Animator>().Play("Water");

                Invoke("IsWater", 1.7f);


                button.onClick.AddListener(PlayAnimation2);
                button.onClick.RemoveListener(PlayAnimation1);
            }
        
    }
   
    private void PlayAnimation2()
    {
     
            
            if (Mangan != null && mangan != null)
            {
                animator2.SetTrigger(animationTrigger2);
                Mangan.GetComponent<Animator>().Play("MANG");

                Invoke("IsMang", 2.5f);
                Invoke("ChangeScene12", 5.0f);
            }
       

    }
    private void IsWater()
    {
        liquid1.GetComponent<MeshRenderer>().enabled= true;
    }

    private void IsMang()
    {
        mangan.GetComponent<MeshRenderer>().enabled = true;
    }



    private void ChangeScene12()
    {
        GameManager.isScene0 = false;
        GameManager.isScene1 = true;
        
        button.onClick.RemoveListener(PlayAnimation2);
    }

    void Update()
    {
        touchWATERMANGANIZ();
    }
    public void touchWATERMANGANIZ()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit hit;
                Ray touchray = Camera.main.ScreenPointToRay(touch.position);

                if (Physics.Raycast(touchray, out hit))
                {
                    if (hit.collider.gameObject.tag == "Water")
                    {
                        if (Water != null && liquid1 != null)
                        {
                            PlayAnimation1();
                        }
                    }
                    if (hit.collider.gameObject.tag == "Mangan")
                    {
                        if (Mangan != null && mangan != null)
                        {
                            PlayAnimation2();
                        }
                        
                    }
                }
            }
        }
    }

}