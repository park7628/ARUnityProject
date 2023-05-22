using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Z_Control : MonoBehaviour
{

    public Vector3 startVec;

    // Start is called before the first frame update
    void Start()
    {
        startVec = gameObject.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = gameObject.transform.localPosition;
        temp.z = startVec.z;
        gameObject.transform.localPosition = temp;
    }
}
