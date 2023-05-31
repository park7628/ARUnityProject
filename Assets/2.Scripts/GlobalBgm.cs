using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBgm : MonoBehaviour
{

    [SerializeField] Image soundOnIcom;
    [SerializeField] Image soundOffIcom;

    public Button button;
    private bool isOn = false;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(() => BgmOnOff());

        //if (!PlayerPrefs.HasKey("isOn"))
        //{
        //    PlayerPrefs.SetInt("isOn", 0);
        //    Load();
        //}
        //else
        //{
        //    Load();
        //}
        UpdateIcone();
        //AudioListener.pause = isOn;
    }

    public void BgmOnOff()
    {
        UnityEngine.Debug.Log("버튼눌림");
        GetComponent<AudioSource>().mute = !isOn;
        UnityEngine.Debug.Log("버튼눌2");
        isOn = !isOn;

        //if (isOn == false)
        //{
        //    isOn = true;
        //    AudioListener.pause = true;

        //}
        //else
        //{
        //    isOn = false;
        //    AudioListener.pause = false;
        //}
        //Save();
        UpdateIcone();
    }

    private void UpdateIcone()
    {
        if(isOn == false)
        {
            soundOnIcom.enabled = true;
            soundOffIcom.enabled = false;
        }
        else
        {
            soundOnIcom.enabled = false;
            soundOffIcom.enabled = true;
        }
    }

    //private void Load()
    //{
    //    isOn = PlayerPrefs.GetInt("isOn") == 1;
    //}

    //private void Save()
    //{
    //    PlayerPrefs.SetInt("isOn", isOn ? 1: 0);
    //}

    // Update is called once per frame
    void Update()
    {
       
    }
}
