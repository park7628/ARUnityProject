using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
//using System.Diagnostics;

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
    public GameObject fireParent;
    public GameObject needFireParent;

    public GameObject firepos1;
    public static List<int> checkFireRange = new List<int>{ };
    public static List <int> checkNeedFireRange = new List<int> { };
    public static List<int> missFire = new List<int> { }; // �Ҳ��� ������ �� ������ ��� ����
    public static List<int> missNeedFire = new List<int> { };
    GameObject RemoveSlotMgr;


    
    float playTime;
    float fireTime;
    float needFireTime;
    public int num = 0;
    public Vector3 firePosition;
    public Vector3 needFirePosition;
    public int score;
    public int game; // ���� ���� ����
    static public bool pauseIs; // �Ͻ����� ����
    static public int pauseCheck;
    public List<GameObject> firePos = new List<GameObject> { }; //�Ҳ� ���� ��ġ
    public List<GameObject> needFirePos = new List<GameObject> { }; //�Ķ����� ���� ��ġ

    // ����, ���
    public Image[] UILife;
    public Text UIScore;
    public Text ScoreResult;
    public GameObject GameOver;
    int point = 0;

    // �ڷ�ƾ ����
    IEnumerator fireCoroutine1;
    IEnumerator fireCoroutine2;
    IEnumerator fireCoroutine3;
    IEnumerator fireCoroutine4;
    IEnumerator fireCoroutine5;
    IEnumerator fireCoroutine6;
    IEnumerator fireCoroutine7;

    IEnumerator needFireCoroutine1;
    IEnumerator needFireCoroutine2;
    IEnumerator needFireCoroutine3;
    IEnumerator needFireCoroutine4;
    IEnumerator needFireCoroutine5;
    IEnumerator needFireCoroutine6;

    List<IEnumerator> fireEnumerators = new List<IEnumerator>();
    List<IEnumerator> needFireEnumerators = new List<IEnumerator>();
    // Start is called before the first frame update
    void Start()
    {
        RemoveSlotMgr = GameObject.Find("RemoveSlotMgr");

        fireEnumerators.Add(fireCoroutine1);
        fireEnumerators.Add(fireCoroutine2);
        fireEnumerators.Add(fireCoroutine3);
        fireEnumerators.Add(fireCoroutine4);
        fireEnumerators.Add(fireCoroutine5);
        fireEnumerators.Add(fireCoroutine6);
        fireEnumerators.Add(fireCoroutine7);

        needFireEnumerators.Add(needFireCoroutine1);
        needFireEnumerators.Add(needFireCoroutine2);
        needFireEnumerators.Add(needFireCoroutine3);
        needFireEnumerators.Add(needFireCoroutine4);
        needFireEnumerators.Add(needFireCoroutine5);
        needFireEnumerators.Add(needFireCoroutine6);

        pauseIs = false;
        pauseCheck = 1;

        for ( int i = 0; i < firePos.Count; i++ )
        {
            
            missFire.Add(0);
            //checkFireRange.Add(0);
        }
        for (int i = 0; i < needFirePos.Count; i++)
        {
            missNeedFire.Add(0);
            //checkNeedFireRange.Add(0);
        }
        //Debug.Log(missFire.Count);
        //Debug.Log(missNeedFire.Count);
        game = 1;
        
        fireTime = 5f;
        needFireTime = 6f;
        playTime = 0;
    }

    // Update is called once per frame
    void Update()
    {


        if (pauseIs == false)
        {
            if(pauseCheck == 0)
            {
                for (int i = 0; i < needFireEnumerators.Count; i++)
                {
                    if (needFireEnumerators[i] != null)
                    {
                        Debug.Log(needFireEnumerators[i].ToString());
                        StartCoroutine(needFireEnumerators[i]);
                    }
                }

                for (int i = 0; i < fireEnumerators.Count; i++)
                {
                    if (fireEnumerators[i] != null)
                    {
                        StartCoroutine(fireEnumerators[i]);
                    }
                }
            }
            pauseCheck = 1;
            
            playTime += Time.deltaTime;
            fireTime += Time.deltaTime;
            needFireTime += Time.deltaTime;

            if (game == 1)
            {
                if (playTime < 30)
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
                else if (playTime >= 30 && playTime < 60)
                {
                    if (fireTime > 6)
                    {
                        createFire();

                        fireTime = 0;
                    }

                    if (needFireTime > 5)
                    {
                        createNeedFire();
                        needFireTime = 0;
                    }
                }
                else if (playTime >= 60)
                {
                    if (fireTime > 4)
                    {
                        createFire();

                        fireTime = 0;
                    }

                    if (needFireTime > 3)
                    {
                        createNeedFire();
                        needFireTime = 0;
                    }
                }


            }
            else if (game == 0)
            {

            }
        }

        else if(pauseIs == true)
        {
            pauseCheck = 0;
            for (int i = 0; i < needFireEnumerators.Count; i++)
            {
                if (needFireEnumerators[i] != null)
                {
                    StopCoroutine(needFireEnumerators[i]);
                }
            }

            for (int i = 0; i < fireEnumerators.Count; i++)
            {
                if (fireEnumerators[i] != null)
                {
                    StopCoroutine(fireEnumerators[i]);
                }
            }
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
            needFirepos.transform.SetParent(needFireParent.transform); // �̰Ŵ� �� �̷��� �ٲ����ž�?..
            //needFirepos.transform.SetParent(canvas.transform);

            

            if(playTime < 30)
            {
                needFireEnumerators[range] = DestroyNeedFirePosAfterDelay(needFirepos, 7.0f, range);
                StartCoroutine(needFireEnumerators[range]);
                //StartCoroutine(DestroyNeedFirePosAfterDelay(needFirepos, 7.0f, range));
            }
            else if(playTime < 60 && playTime >= 30)
            {
                needFireEnumerators[range] = DestroyNeedFirePosAfterDelay(needFirepos, 6.0f, range);
                //StartCoroutine(DestroyNeedFirePosAfterDelay(needFirepos, 6.0f, range));
                StartCoroutine(needFireEnumerators[range]);
            }
            else if (playTime >= 60)
            {
                needFireEnumerators[range] = DestroyNeedFirePosAfterDelay(needFirepos, 6.0f, range);
                //StartCoroutine(DestroyNeedFirePosAfterDelay(needFirepos, 6.0f, range));
                StartCoroutine(needFireEnumerators[range]);
            }

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
        checkNeedFireRange.Add(range); // ����ƽ ������ range��
        

        for (int i =0; i < checkNeedFireRange.Count; i++)
        {
            Debug.Log("checkNeedFIreRange :" + checkNeedFireRange[i]);
        }
        
        yield return new WaitForSeconds(delay);
        //Debug.Log("checkNeedFIreRange :" + checkNeedFireRange);

        if (missNeedFire[range] == 1)
        {
            //Debug.Log("miss ������ 1������ �������� ����ϴ�.");
            //ArrayManager.life -= 1;
            LifeDown();
        }
        // ���� �Ŀ� firepos�� ����
        Destroy(needfirepos);
        RemoveSlotMgr.GetComponent<SlotManager3>().RemoveSlot();
        RemoveSlotMgr.GetComponent<SlotManager4>().RemoveSlot();

        // firePos[range]�� ��Ȱ��ȭ
        needFirePos[range].SetActive(false);
        needFireEnumerators[range] = null;
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
            firepos.transform.SetParent(fireParent.transform);// -> �̰Ŵ� �� �̷��� �ٲ����ž�?..
            //firepos.transform.SetParent(canvas.transform);


            

            if (playTime < 30)
            {
                fireEnumerators[range] = DestroyFirePosAfterDelay(firepos, 8.0f, range);
                StartCoroutine(fireEnumerators[range]);
                //StartCoroutine(DestroyFirePosAfterDelay(firepos, 8.0f, range));
            }
            else if (playTime < 60 && playTime >= 30)
            {
                fireEnumerators[range] = DestroyFirePosAfterDelay(firepos, 7.0f, range);
                StartCoroutine(fireEnumerators[range]);
                //StartCoroutine(DestroyFirePosAfterDelay(firepos, 7.0f, range));
            }
            else if (playTime >= 60)
            {
                fireEnumerators[range] = DestroyFirePosAfterDelay(firepos, 6.0f, range);
                StartCoroutine(fireEnumerators[range]);
                //StartCoroutine(DestroyFirePosAfterDelay(firepos, 6.0f, range));
            }


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
        checkFireRange.Add(range); // ����ƽ ������ range�� �Ҵ�
        //Debug.Log("checkFIreRange :" + checkFireRange);
        
        yield return new WaitForSeconds(delay);
        //Debug.Log("checkFIreRange :" + checkFireRange);

        if (missFire[range] == 1)
        {
            //Debug.Log("miss ������ 1������ �������� ����ϴ�.");
            //ArrayManager.life -= 1;
            LifeDown();
        }
        // ���� �Ŀ� firepos�� ����
        Destroy(firepos);
        RemoveSlotMgr.GetComponent<SlotManager1>().RemoveSlot();
        RemoveSlotMgr.GetComponent<SlotManager2>().RemoveSlot();

        // firePos[range]�� ��Ȱ��ȭ
        firePos[range].SetActive(false);
        fireEnumerators[range] = null;
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

            // ��� ���� ȿ����
            AudioSource LifeDownAudio = UILife[ArrayManager.life].GetComponent<AudioSource>();
            LifeDownAudio.Play();

            Debug.Log(ArrayManager.life);
        }
        else
        {
            //���󺯰�
            UILife[0].color = new Color(1, 0, 0, 0.4f);

            AudioSource LifeDownAudio = UILife[0].GetComponent<AudioSource>();
            LifeDownAudio.Play();

            //���ӿ���
            // ���ӿ��� �� Ŭ�� ���� �������!!
            // �� �ٲٴ� ������� �ؾ��ϳ�...?
            game = 0;
            StopAllCoroutines(); // ��� �ڷ�ƾ ���� ���࿡ �ȵǸ� �θ� ��Ȱ��ȭ ��Ű��
            
            GameOver.SetActive(true);
            needFireParent.SetActive(false);
            fireParent.SetActive(false);
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

    public void pauseButton()
    {
        pauseIs = true;
    }

    public void replayButton()
    {
        pauseIs = false;
    }

    // retry ��ư Ŭ�� ��
    public void RetryOnClick()
    {
        ArrayManager.life = 3;
        LifeUp();


        needFireParent.SetActive(true);
        fireParent.SetActive(true);
        GameOver.SetActive(false);

        fireTime = 5f;
        needFireTime = 6f;
        playTime = 0;

        game = 1;
        point = 0;
        SetText();
    }

    // exit ��ư Ŭ�� ��

}
