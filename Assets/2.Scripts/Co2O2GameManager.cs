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
    public static int checkNeedFireRange;
    public static List<int> missFire = new List<int> { }; // �Ҳ��� ������ �� ������ ��� ����
    public static List<int> missNeedFire = new List<int> { };


    
    float playTime;
    float fireTime;
    float needFireTime;
    public int num = 0;
    public Vector3 firePosition;
    public Vector3 needFirePosition;
    public int score;
    public int game; // ���� ���� ����
    public List<GameObject> firePos = new List<GameObject> { }; //�Ҳ� ���� ��ġ
    public List<GameObject> needFirePos = new List<GameObject> { }; //�Ķ����� ���� ��ġ

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
        //int maxAttempts = 10; // �ִ� �õ� Ƚ�� ���� -> ���� �����÷ο� �߻��� Ȱ��ȭ��Ű�� else�� �ּ�ó��

        //for ( int i = 0; i<maxAttempts; i++ ) { 
        int range = Random.Range(0, needFirePos.Count);
        if (needFirePos[range].activeSelf == false)
        {
            //Debug.Log("if�� Ȱ��ȭ");
            needFirePosition = needFirePos[range].transform.position;
            needFirePos[range].SetActive(true);
            missNeedFire[range] = 1;

            //Debug.Log(range);
            needFire.transform.position = needFirePosition;
            GameObject needFirepos = Instantiate(needFire, needFirePosition, Quaternion.identity); // ��ư ���� �� ���� Clone ������ �� �Ǵµ� �� ���� �Ⱥ��ϱ�??..���� �̰� �ذ��ؾߵ� -> canvas�ȿ� ���־ �Ⱥ���������
            //firepos.transform.SetParent(FireParent.transform); -> �̰Ŵ� �� �̷��� �ٲ����ž�?..
            needFirepos.transform.SetParent(canvas.transform);

            StartCoroutine(DestroyNeedFirePosAfterDelay(needFirepos, 5.0f, range));

            return; // �Լ� ����
        }
        else
        {
            //Debug.Log("if�� ��Ȱ��ȭ");
            createNeedFire();
        }
        //}

    }

    private IEnumerator DestroyNeedFirePosAfterDelay(GameObject needfirepos, float delay, int range)
    {
        checkNeedFireRange = range; // ����ƽ ������ range�� �Ҵ�
        yield return new WaitForSeconds(delay);

        if (missNeedFire[range] == 1)
        {
            Debug.Log("miss ������ 1������ �������� ����ϴ�.");
            //ArrayManager.life -= 1;
            LifeDown();
        }
        // ���� �Ŀ� firepos�� ����
        Destroy(needfirepos);

        // firePos[range]�� ��Ȱ��ȭ
        needFirePos[range].SetActive(false);
        //Debug.Log("firePos[" + range + "] " + "��Ȱ��ȭ �Ϸ�");
    }

   

    public void createFire()
    {
        //int maxAttempts = 10; // �ִ� �õ� Ƚ�� ���� -> ���� �����÷ο� �߻��� Ȱ��ȭ��Ű�� else�� �ּ�ó��

        //for ( int i = 0; i<maxAttempts; i++ ) { 
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
            //firepos.transform.SetParent(FireParent.transform); -> �̰Ŵ� �� �̷��� �ٲ����ž�?..
            firepos.transform.SetParent(canvas.transform);

            StartCoroutine(DestroyFirePosAfterDelay(firepos, 6.0f, range));

            return; // �Լ� ����
        }
        else
        {
            //Debug.Log("if�� ��Ȱ��ȭ");
            createFire();
        }
        //}

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
