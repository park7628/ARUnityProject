using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LifeScoreMgr : MonoBehaviour
{
    public Image[] UILife;
    public Text UIScore;
    int score = 0;

    public void LifeDown(int life)
    {
        if (life > 0)
        {

            //���󺯰�
            UILife[life].color = new Color(1, 0, 0, 0.4f);
        }
        else
        {
            //���󺯰�
            UILife[0].color = new Color(1, 0, 0, 0.4f);

            //���ӿ�������
            
        }
    }

    public void GetScore()
    {
        score += 10;
        SetText();
    }

    public void SetText()
    {
        UIScore.text = score.ToString();
    }
}
