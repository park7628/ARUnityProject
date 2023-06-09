using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scene8Ctrl : MonoBehaviour
{
    private static GameObject oxygen;
    private static GameObject vial;
    private static GameObject glass;
    private static GameObject glass2;
    public Button button;
    public Animator animator;
    public string animationTrigger;
    public Animator animator1;
    public string animationTrigger1;
    public Animator animator2;
    public string animationTrigger2;

    private static GameObject gameobject;
    public TextMeshProUGUI ScriptTxt;

    // Start is called before the first frame update
    void Start()
    {
        button.interactable = true;
        ScriptTxt.text = "집기병에 이산화탄소가 \r\n가득 차면 물속에서 \r\n유리판으로 집기병 입구를 \r\n막고 꺼낸다.";
        oxygen = GameObject.FindWithTag("oxygen");
        animator = oxygen.GetComponent<Animator>();
        animator.SetTrigger(animationTrigger);
        oxygen.GetComponent<Animator>().Play("oxygen");

        vial = GameObject.FindWithTag("vial");
        glass = GameObject.FindWithTag("glass");
        glass2 = GameObject.FindWithTag("glass2");
        glass2.SetActive(false);
        gameobject = GameObject.FindWithTag("gameobject");
        //gameobject.SetActive(false);
        //oxygen.SetActive(false);
        animator1 = glass.GetComponent<Animator>();
        animator2 = vial.GetComponent<Animator>();
        button = button.GetComponent<Button>();
        button.onClick.AddListener(PlayAnimation9);
    }

    public void PlayAnimation9()
    {
        button.interactable = false;
        if (vial != null)
        {
            animator1.SetTrigger(animationTrigger1);
            glass.GetComponent<Animator>().Play("glass");
            Invoke("vialmoving", 3.5f);
            Invoke("removegameobject", 4.0f);
            Invoke("ChangeScene89", 7.0f);

        }
    }
    private void vialmoving()
    {
        glass.SetActive(false);
        glass2.SetActive(true);
        animator2.SetTrigger(animationTrigger2);
        vial.GetComponent<Animator>().Play("vial3");

    }
    private void removegameobject()
    {
        gameobject.SetActive(false);
    }
    private void ChangeScene89()
    {
        ScriptTxt.text = "집기병에 순수한 \r\n이산화탄소만 존재한다.";
        GameManager.isScene7 = false;
        GameManager.isScene8 = true;
        button.onClick.RemoveListener(PlayAnimation9);

    }

    void Update()
    {
        touchglass_plate();
    }

    public void touchglass_plate()
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
                    if (hit.collider.gameObject.tag == "glass")
                    {
                        //유리병 입구가 막히고 집기병이 수조 밖으로 나온다 다른 장치들은 사라지고 집기병만 가운데에
                        PlayAnimation9();

                    }
                }
            }
        }
    }
}
