using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToastClic : MonoBehaviour
{
    public void Toast()
    {
        ToastMsg.Instrance.showMessage("����� ����� ��!", 1.0f);
        ImageToast.Instrance.showImage(1.0f);
    }
}
