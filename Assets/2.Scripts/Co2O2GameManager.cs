using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;
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
    public GameObject canvas;

    public GameObject firepos1;


    float playTime;
    public int num = 0;
    public Vector3 firePosition;
    public int score;

    public List<GameObject> firePos = new List<GameObject> { };

    // 점수, 목숨
    public Image[] UILife;
    public Text UIScore;
    public Text ScoreResult;
    public GameObject GameOver;
    int point = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        playTime += Time.deltaTime;

        if (score < 10 && score >= 0)
        {
            if (playTime > 5)
            {
                createFire();
                playTime = 0;
            }


        }
        
    }

    public void createFire()
    {

        int range = Random.Range(0, firePos.Count);
        if (firePos[range].activeSelf == false)
        {
            Debug.Log("if문 활성화");
            firePosition = firePos[range].transform.position;
            firePos[range].SetActive(true);

            Debug.Log(range);
            fire.transform.position = firePosition;
            GameObject firepos = Instantiate(fire, firePosition, Quaternion.identity); // 버튼 누를 때 마다 Clone 생성은 잘 되는데 왜 불은 안보일까??..ㅎㅎ 이거 해결해야됨 -> canvas안에 안있어서 안보였던거임
            firepos.transform.SetParent(canvas.transform);

            //List<float> checkTime = new List<float>();
            //checkTime.Add(Time.deltaTime);
            //Destroy(firepos, 4.0f);
            StartCoroutine(DestroyFirePosAfterDelay(firepos, 6.0f, range));
            //if (checkTime[num] > 4)
            //{
            //    Debug.Log(checkTime[range]);
            //    firePos[range].SetActive(false);

            //    Debug.Log("비활성화 완료");

            //}
            //num++;
        }
        else
        {
            Debug.Log("if문 비활성화");
            createFire();
        }

    }

    private IEnumerator DestroyFirePosAfterDelay(GameObject firepos, float delay, int range)
    {
        yield return new WaitForSeconds(delay);

        // 지연 후에 firepos를 제거
        Destroy(firepos);

        // firePos[range]를 비활성화
        firePos[range].SetActive(false);
        Debug.Log("firePos[" + range + "] " + "비활성화 완료");
    }



    // 목숨 -1 시 색상 변경
    public void LifeDown(int life)
    {
        if (life > 0)
        {

            //색상변경
            UILife[life].color = new Color(1, 0, 0, 0.4f);
        }
        else
        {
            //색상변경
            UILife[0].color = new Color(1, 0, 0, 0.4f);

            //게임오버
            // 게임오버 후 클론 생성 멈춰야함!!
            // 씬 바꾸는 방식으로 해야하나...?
            GameOver.SetActive(true);
            ScoreResult.text = "Score: " + point.ToString();
            LifeUp();
        }
    }

    // Retry시 목숨 색 원래대로
    public void LifeUp()
    {
        for (int i = 0; i < 3; i++)
        {
            UILife[i].color = new Color(1, 0, 0, 1);
        }

    }

    // 점수 +10
    public void GetScore()
    {
        point += 10;
        SetText();
    }

    public void SetText()
    {
        UIScore.text = point.ToString();
    }


    // retry 버튼 클릭 시
    public void RetryOnClick()
    {
        GameOver.SetActive(false);
        point = 0;
        SetText();
    }

    // exit 버튼 클릭 시

}
