using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFlickering : MonoBehaviour
{

    private bool isOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn == false)
        {
            Flickering();
        }
    }


    public void Flickering()
    {
        Invoke("TurnOn", 0.7f);
        Invoke("TurnOff", 1.4f);
        
    }
    void TurnOn()
    {
        gameObject.GetComponent<Outline>().enabled = true;
        isOn = true;
    }
    void TurnOff()
    {
        gameObject.GetComponent<Outline>().enabled = false;
        isOn = false;
    }
}
