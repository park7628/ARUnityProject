using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{

    void Start()
    {

        BackManager.isback = false;

    }

    // 씬을 다시 로드하는 함수
    public void ReloadScene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}