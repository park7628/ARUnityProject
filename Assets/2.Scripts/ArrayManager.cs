using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ArrayManager : MonoBehaviour
{
    //public Image True;

    public void CArray()
    {
        var a1 = SlotManager1.a1;
        var a2 = SlotManager2.a2;

        if ((a1 == 2 && a2 == 3) || (a1 == 3 && a2 == 2))
        {
            Debug.Log("이산화탄소 발생");
        }
        else if ((a1 == 1 && a2 == 4) || (a1 == 4 && a2 == 1))
        {
            Debug.Log("산소 발생");
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
