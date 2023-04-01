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
        Debug.Log("충돌했음");
        if (other.tag == "material")
        {
            Debug.Log("material에 충돌했음");
            switch (this.gameObject.tag)
            {
                case "funnel":
                    
                    Debug.Log("funnel 인식");
                    
                    pos = new Vector3(0, 0.2764f, 0);
                    this.transform.position = Vector3.Lerp(this.transform.position, pos, 1f);
                    //rb.constraints = RigidbodyConstraints.FreezeAll;
                    //나중에 lerp 대신 애니메이션으로 대체?
                    
                    Debug.Log("옮김");

                    this.gameObject.tag = "material2";
                    
                    //funnel 정확한 위치로 옮김 Lerf 함수 + funnel 태그 material2로 변경
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
                case "glasstube"://유리관
                    pos = new Vector3(0, 0.0633f, 0);
                    this.transform.position = Vector3.Lerp(this.transform.position, pos, 1f);
                    pinch.gameObject.tag = "material";
                    this.gameObject.tag = "material2";
                    break;
                case "flask"://가지달린플라스크
                    pos = new Vector3(0, -0.0664f, 0);
                    this.transform.position = Vector3.Lerp(this.transform.position, pos, 1f);
                    glasstube.gameObject.tag = "material";
                    this.gameObject.tag = "material2";
                    break;
                case "tube2": //가지에 고무관
                    pos = new Vector3(0.0939f, -0.0078f, 0);
                    this.transform.position = Vector3.Lerp(this.transform.position, pos, 1f);
                    flask.gameObject.tag = "material";
                    this.gameObject.tag = "material2";
                    break;
                case "rtube": //고무관 끝에 ㄱ자, tank_base 바닥 SetActive true
                    pos = new Vector3(0.1717f, -0.007f, 0);
                    this.transform.position = Vector3.Lerp(this.transform.position, pos, 1f);
                    tube2.gameObject.tag = "material";
                    this.gameObject.tag = "material2";
                    tank_base.SetActive(true);
                    break;
                case "watertank"://수조 바닥에 수조, tank_base 바닥 SetActive false
                    pos = new Vector3(0.3f, 0.005f, 0);
                    this.transform.position = Vector3.Lerp(this.transform.position, pos, 1f);
                    rtube.gameObject.tag = "material";
                    this.gameObject.tag = "material";
                    tank_base.SetActive(false);
                    break;
                case "vial"://수조 바닥에 수조, tank_base 바닥 SetActive false
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
