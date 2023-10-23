using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToastGame : MonoBehaviour
{
    public void Toast()
    {
        ToastMsg2.Instrance2.showMessage2("게임 만드는 중!", 1.0f);
        ImageToast2.Instrance2.showImage2(1.0f);
    }
}

