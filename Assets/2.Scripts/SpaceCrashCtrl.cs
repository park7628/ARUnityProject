using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Diagnostics;

public class SpaceCrashCtrl : MonoBehaviour
{

    Vector3 pos = new Vector3(0, 0, 0);
    Rigidbody rb;
    public GameObject SpaceGuideManager;
    //public GameObject sun;
    //public GameObject earth;
    //public GameObject moon;



    //public TMP_Text text;
    //private string name;

    private void OnTriggerEnter(Collider coll)
    {
        //UnityEngine.Debug.Log("Ãæµ¹");
        //if (this.gameObject.tag == coll.tag)
        //{
        //coll.transform.position = this.transform.position;
        //coll.transform.rotation = this.transform.rotation;
        if (this.gameObject.tag == "Sun" && coll.tag == "SunP")
        {
            Destroy(coll, 1.0f);

            this.gameObject.SetActive(false);
            SpaceGuideManager.GetComponent<SpaceGuideManager>().Gtext2();
        }
        else if (this.gameObject.tag == "Earth" && coll.tag == "EarthP")
        {
            Destroy(coll, 1.0f);

            this.gameObject.SetActive(false);
            SpaceGuideManager.GetComponent<SpaceGuideManager>().Gtext3();

        }
        else if (this.gameObject.tag == "Moon" && coll.tag == "MoonP")
        {
            Destroy(coll, 1.0f);

            this.gameObject.SetActive(false);
            SpaceGuideManager.GetComponent<SpaceGuideManager>().Gtext4();
        }
        else if (this.gameObject.tag == "Human" && coll.tag == "HumanP")
        {
            Destroy(coll.gameObject, 1.0f);

            this.gameObject.SetActive(false);
            SpaceGuideManager.GetComponent<SpaceGuideManager>().Gtext5();
        }

    }


}