using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{


    public GameManager GameManager;

    // ���� �ٽ� �ε��ϴ� �Լ�
    public void ReloadScene()
    {
        GameManager.isScene0 = false; //0�� true�� �Ǹ� SCENE1�� ������ SCENE1 �Ϸ��ϸ� isScene1 true
        GameManager.isScene1 = false;
        GameManager.isScene2 = false;
        GameManager.isScene3 = false;
        GameManager.isScene4 = false;
        GameManager.isScene5 = false;
        GameManager.isScene6 = false;
        GameManager.isScene7 = false;
        GameManager.isScene8 = false;
        GameManager.state = GameManager.State.SCENE0;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}