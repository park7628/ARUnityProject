using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainuisound2 : MonoBehaviour
{
    public Button soundonbutton1;
    public Button soundonbutton2;
    public Button soundonbutton3;
    public Button soundonbutton4;
    public Button soundonbutton5;
    public Button soundonbutton6;
    public Button soundonbutton7;
    public Button soundonbutton8;

    public Button soundoffbutton1;
    public Button soundoffbutton2;
    public Button soundoffbutton3;
    public Button soundoffbutton4;
    public Button soundoffbutton5;
    public Button soundoffbutton6;
    public Button soundoffbutton7;
    public Button soundoffbutton8;

    [SerializeField] Slider soundctrlslider1;
    [SerializeField] Slider soundctrlslider2;
    [SerializeField] Slider soundctrlslider3;
    [SerializeField] Slider soundctrlslider4;
    [SerializeField] Slider soundctrlslider5;
    [SerializeField] Slider soundctrlslider6;
    [SerializeField] Slider soundctrlslider7;
    [SerializeField] Slider soundctrlslider8;

    public GameObject sound1;
    public GameObject sound2;
    public GameObject sound3;

    public void soundctrl1()
    {
        soundctrlslider2.value = soundctrlslider1.value;
        soundctrlslider3.value = soundctrlslider1.value;
        soundctrlslider4.value = soundctrlslider1.value;
        soundctrlslider5.value = soundctrlslider1.value;
        soundctrlslider6.value = soundctrlslider1.value;
        soundctrlslider7.value = soundctrlslider1.value;
        soundctrlslider8.value = soundctrlslider1.value;
        sound1.GetComponent<AudioSource>().volume = soundctrlslider1.value;
    }

    public void soundctrl2()
    {
        soundctrlslider1.value = soundctrlslider2.value;
        soundctrlslider3.value = soundctrlslider2.value;
        soundctrlslider4.value = soundctrlslider2.value;
        soundctrlslider5.value = soundctrlslider2.value;
        soundctrlslider6.value = soundctrlslider2.value;
        soundctrlslider7.value = soundctrlslider2.value;
        soundctrlslider8.value = soundctrlslider2.value;
        sound1.GetComponent<AudioSource>().volume = soundctrlslider2.value;
    }

    public void soundctrl3()
    {
        soundctrlslider1.value = soundctrlslider3.value;
        soundctrlslider2.value = soundctrlslider3.value;
        soundctrlslider4.value = soundctrlslider3.value;
        soundctrlslider5.value = soundctrlslider3.value;
        soundctrlslider6.value = soundctrlslider3.value;
        soundctrlslider7.value = soundctrlslider3.value;
        soundctrlslider8.value = soundctrlslider3.value;
        sound1.GetComponent<AudioSource>().volume = soundctrlslider3.value;
    }

    public void soundctrl4()
    {
        soundctrlslider1.value = soundctrlslider4.value;
        soundctrlslider2.value = soundctrlslider4.value;
        soundctrlslider3.value = soundctrlslider4.value;
        soundctrlslider5.value = soundctrlslider4.value;
        soundctrlslider6.value = soundctrlslider4.value;
        soundctrlslider7.value = soundctrlslider4.value;
        soundctrlslider8.value = soundctrlslider4.value;
        sound1.GetComponent<AudioSource>().volume = soundctrlslider4.value;
    }

    public void soundctrl5()
    {
        soundctrlslider1.value = soundctrlslider5.value;
        soundctrlslider2.value = soundctrlslider5.value;
        soundctrlslider3.value = soundctrlslider5.value;
        soundctrlslider4.value = soundctrlslider5.value;
        soundctrlslider6.value = soundctrlslider5.value;
        soundctrlslider7.value = soundctrlslider5.value;
        soundctrlslider8.value = soundctrlslider5.value;
        sound1.GetComponent<AudioSource>().volume = soundctrlslider5.value;
    }

    public void soundctrl6()
    {
        soundctrlslider1.value = soundctrlslider6.value;
        soundctrlslider2.value = soundctrlslider6.value;
        soundctrlslider3.value = soundctrlslider6.value;
        soundctrlslider4.value = soundctrlslider6.value;
        soundctrlslider5.value = soundctrlslider6.value;
        soundctrlslider7.value = soundctrlslider6.value;
        soundctrlslider8.value = soundctrlslider6.value;
        sound1.GetComponent<AudioSource>().volume = soundctrlslider6.value;
    }

    public void soundctrl7()
    {
        soundctrlslider1.value = soundctrlslider7.value;
        soundctrlslider2.value = soundctrlslider7.value;
        soundctrlslider3.value = soundctrlslider7.value;
        soundctrlslider4.value = soundctrlslider7.value;
        soundctrlslider5.value = soundctrlslider7.value;
        soundctrlslider6.value = soundctrlslider7.value;
        soundctrlslider8.value = soundctrlslider7.value;
        sound1.GetComponent<AudioSource>().volume = soundctrlslider7.value;
    }

    public void soundctrl8()
    {
        soundctrlslider1.value = soundctrlslider8.value;
        soundctrlslider2.value = soundctrlslider8.value;
        soundctrlslider3.value = soundctrlslider8.value;
        soundctrlslider4.value = soundctrlslider8.value;
        soundctrlslider5.value = soundctrlslider8.value;
        soundctrlslider6.value = soundctrlslider8.value;
        soundctrlslider7.value = soundctrlslider8.value;
        sound1.GetComponent<AudioSource>().volume = soundctrlslider8.value;
    }

    public void soundoff()
    {
        sound1.GetComponent<AudioSource>().mute = true;
        sound2.GetComponent<AudioSource>().mute = true;
        sound3.GetComponent<AudioSource>().mute = true;

        soundonbutton1.gameObject.SetActive(false);
        soundonbutton2.gameObject.SetActive(false);
        soundonbutton3.gameObject.SetActive(false);
        soundonbutton4.gameObject.SetActive(false);
        soundonbutton5.gameObject.SetActive(false);
        soundonbutton6.gameObject.SetActive(false);
        soundonbutton7.gameObject.SetActive(false);
        soundonbutton8.gameObject.SetActive(false);

        soundoffbutton1.gameObject.SetActive(true);
        soundoffbutton2.gameObject.SetActive(true);
        soundoffbutton3.gameObject.SetActive(true);
        soundoffbutton4.gameObject.SetActive(true);
        soundoffbutton5.gameObject.SetActive(true);
        soundoffbutton6.gameObject.SetActive(true);
        soundoffbutton7.gameObject.SetActive(true);
        soundoffbutton8.gameObject.SetActive(true);
    }

    public void soundon()
    {
        sound1.GetComponent<AudioSource>().mute = false;
        sound2.GetComponent<AudioSource>().mute = false;
        sound3.GetComponent<AudioSource>().mute = false;

        soundonbutton1.gameObject.SetActive(true);
        soundonbutton2.gameObject.SetActive(true);
        soundonbutton3.gameObject.SetActive(true);
        soundonbutton4.gameObject.SetActive(true);
        soundonbutton5.gameObject.SetActive(true);
        soundonbutton6.gameObject.SetActive(true);
        soundonbutton7.gameObject.SetActive(true);
        soundonbutton8.gameObject.SetActive(true);

        soundoffbutton1.gameObject.SetActive(false);
        soundoffbutton2.gameObject.SetActive(false);
        soundoffbutton3.gameObject.SetActive(false);
        soundoffbutton4.gameObject.SetActive(false);
        soundoffbutton5.gameObject.SetActive(false);
        soundoffbutton6.gameObject.SetActive(false);
        soundoffbutton7.gameObject.SetActive(false);
        soundoffbutton8.gameObject.SetActive(false);
    }
}
