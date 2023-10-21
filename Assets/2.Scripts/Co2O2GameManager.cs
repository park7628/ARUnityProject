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
    public GameObject FireParent;

    public GameObject firepos1;
    public static int checkFireRange;
    public static int checkNeedFireRange;
    public static List<int> missFire = new List<int> { }; // 불꽃을 놓쳤을 때 점수를 깍기 위한
    public static List<int> missNeedFire = new List<int> { };


    
    float playTime;
    float fireTime;
    float needFireTime;
    public int num = 0;
    public Vector3 firePosition;
    public Vector3 needFirePosition;
    public int score;
    public int game; // 게임 실행 변수
    public List<GameObject> firePos = new List<GameObject> { }; //불꽃 생성 위치
    public List<GameObject> needFirePos = new List<GameObject> { }; //후라이팬 생성 위치

    // 점수, 목숨
    public Image[] UILife;
    public Text UIScore;
    public Text ScoreResult;
    public GameObject GameOver;
    int point = 0;

    // Start is called before the first frame update
    void Start()
    {
        for( int i = 0; i < firePos.Count; i++ )
        {
            missFire.Add(0);
        }
        for (int i = 0; i < needFirePos.Count; i++)
        {
            missNeedFire.Add(0);
        }
        Debug.Log(missFire.Count);
        Debug.Log(missNeedFire.Count);
        game = 1;
        
        fireTime = 5f;
        needFireTime = 6f;
    }

    // Update is called once per frame
    void Update()
    {

        playTime += Time.deltaTime;
        fireTime += Time.deltaTime;
        needFireTime += Time.deltaTime;

        if (game == 1)
        {
            if ( playTime < 30 )
            {
                if (fireTime > 8)
                {
                    createFire();
                    
                    fireTime = 0;
                }

                if (needFireTime > 7)
                {
                    createNeedFire();
                    needFireTime = 0;
                }
            }

            
        }
        else if (game == 0) { 
        
        }
        
        
    }

    public void createNeedFire()
    {
        //int maxAttempts = 10; // 최대 시도 횟수 설정 -> 스텍 오브플로우 발생시 활성화시키고 else문 주석처리

        //for ( int i = 0; i<maxAttempts; i++ ) { 
        int range = Random.Range(0, needFirePos.Count);
        if (needFirePos[range].activeSelf == false)
        {
            //Debug.Log("if문 활성화");
            needFirePosition = needFirePos[range].transform.position;
            needFirePos[range].SetActive(true);
            missNeedFire[range] = 1;

            //Debug.Log(range);
            needFire.transform.position = needFirePosition;
            GameObject needFirepos = Instantiate(needFire, needFirePosition, Quaternion.identity); // 버튼 누를 때 마다 Clone 생성은 잘 되는데 왜 불은 안보일까??..ㅎㅎ 이거 해결해야됨 -> canvas안에 안있어서 안보였던거임
            //firepos.transform.SetParent(FireParent.transform); -> 이거는 왜 이렇게 바꼈던거야?..
            needFirepos.transform.SetParent(canvas.transform);

            StartCoroutine(DestroyNeedFirePosAfterDelay(needFirepos, 5.0f, range));

            return; // 함수 종료
        }
        else
        {
            //Debug.Log("if문 비활성화");
            createNeedFire();
        }
        //}

    }

    private IEnumerator DestroyNeedFirePosAfterDelay(GameObject needfirepos, float delay, int range)
    {
        checkNeedFireRange = range; // 스테틱 변수에 range값 할당
        yield return new WaitForSeconds(delay);

        if (missNeedFire[range] == 1)
        {
            Debug.Log("miss 변수가 1임으로 라이프를 깍습니다.");
            //ArrayManager.life -= 1;
            LifeDown();
        }
        // 지연 후에 firepos를 제거
        Destroy(needfirepos);

        // firePos[range]를 비활성화
        needFirePos[range].SetActive(false);
        //Debug.Log("firePos[" + range + "] " + "비활성화 완료");
    }

   

    public void createFire()
    {
        //int maxAttempts = 10; // 최대 시도 횟수 설정 -> 스텍 오브플로우 발생시 활성화시키고 else문 주석처리

        //for ( int i = 0; i<maxAttempts; i++ ) { 
        int range = Random.Range(0, firePos.Count);
        if (firePos[range].activeSelf == false)
        {
            //Debug.Log("if문 활성화");
            firePosition = firePos[range].transform.position;
            firePos[range].SetActive(true);
            missFire[range] = 1;

            //Debug.Log(range);
            fire.transform.position = firePosition;
            GameObject firepos = Instantiate(fire, firePosition, Quaternion.identity); // 버튼 누를 때 마다 Clone 생성은 잘 되는데 왜 불은 안보일까??..ㅎㅎ 이거 해결해야됨 -> canvas안에 안있어서 안보였던거임
            //firepos.transform.SetParent(FireParent.transform); -> 이거는 왜 이렇게 바꼈던거야?..
            firepos.transform.SetParent(canvas.transform);

            StartCoroutine(DestroyFirePosAfterDelay(firepos, 6.0f, range));

            return; // 함수 종료
        }
        else
        {
            //Debug.Log("if문 비활성화");
            createFire();
        }
        //}

    }

    private IEnumerator DestroyFirePosAfterDelay(GameObject firepos, float delay, int range)
    {
        checkFireRange = range; // 스테틱 변수에 range값 할당
        yield return new WaitForSeconds(delay);

        if (missFire[range] == 1)
        {
            Debug.Log("miss 변수가 1임으로 라이프를 깍습니다.");
            //ArrayManager.life -= 1;
            LifeDown();
        }
        // 지연 후에 firepos를 제거
        Destroy(firepos);

        // firePos[range]를 비활성화
        firePos[range].SetActive(false);
        //Debug.Log("firePos[" + range + "] " + "비활성화 완료");
    }

    // 목숨 -1 시 색상 변경
    public void LifeDown()
    {
        ArrayManager.life -= 1;
        if (ArrayManager.life > 0)
        {

            //색상변경
            UILife[ArrayManager.life].color = new Color(1, 0, 0, 0.4f); 
            Debug.Log(ArrayManager.life);
        }
        else
        {
            //색상변경
            UILife[0].color = new Color(1, 0, 0, 0.4f);

            //게임오버
            // 게임오버 후 클론 생성 멈춰야함!!
            // 씬 바꾸는 방식으로 해야하나...?
            game = 0;
            GameOver.SetActive(true);
            ScoreResult.text = "Score: " + point.ToString();

            //LifeUp(); // 테스트 해야되서 비활성화 시킴
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
        ArrayManager.life = 3;
        LifeUp();
        GameOver.SetActive(false);
        
        game = 1;
        point = 0;
        SetText();
    }

    // exit 버튼 클릭 시

}
