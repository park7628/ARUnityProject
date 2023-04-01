using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class PanelCtrl : MonoBehaviour
{
    public GameObject Panel;
    //public ARRaycastManager arRaycaster;

    public void OpenPanel()
    {
        //Vector3 screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));

        //List<ARRaycastHit> press = new List<ARRaycastHit>();
        //arRaycaster.Raycast(screenCenter, press, TrackableType.Planes);

        if (Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("isOpen");

                animator.SetBool("isOpen", !isOpen);
            }

        }
    }
}
