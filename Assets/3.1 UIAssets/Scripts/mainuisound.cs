using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainuisound : MonoBehaviour
{

    public Button bgmonbutton1;
    public Button bgmonbutton2;
    public Button bgmonbutton3;
    public Button bgmonbutton4;
    public Button bgmonbutton5;
    public Button bgmonbutton6;
    public Button bgmonbutton7;
    public Button bgmonbutton8;

    public Button bgmoffbutton1;
    public Button bgmoffbutton2;
    public Button bgmoffbutton3;
    public Button bgmoffbutton4;      
    public Button bgmoffbutton5;
    public Button bgmoffbutton6;
    public Button bgmoffbutton7;
    public Button bgmoffbutton8;

    [SerializeField] Slider bgmctrlslider1;
    [SerializeField] Slider bgmctrlslider2;
    [SerializeField] Slider bgmctrlslider3;
    [SerializeField] Slider bgmctrlslider4;
    [SerializeField] Slider bgmctrlslider5;
    [SerializeField] Slider bgmctrlslider6;
    [SerializeField] Slider bgmctrlslider7;
    [SerializeField] Slider bgmctrlslider8;

    public GameObject bgmsound;

    public void bgmctrl1()
    {
        bgmctrlslider2.value = bgmctrlslider1.value;
        bgmctrlslider3.value = bgmctrlslider1.value;
        bgmctrlslider4.value = bgmctrlslider1.value;
        bgmctrlslider5.value = bgmctrlslider1.value;
        bgmctrlslider6.value = bgmctrlslider1.value;
        bgmctrlslider7.value = bgmctrlslider1.value;
        bgmctrlslider8.value = bgmctrlslider1.value;
        bgmsound.GetComponent<AudioSource>().volume = bgmctrlslider1.value;
    }

    public void bgmctrl2()
    {
        bgmctrlslider1.value = bgmctrlslider2.value;
        bgmctrlslider3.value = bgmctrlslider2.value;
        bgmctrlslider4.value = bgmctrlslider2.value;
        bgmctrlslider5.value = bgmctrlslider2.value;
        bgmctrlslider6.value = bgmctrlslider2.value;
        bgmctrlslider7.value = bgmctrlslider2.value;
        bgmctrlslider8.value = bgmctrlslider2.value;
        bgmsound.GetComponent<AudioSource>().volume = bgmctrlslider2.value;
    }

    public void bgmctrl3()
    {
        bgmctrlslider1.value = bgmctrlslider3.value;
        bgmctrlslider2.value = bgmctrlslider3.value;
        bgmctrlslider4.value = bgmctrlslider3.value;
        bgmctrlslider5.value = bgmctrlslider3.value;
        bgmctrlslider6.value = bgmctrlslider3.value;
        bgmctrlslider7.value = bgmctrlslider3.value;
        bgmctrlslider8.value = bgmctrlslider3.value;
        bgmsound.GetComponent<AudioSource>().volume = bgmctrlslider3.value;
    }

    public void bgmctrl4()
    {
        bgmctrlslider1.value = bgmctrlslider4.value;
        bgmctrlslider2.value = bgmctrlslider4.value;
        bgmctrlslider3.value = bgmctrlslider4.value;
        bgmctrlslider5.value = bgmctrlslider4.value;
        bgmctrlslider6.value = bgmctrlslider4.value;
        bgmctrlslider7.value = bgmctrlslider4.value;
        bgmctrlslider8.value = bgmctrlslider4.value;
        bgmsound.GetComponent<AudioSource>().volume = bgmctrlslider4.value;
    }

    public void bgmctrl5()
    {
        bgmctrlslider1.value = bgmctrlslider5.value;
        bgmctrlslider2.value = bgmctrlslider5.value;
        bgmctrlslider3.value = bgmctrlslider5.value;
        bgmctrlslider4.value = bgmctrlslider5.value;
        bgmctrlslider6.value = bgmctrlslider5.value;
        bgmctrlslider7.value = bgmctrlslider5.value;
        bgmctrlslider8.value = bgmctrlslider5.value;
        bgmsound.GetComponent<AudioSource>().volume = bgmctrlslider5.value;
    }

    public void bgmctrl6()
    {
        bgmctrlslider1.value = bgmctrlslider6.value;
        bgmctrlslider2.value = bgmctrlslider6.value;
        bgmctrlslider3.value = bgmctrlslider6.value;
        bgmctrlslider4.value = bgmctrlslider6.value;
        bgmctrlslider5.value = bgmctrlslider6.value;
        bgmctrlslider7.value = bgmctrlslider6.value;
        bgmctrlslider8.value = bgmctrlslider6.value;
        bgmsound.GetComponent<AudioSource>().volume = bgmctrlslider6.value;
    }

    public void bgmctrl7()
    {
        bgmctrlslider1.value = bgmctrlslider7.value;
        bgmctrlslider2.value = bgmctrlslider7.value;
        bgmctrlslider3.value = bgmctrlslider7.value;
        bgmctrlslider4.value = bgmctrlslider7.value;
        bgmctrlslider5.value = bgmctrlslider7.value;
        bgmctrlslider6.value = bgmctrlslider7.value;
        bgmctrlslider8.value = bgmctrlslider7.value;
        bgmsound.GetComponent<AudioSource>().volume = bgmctrlslider7.value;
    }

    public void bgmctrl8()
    {
        bgmctrlslider1.value = bgmctrlslider8.value;
        bgmctrlslider2.value = bgmctrlslider8.value;
        bgmctrlslider3.value = bgmctrlslider8.value;
        bgmctrlslider4.value = bgmctrlslider8.value;
        bgmctrlslider5.value = bgmctrlslider8.value;
        bgmctrlslider6.value = bgmctrlslider8.value;
        bgmctrlslider7.value = bgmctrlslider8.value;
        bgmsound.GetComponent<AudioSource>().volume = bgmctrlslider8.value;
    }

    public void bgmoff()
    {
        bgmsound.GetComponent<AudioSource>().mute = true;
        bgmonbutton1.gameObject.SetActive(false);
        bgmonbutton2.gameObject.SetActive(false);
        bgmonbutton3.gameObject.SetActive(false);
        bgmonbutton4.gameObject.SetActive(false);
        bgmonbutton5.gameObject.SetActive(false);
        bgmonbutton6.gameObject.SetActive(false);
        bgmonbutton7.gameObject.SetActive(false);
        bgmonbutton8.gameObject.SetActive(false);

        bgmoffbutton1.gameObject.SetActive(true);
        bgmoffbutton2.gameObject.SetActive(true);
        bgmoffbutton3.gameObject.SetActive(true);
        bgmoffbutton4.gameObject.SetActive(true);
        bgmoffbutton5.gameObject.SetActive(true);
        bgmoffbutton6.gameObject.SetActive(true);
        bgmoffbutton7.gameObject.SetActive(true);
        bgmoffbutton8.gameObject.SetActive(true);
    }

    public void bgmon()
    {
        bgmsound.GetComponent<AudioSource>().mute = false;
        bgmonbutton1.gameObject.SetActive(true);
        bgmonbutton2.gameObject.SetActive(true);
        bgmonbutton3.gameObject.SetActive(true);
        bgmonbutton4.gameObject.SetActive(true);
        bgmonbutton5.gameObject.SetActive(true);
        bgmonbutton6.gameObject.SetActive(true);
        bgmonbutton7.gameObject.SetActive(true);
        bgmonbutton8.gameObject.SetActive(true);

        bgmoffbutton1.gameObject.SetActive(false);
        bgmoffbutton2.gameObject.SetActive(false);
        bgmoffbutton3.gameObject.SetActive(false);
        bgmoffbutton4.gameObject.SetActive(false);
        bgmoffbutton5.gameObject.SetActive(false);
        bgmoffbutton6.gameObject.SetActive(false);
        bgmoffbutton7.gameObject.SetActive(false);
        bgmoffbutton8.gameObject.SetActive(false);

    }
}
