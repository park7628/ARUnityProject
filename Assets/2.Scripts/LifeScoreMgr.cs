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

            //색상변경
            UILife[life].color = new Color(1, 0, 0, 0.4f);
        }
        else
        {
            //색상변경
            UILife[0].color = new Color(1, 0, 0, 0.4f);

            //게임오버
            // 이렇게 하면 불 나타나는거 멈춰야함!!
            // 씬 바꾸는걸로 해야하나...?

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

    // 점수 +10
    public void GetScore()
    {
        score += 10;
        SetText();
    }

    public void SetText()
    {
        UIScore.text = score.ToString();
    }


    // retry 버튼 클릭 시..
    public void RetryOnClick()
    {
        GameOver.SetActive(false);
        score = 0;
        SetText();
    }

    // exit 버튼 클릭 시
}
