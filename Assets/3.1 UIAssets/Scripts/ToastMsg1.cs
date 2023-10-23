using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToastMsg1 : MonoBehaviour
{
    private Text txt;
    private float fadeInOutTime = 0.3f;
    private static ToastMsg1 instance1 = null;

    public static ToastMsg1 Instrance1
    {
        get
        {
            if (null == instance1) instance1 = FindObjectOfType<ToastMsg1>();
            return instance1;
        }
    }

    private void Awake()
    {
        if (null == instance1) instance1 = this;
    }

    void Start()
    {
        txt = this.gameObject.GetComponent<Text>();
        txt.enabled = false;
    }

    public void showMessage1(string msg, float durationTime)
    {
        StartCoroutine(showMessageCoroutine(msg, durationTime));
    }

    private IEnumerator showMessageCoroutine(string msg, float durationTime)
    {
        Color originalColor = txt.color;
        txt.text = msg;
        txt.enabled = true;

        yield return fadeInOut(txt, fadeInOutTime, true);

        float elapsedTime = 0.0f;
        while (elapsedTime < durationTime)
        {
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        yield return fadeInOut(txt, fadeInOutTime, false);

        txt.enabled = false;
        txt.color = originalColor;
    }

    private IEnumerator fadeInOut(Text target, float durationTime, bool inOut)
    {
        float start, end;
        if (inOut)
        {
            start = 0.0f;
            end = 1.0f;
        }
        else
        {
            start = 1.0f;
            end = 0f;
        }

        Color current = Color.clear;
        float elapsedTime = 0.0f;

        while (elapsedTime < durationTime)
        {
            float alpha = Mathf.Lerp(start, end, elapsedTime / durationTime);

            target.color = new Color(255, 255, 255, alpha);

            elapsedTime += Time.deltaTime;

            yield return null;
        }
    }
}