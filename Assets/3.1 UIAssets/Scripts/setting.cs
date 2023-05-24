using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setting : MonoBehaviour
{
    public GameObject set;
    
    public void setscreen(){
        set.SetActive(true);
    }

    public void setout(){
        set.SetActive(false);
    }

    // 소리 끄고 켜기, 로그아웃, 회원탈퇴 여기서 진행
}
