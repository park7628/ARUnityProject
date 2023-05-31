using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GlobalEffect : MonoBehaviour
{


    [SerializeField] Image soundOnIcom;
    [SerializeField] Image soundOffIcom;

    public Button button;
    private bool isOn = false;
    public GameObject scene1_Beaker;
    public GameObject scene1_Spatula;
    public GameObject scene4_Beaker;
    public GameObject scene5_Oxygen;
    public GameObject scene6_Vial;
    public GameObject scene6_Oxygen;
    public GameObject scene7_Vial;
    public GameObject scene7_Oxygen;
    public GameObject scene8_Oxygen;
    public GameObject scene8_Vial;
    public GameObject scene8_WatchGlass;



    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(() => BgmOnOff());

        
        UpdateIcone();
       
    }

    public void BgmOnOff()
    {
        UnityEngine.Debug.Log("버튼눌림");
        GetComponent<AudioSource>().mute = !isOn;
        scene1_Beaker.GetComponent<AudioSource>().mute = !isOn;
        scene1_Spatula.GetComponent<AudioSource>().mute = !isOn;
        scene4_Beaker.GetComponent<AudioSource>().mute = !isOn;
        scene5_Oxygen.GetComponent<AudioSource>().mute = !isOn;
        scene6_Vial.GetComponent<AudioSource>().mute = !isOn;
        scene6_Oxygen.GetComponent<AudioSource>().mute = !isOn;
        scene7_Vial.GetComponent<AudioSource>().mute = !isOn;
        scene7_Oxygen.GetComponent<AudioSource>().mute = !isOn;
        scene8_WatchGlass.GetComponent<AudioSource>().mute = !isOn;
        scene8_Oxygen.GetComponent<AudioSource>().mute = !isOn;
        scene8_Vial.GetComponent<AudioSource>().mute = !isOn;

        UnityEngine.Debug.Log("버튼눌2");
        isOn = !isOn;

        
        UpdateIcone();
    }

    private void UpdateIcone()
    {
        if (isOn == false)
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

    
    void Update()
    {

    }
}
