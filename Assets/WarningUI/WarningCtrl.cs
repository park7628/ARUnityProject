using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarningCtrl : MonoBehaviour
{
    public GameObject WarningPanel;
    public Button button;


    public void WarnButtonClick()
    {
        button.interactable = true;
        WarningPanel.SetActive(false);
    }

    [System.Serializable]
    public class DataProperyt
    { 
        public string description;
    }

    public Button previousPageButton, nextPageButton;
    public Text GuideTxt;

    public List<DataProperyt> ButtonData;

    int currentPage;

    // Start is called before the first frame update

    void Start()
    {
        
        UpdateUI();
    }

    void UpdateUI()
    {
        previousPageButton.interactable = currentPage > 0;
        nextPageButton.interactable = currentPage < ButtonData.Count - 1;

        previousPageButton.gameObject.SetActive(currentPage > 0);
        nextPageButton.gameObject.SetActive(currentPage < ButtonData.Count - 1);


        UpdataContent();
    }

    void UpdataContent()
    {

        if (currentPage >= 0 && currentPage < ButtonData.Count)
        {
            string description = ButtonData[currentPage].description;
            GuideTxt.text = description;
        }

    }

    public void OnClickPrevButton()
    {
        currentPage--;
        UpdateUI();
    }

    public void OnClickNextButton()
    {
        currentPage++;
        UpdateUI();
    }



}
