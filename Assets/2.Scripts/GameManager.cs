using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    static public bool isScene0 = false; //0이 true가 되면 SCENE1이 켜지고 SCENE1 완료하면 isScene1 true
    static public bool isScene1 = false;
    static public bool isScene2 = false;
    static public bool isScene3 = false;
    static public bool isScene4 = false;
    static public bool isScene5 = false;
    static public bool isScene6 = false;
    static public bool isScene7 = false;
    static public bool isScene8 = false;

    public bool isFinish = false;

    public GameObject Scene0;
    public GameObject Scene1;
    public GameObject Scene2;
    public GameObject Scene3;
    public GameObject Scene4;
    public GameObject Scene5;
    public GameObject Scene6;
    public GameObject Scene7;
    public GameObject Scene8;

    public enum State
    {
        SCENE0,
        SCENE1,
        SCENE2,
        SCENE3,
        SCENE4,
        SCENE5,
        SCENE6,
        SCENE7,
        SCENE8
    }

    public State state = State.SCENE0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CheckSceneState()); // while(1) : only 상태
        StartCoroutine(SceneAction());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator CheckSceneState()
    {
        while (!isFinish)
        {
            yield return new WaitForSeconds(0.3f); // 0.3초 후 while문 빠져나간다는 뜻


            if (isScene0)
            {
                state = State.SCENE1;
                Scene0.SetActive(false);
                Scene1.SetActive(true);
            }
            else if (isScene1)
            {
                state = State.SCENE2;
                Scene1.SetActive(false);
                Scene2.SetActive(true);
            }
            else if (isScene2)
            {
                state = State.SCENE3;
                Scene2.SetActive(false);
                Scene3.SetActive(true);
            }
            else if (isScene3)
            {
                state = State.SCENE4;
                Scene3.SetActive(false);
                Scene4.SetActive(true);
            }
            else if (isScene4)
            {
                state = State.SCENE5;
                Scene4.SetActive(false);
                Scene5.SetActive(true);
            }
            else if (isScene5)
            {
                state = State.SCENE6;
                Scene5.SetActive(false);
                Scene6.SetActive(true);
            }
            else if (isScene6)
            {
                state = State.SCENE7;
                Scene6.SetActive(false);
                Scene7.SetActive(true);
            }
            else if (isScene7)
            {
                state = State.SCENE8;
                Scene7.SetActive(false);
                Scene8.SetActive(true);
            }
            else if (isScene8)
            {
                isFinish = true;//모든 실험 끝남
            }
        }
    }

    IEnumerator SceneAction()
    {
        while (!isFinish)
        {
            yield return new WaitForSeconds(0.3f); // 0.3초 후 while문 빠져나간다는 뜻

            switch (state)
            {
                case State.SCENE0:
                    Scene0Ctrl.touchYFlask();
                    break;
                case State.SCENE1:
                    Scene1Ctrl.touchWATERMANGANIZ();
                    break;
                case State.SCENE2:
                    Scene2Ctrl.touchgum_cover();
                    break;
                case State.SCENE3:
                    Scene3Ctrl.touchYFlask();
                    break;
                case State.SCENE4:
                    Scene4Ctrl.touchGWASANHWA();
                    break;
                case State.SCENE5:
                    Scene5Ctrl.touchpinch();
                    break;
                case State.SCENE6:
                    Scene6Ctrl.touchvial();
                    break;
                case State.SCENE7:
                    Scene7Ctrl.touchglass_plate();
                    break;
                case State.SCENE8:
                    Scene8Ctrl.touchvial();
                    break;

            }
        }
    }
}
