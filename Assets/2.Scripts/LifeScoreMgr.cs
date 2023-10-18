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

            //색상변경
            UILife[life].color = new Color(1, 0, 0, 0.4f);
        }
        else
        {
            //색상변경
            UILife[0].color = new Color(1, 0, 0, 0.4f);

            //게임오버구현
            
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
