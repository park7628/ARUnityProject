using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{


    public GameManager GameManager;

    // 씬을 다시 로드하는 함수
    public void ReloadScene()
    {
        GameManager.isScene0 = false; //0이 true가 되면 SCENE1이 켜지고 SCENE1 완료하면 isScene1 true
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