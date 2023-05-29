using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBgm : MonoBehaviour
{
    public Button button;
    private bool isOn = false;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(() => BgmOnOff());
    }

    public void BgmOnOff()
    {
        UnityEngine.Debug.Log("버튼눌림");
        GetComponent<AudioSource>().mute = !isOn;
        isOn = !isOn;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
