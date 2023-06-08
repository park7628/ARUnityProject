using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{

    //[SerializeField] Slider effectSlider;
    [SerializeField] Slider volumeSlider;
    [SerializeField] AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        //sound.volume = 1;
    }

    // Update is called once per frame
    void Update()
    {
        sound.volume = volumeSlider.value;

        //if (!PlayerPrefs.HasKey("Volume"))
        //{
        //    PlayerPrefs.SetFloat("Volume", 1);
        //    Load();
        //}
        //else
        //{
        //    Load();
        //}
    }

    public void ChangedVolume()
    {
        sound.volume = volumeSlider.value;
        //Save();
    }

    private void Load()
    {
        sound.volume = PlayerPrefs.GetFloat("Volume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("Volume", volumeSlider.value);
    }
}
