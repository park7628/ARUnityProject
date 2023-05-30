using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuideUIButtonCtrl : MonoBehaviour
{
    public GameObject GuidePanel;
    public Button button;
    static public bool isOn = false;

    public void GuideButtonClick()
    {
            if (!isOn) //닫혀있으면 다른UI 열기
            {
                GuidePanel.SetActive(false);
                button.interactable = false;
                button.gameObject.SetActive(false);

                isOn = true;
            }
            else//열려있으면 퀴즈 닫기
            {
                GuidePanel.SetActive(true);
                button.interactable = true;
                button.gameObject.SetActive(true);
                isOn = false;
            }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
