using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;
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
    public GameObject canvas;
    public GameObject FireParent;

    public GameObject firepos1;
    public static int checkFireRange;
    public static List<int> missFire = new List<int> { }; // �Ҳ��� ������ �� ������ ��� ���� ����

    float playTime;
    public int num = 0;
    public Vector3 firePosition;
    public int score;
    public int game; // ���� ���� ����
    public List<GameObject> firePos = new List<GameObject> { };

    // ����, ���
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
        Debug.Log(missFire.Count);
        game = 1;
        
    }

    // Update is called once per frame
    void Update()
    {

        playTime += Time.deltaTime;

        if (game == 1)
        {
            if (score < 10 && score >= 0)
            {
                if (playTime > 5)
                {
                    createFire();
                    playTime = 0;
                }


            }
        }
        else if (game == 0) { 
        
        }
        
        
    }

    public void createFire()
    {

        int range = Random.Range(0, firePos.Count);
        if (firePos[range].activeSelf == false)
        {
            //Debug.Log("if�� Ȱ��ȭ");
            firePosition = firePos[range].transform.position;
            firePos[range].SetActive(true);
            missFire[range] = 1;

            //Debug.Log(range);
            fire.transform.position = firePosition;
            GameObject firepos = Instantiate(fire, firePosition, Quaternion.identity); // ��ư ���� �� ���� Clone ������ �� �Ǵµ� �� ���� �Ⱥ��ϱ�??..���� �̰� �ذ��ؾߵ� -> canvas�ȿ� ���־ �Ⱥ���������
            firepos.transform.SetParent(FireParent.transform);

            //List<float> checkTime = new List<float>();
            //checkTime.Add(Time.deltaTime);
            //Destroy(firepos, 4.0f);
            
            StartCoroutine(DestroyFirePosAfterDelay(firepos, 6.0f, range));
            //if (checkTime[num] > 4)
            //{
            //    Debug.Log(checkTime[range]);
            //    firePos[range].SetActive(false);

            //    Debug.Log("��Ȱ��ȭ �Ϸ�");

            //}
            //num++;
        }
        else
        {
            //Debug.Log("if�� ��Ȱ��ȭ");
            createFire();
        }

    }

    private IEnumerator DestroyFirePosAfterDelay(GameObject firepos, float delay, int range)
    {
        checkFireRange = range; // ����ƽ ������ range�� �Ҵ�
        yield return new WaitForSeconds(delay);

        if (missFire[range] == 1)
        {
            Debug.Log("miss ������ 1������ �������� ����ϴ�.");
            //ArrayManager.life -= 1;
            LifeDown();
        }
        // ���� �Ŀ� firepos�� ����
        Destroy(firepos);

        // firePos[range]�� ��Ȱ��ȭ
        firePos[range].SetActive(false);
        //Debug.Log("firePos[" + range + "] " + "��Ȱ��ȭ �Ϸ�");
    }



    // ��� -1 �� ���� ����
    public void LifeDown()
    {
        ArrayManager.life -= 1;
        if (ArrayManager.life > 0)
        {

            //���󺯰�
            UILife[ArrayManager.life].color = new Color(1, 0, 0, 0.4f); 
            Debug.Log(ArrayManager.life);
        }
        else
        {
            //���󺯰�
            UILife[0].color = new Color(1, 0, 0, 0.4f);

            //���ӿ���
            // ���ӿ��� �� Ŭ�� ���� �������!!
            // �� �ٲٴ� ������� �ؾ��ϳ�...?
            game = 0;
            GameOver.SetActive(true);
            ScoreResult.text = "Score: " + point.ToString();

            //LifeUp(); // �׽�Ʈ �ؾߵǼ� ��Ȱ��ȭ ��Ŵ
        }
    }

    // Retry�� ��� �� �������
    public void LifeUp()
    {
        for (int i = 0; i < 3; i++)
        {
            UILife[i].color = new Color(1, 0, 0, 1);
        }

    }

    // ���� +10
    public void GetScore()
    {
        point += 10;
        SetText();
    }

    public void SetText()
    {
        UIScore.text = point.ToString();
    }


    // retry ��ư Ŭ�� ��
    public void RetryOnClick()
    {
        ArrayManager.life = 3;
        LifeUp();
        GameOver.SetActive(false);
        
        game = 1;
        point = 0;
        SetText();
    }

    // exit ��ư Ŭ�� ��

}
