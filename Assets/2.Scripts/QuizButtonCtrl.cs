using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizButtonCtrl : MonoBehaviour
{
    public GameObject QuizPanel;
    public GameObject GuidePanel;
    public Button button;
    private bool isOn = false;

    public void QuizButtonClick()
    {
        if (GameManager.isFinish)
        {
            if (!isOn) //���������� ���� ����
            {
                GuidePanel.SetActive(false);
                button.interactable = false;
                button.gameObject.SetActive(false);
                QuizPanel.SetActive(true); //���� ����
                isOn = true;
            }
            else//���������� ���� �ݱ�
            {
                QuizPanel.SetActive(false); //���� �ݱ�
                GuidePanel.SetActive(true);
                button.interactable = true;
                button.gameObject.SetActive(true);
                isOn = false;

            }

        }


    }

    public void Close()
    {
        gameObject.SetActive(false);
        GuidePanel.SetActive(true);
        button.interactable = true;
        button.gameObject.SetActive(true);
        isOn = false;

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
