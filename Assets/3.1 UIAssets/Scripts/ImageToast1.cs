using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageToast1 : MonoBehaviour
{
    private Image img;
    private float fadeInOutTime = 0.3f;
    private static ImageToast1 instance1 = null;

    public static ImageToast1 Instrance1
    {
        get
        {
            if (null == instance1) instance1 = FindObjectOfType<ImageToast1>();
            return instance1;
        }
    }

    private void Awake()
    {
        if (null == instance1) instance1 = this;
    }

    void Start()
    {
        img = this.gameObject.GetComponent<Image>();
        img.enabled = false;
    }

    public void showImage1(float durationTime)
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


