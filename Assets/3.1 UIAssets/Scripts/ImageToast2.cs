using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageToast2 : MonoBehaviour
{
    private Image img;
    private float fadeInOutTime = 0.3f;
    private static ImageToast2 instance2 = null;

    public static ImageToast2 Instrance2
    {
        get
        {
            if (null == instance2) instance2 = FindObjectOfType<ImageToast2>();
            return instance2;
        }
    }

    private void Awake()
    {
        if (null == instance2) instance2 = this;
    }

    void Start()
    {
        img = this.gameObject.GetComponent<Image>();
        img.enabled = false;
    }

    public void showImage2(float durationTime)
    {
        StartCoroutine(showImageCoroutine(durationTime));
    }

    private IEnumerator showImageCoroutine(float durationTime)
    {
        Color originalColor = img.color;
        img.enabled = true;

        yield return fadeInOut(img, fadeInOutTime, true);

        float elapsedTime = 0.0f;
        while (elapsedTime < durationTime)
        {
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        yield return fadeInOut(img, fadeInOutTime, false);

        img.enabled = false;
        img.color = originalColor;
    }

    private IEnumerator fadeInOut(Image target, float durationTime, bool inOut)
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
            end = 0.0f;
        }

        Color current = Color.clear;
        float elapsedTime = 0.0f;

        while (elapsedTime < durationTime)
        {
            float alpha = Mathf.Lerp(start, end, elapsedTime / durationTime);

            target.color = new Color(current.r, current.g, current.b, alpha);

            elapsedTime += Time.deltaTime;

            yield return null;
        }
    }
}


