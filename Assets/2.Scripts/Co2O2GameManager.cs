using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Co2O2GameManager : MonoBehaviour
{
    public Button hydrogenButton; //����ȭ���Ҽ�
    public Button hydrochloricButton; // ����
    public Button manganeseButton; // �̻�ȭ��������
    public Button limestoneButton; // ��ȸ��


    public Button test; //�����Ǵ��� Ȯ��
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
        Instantiate(fire, firePosition,Quaternion.identity); // ��ư ���� �� ���� Clone ������ �� �Ǵµ� �� ���� �Ⱥ��ϱ�??..���� �̰� �ذ��ؾߵ� 
        
    }
}
