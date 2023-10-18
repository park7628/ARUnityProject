using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LifeScoreMgr : MonoBehaviour
{
    public Image[] UILife;
    public Text UIScore;
    public Text ScoreResult;
    public GameObject GameOver;


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

            //���ӿ���
            // �̷��� �ϸ� �� ��Ÿ���°� �������!!
            // �� �ٲٴ°ɷ� �ؾ��ϳ�...?

            GameOver.SetActive(true);
            ScoreResult.text = "Score: " + score.ToString();
            LifeUp();
        }
    }

    public void LifeUp()
    {
        for (int i = 0; i < 3; i++)
        {
            UILife[i].color = new Color(1, 0, 0, 1);
        }

    }

    // ���� +10
    public void GetScore()
    {
        score += 10;
        SetText();
    }

    public void SetText()
    {
        UIScore.text = score.ToString();
    }


    // retry ��ư Ŭ�� ��..
    public void RetryOnClick()
    {
        GameOver.SetActive(false);
        score = 0;
        SetText();
    }

    // exit ��ư Ŭ�� ��
}
