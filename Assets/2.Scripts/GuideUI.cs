using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GuideUI : MonoBehaviour
{
    [System.Serializable]
    public class DataProperyt
    {
        public Sprite sprite;
        public string description;
    }

    public Button previousPageButton, nextPageButton;
    public Image freeViewImage;
    public TextMeshProUGUI GuideTxt;

    public List<DataProperyt> ButtonData;
    private Animator animator;

    int currentPage;
    // Start is called before the first frame update

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Close()
    {
        StartCoroutine(CloseAfterDelay());
    }

    private IEnumerator CloseAfterDelay()
    {
        animator.SetTrigger("close");
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
        animator.ResetTrigger("close");
    }
    void Start()
    {
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateUI()
    {
        previousPageButton.interactable = currentPage > 0;
        nextPageButton.interactable = currentPage < ButtonData.Count -1;

        UpdataContent();
    }

    void UpdataContent()
    {
        freeViewImage.sprite = ButtonData[currentPage].sprite;
            
        StopAllCoroutines();
        StartCoroutine(AppearTextOneByOne(0.1f));
    }

    IEnumerator AppearTextOneByOne(float interval)
    {
        int index = 1;
        string description = ButtonData[currentPage].description;

        while(index <= description.Length)
        {
            GuideTxt.text = description.Substring(0, index);
            yield return new WaitForSeconds(interval);
            index++;
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
