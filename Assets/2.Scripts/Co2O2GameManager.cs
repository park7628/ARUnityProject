using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Co2O2GameManager : MonoBehaviour
{
    public Button hydrogenButton; //과산화수소수
    public Button hydrochloricButton; // 염산
    public Button manganeseButton; // 이산화망가니즈
    public Button limestoneButton; // 석회석


    public Button test; //생성되는지 확인
    public GameObject fire;
    public GameObject needFire;

    public GameObject firepos1;

    public Vector3 firePosition;
    public int score;

    public List<GameObject> firePos = new List<GameObject> {};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createFire()
    {
        
        int range = Random.Range(0, firePos.Count);
        firePosition = firePos[range].transform.position;
        
        fire.transform.position = firePosition;
        Instantiate(fire, firePosition,Quaternion.identity); // 버튼 누를 때 마다 Clone 생성은 잘 되는데 왜 불은 안보일까??..ㅎㅎ 이거 해결해야됨 
        
    }
}
