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

    // ���� �ٽ� �ε��ϴ� �Լ�
    public void ReloadScene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}