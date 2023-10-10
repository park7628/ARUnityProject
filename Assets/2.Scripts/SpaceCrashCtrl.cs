using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
        if (this.gameObject.tag == coll.tag)
        {
            coll.transform.position = this.transform.position;
            coll.transform.rotation = this.transform.rotation;
            if(coll.tag == "Sun")
            {
                SpaceGuideManager.GetComponent<SpaceGuideManager>().Gtext2();
            }
            else if (coll.tag == "Earth")
            {
                SpaceGuideManager.GetComponent<SpaceGuideManager>().Gtext3();
            }
            else //Moon
            {
                SpaceGuideManager.GetComponent<SpaceGuideManager>().Gtext4();
            }
            //coll.transform.scale = this.transform.scale;
            //name = coll.tag;
            //Crash();
            this.gameObject.SetActive(false);

            Destroy(coll, 1.0f);

        }
    }


    private void Crash()
    {
        //text.text = name + "Crash";
    }
}
