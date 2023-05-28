using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quizanswer : MonoBehaviour
{
    public GameObject Question;
    public GameObject Answer;

    public void scoring()
    {
        Question.SetActive(false);
        Answer.SetActive(true);
    }
}
