using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashCtrl : MonoBehaviour
{
    Vector3 pos = new Vector3(0, 0, 0);
    Rigidbody rb;
    public GameObject funnel;
    public GameObject tube1;
    public GameObject pinch;
    public GameObject glasstube;
    //public GameObject lid;
    public GameObject flask;
    public GameObject tube2;
    public GameObject rtube;
    public GameObject tank_base;
    public GameObject watertank;
    public GameObject vial;

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("�浹����");
        if (other.tag == "material")
        {
            Debug.Log("material�� �浹����");
            switch (this.gameObject.tag)
            {
                case "funnel":
                    
                    Debug.Log("funnel �ν�");
                    
                    pos = new Vector3(0, 0.2764f, 0);
                    this.transform.position = Vector3.Lerp(this.transform.position, pos, 1f);
                    //rb.constraints = RigidbodyConstraints.FreezeAll;
                    //���߿� lerp ��� �ִϸ��̼����� ��ü?
                    
                    Debug.Log("�ű�");

                    this.gameObject.tag = "material2";
                    
                    //funnel ��Ȯ�� ��ġ�� �ű� Lerf �Լ� + funnel �±� material2�� ����
                    break;
            }
        }
        else if (other.tag == "material2")
        {
            switch (this.gameObject.tag)
            {
                case "tube1":
                    pos = new Vector3(0, 0.19f, 0);
                    this.transform.position = Vector3.Lerp(this.transform.position, pos, 1f);
                    funnel.gameObject.tag = "material";
                    this.gameObject.tag = "material2";
                    break;

                case "pinch":
                    pos = new Vector3(0, 0.115f, 0);
                    this.transform.position = Vector3.Lerp(this.transform.position, pos, 1f);
                    tube1.gameObject.tag = "material";
                    this.gameObject.tag = "material2";
                    break;
                case "glasstube"://������
                    pos = new Vector3(0, 0.0633f, 0);
                    this.transform.position = Vector3.Lerp(this.transform.position, pos, 1f);
                    pinch.gameObject.tag = "material";
                    this.gameObject.tag = "material2";
                    break;
                case "flask"://�����޸��ö�ũ
                    pos = new Vector3(0, -0.0664f, 0);
                    this.transform.position = Vector3.Lerp(this.transform.position, pos, 1f);
                    glasstube.gameObject.tag = "material";
                    this.gameObject.tag = "material2";
                    break;
                case "tube2": //������ ����
                    pos = new Vector3(0.0939f, -0.0078f, 0);
                    this.transform.position = Vector3.Lerp(this.transform.position, pos, 1f);
                    flask.gameObject.tag = "material";
                    this.gameObject.tag = "material2";
                    break;
                case "rtube": //���� ���� ����, tank_base �ٴ� SetActive true
                    pos = new Vector3(0.1717f, -0.007f, 0);
                    this.transform.position = Vector3.Lerp(this.transform.position, pos, 1f);
                    tube2.gameObject.tag = "material";
                    this.gameObject.tag = "material2";
                    tank_base.SetActive(true);
                    break;
                case "watertank"://���� �ٴڿ� ����, tank_base �ٴ� SetActive false
                    pos = new Vector3(0.3f, 0.005f, 0);
                    this.transform.position = Vector3.Lerp(this.transform.position, pos, 1f);
                    rtube.gameObject.tag = "material";
                    this.gameObject.tag = "material";
                    tank_base.SetActive(false);
                    break;
                case "vial"://���� �ٴڿ� ����, tank_base �ٴ� SetActive false
                    pos = new Vector3(0.3f, 0.005f, 0);
                    this.transform.position = Vector3.Lerp(this.transform.position, pos, 1f);
                    watertank.gameObject.tag = "material";
                    this.gameObject.tag = "material";
                    break;
            }
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
