using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizUICtrl : MonoBehaviour
{

    #region
    private int answer1;
    private int answer2;
    private int answer3;
    private int answer4;
    private int answer5;

    public GameObject Question;
    public GameObject Answer;

    public GameObject check11;
    public GameObject check12;
    public GameObject check13;
    public GameObject check14;
    public GameObject check21;
    public GameObject check22;
    public GameObject check31;
    public GameObject check32;
    public GameObject check33;
    public GameObject check34;
    public GameObject check41;
    public GameObject check42;
    public GameObject check51;
    public GameObject check52;
    public GameObject check53;
    public GameObject check54;

    public GameObject right1;
    public GameObject right2;
    public GameObject right3;
    public GameObject right4;
    public GameObject right5;
    public GameObject wrong1;
    public GameObject wrong2;
    public GameObject wrong3;
    public GameObject wrong4;
    public GameObject wrong5;

    public GameObject check11a;
    public GameObject check12a;
    public GameObject check13a;
    public GameObject check21a;
    public GameObject check31a;
    public GameObject check33a;
    public GameObject check34a;
    public GameObject check42a;
    public GameObject check52a;
    public GameObject check53a;
    public GameObject check54a;

    #endregion

    public void button11()
    {
        answer1 = 1;
        check11.SetActive(true);
        check12.SetActive(false);
        check13.SetActive(false);
        check14.SetActive(false);
    }

    public void button12()
    {
        answer1 = 2;
        check11.SetActive(false);
        check12.SetActive(true);
        check13.SetActive(false);
        check14.SetActive(false);
    }

    public void button13()
    {
        answer1 = 3;
        check11.SetActive(false);
        check12.SetActive(false);
        check13.SetActive(true);
        check14.SetActive(false);
    }

    public void button14()
    {
        answer1 = 4;
        check11.SetActive(false);
        check12.SetActive(false);
        check13.SetActive(false);
        check14.SetActive(true);
    }

    public void button21()
    {
        answer2 = 1;
        check21.SetActive(true);
        check22.SetActive(false);
    }
    public void button22()
    {
        answer2 = 2;
        check21.SetActive(false);
        check22.SetActive(true);
    }

    public void button31()
    {
        answer3 = 1;
        check31.SetActive(true);
        check32.SetActive(false);
        check33.SetActive(false);
        check34.SetActive(false);
    }

    public void button32()
    {
        answer3 = 2;
        check31.SetActive(false);
        check32.SetActive(true);
        check33.SetActive(false);
        check34.SetActive(false);
    }

    public void button33()
    {
        answer3 = 3;
        check31.SetActive(false);
        check32.SetActive(false);
        check33.SetActive(true);
        check34.SetActive(false);
    }

    public void button34()
    {
        answer3 = 4;
        check31.SetActive(false);
        check32.SetActive(false);
        check33.SetActive(false);
        check34.SetActive(true);
    }

    public void button41()
    {
        answer4 = 1;
        check41.SetActive(true);
        check42.SetActive(false);
    }
    public void button42()
    {
        answer4 = 2;
        check41.SetActive(false);
        check42.SetActive(true);
    }

    public void button51()
    {
        answer5 = 1;
        check51.SetActive(true);
        check52.SetActive(false);
        check53.SetActive(false);
        check54.SetActive(false);
    }

    public void button52()
    {
        answer5 = 2;
        check51.SetActive(false);
        check52.SetActive(true);
        check54.SetActive(false);
        check54.SetActive(false);
    }

    public void button53()
    {
        answer5 = 3;
        check51.SetActive(false);
        check52.SetActive(false);
        check53.SetActive(true);
        check54.SetActive(false);
    }

    public void button54()
    {
        answer5 = 4;
        check51.SetActive(false);
        check52.SetActive(false);
        check53.SetActive(false);
        check54.SetActive(true);
    }
    
    public void scoring()
    {
        Question.SetActive(false);
        Answer.SetActive(true);

        //1번 문제
        if (answer1 == 1)
        {
            wrong1.SetActive(true);
            check11a.SetActive(true);
        }
        else if (answer1 == 2)
        {
            wrong1.SetActive(true);
            check12a.SetActive(true);
        }
        else if (answer1 == 3)
        {
            wrong1.SetActive(true);
            check13a.SetActive(true);
        }
        else
        {
            right1.SetActive(true);
        }

        //2번문제
        if (answer2 == 1)
        {
            wrong2.SetActive(true);
            check21a.SetActive(true);
        }
        else 
        { 
            right2.SetActive(true); 
        }

        //3번문제
        if (answer3 == 1)
        {
            wrong3.SetActive(true);
            check31a.SetActive(true);
        }
        else if (answer3 == 3)
        {
            wrong3.SetActive(true);
            check33a.SetActive(true);
        }
        else if (answer3 == 4)
        {
            wrong3.SetActive(true);
            check34a.SetActive(true);
        }
        else 
        { 
            right3.SetActive(true); 
        }

        //4번문제
        if (answer4 == 2)
        {
            wrong4.SetActive(true);
            check42a.SetActive(true);
        }
        else 
        {
            right4.SetActive(true); 
        }

        //5번문제
        if (answer5 == 2)
        {
            wrong5.SetActive(true);
            check52a.SetActive(true);
        }
        else if (answer5 == 3)
        {
            wrong5.SetActive(true);
            check53a.SetActive(true);
        }
        else if ( answer5 == 4)
        {
            wrong5.SetActive(true);
            check54a.SetActive(true);
        }
        else 
        { 
            right4.SetActive(true); 
        }
    }
}
