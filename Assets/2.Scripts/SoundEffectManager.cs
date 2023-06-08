using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundEffectManager : MonoBehaviour
{
    //[SerializeField] Slider effectSlider;

    [SerializeField] Slider EffectSlider;
    [SerializeField] AudioSource sound;
    [SerializeField] GameObject scene1_Beaker;
    public GameObject scene1_Spatula;
    public GameObject scene4_Beaker;
    public GameObject scene5_Oxygen;
    public GameObject scene6_Vial;
    public GameObject scene6_Oxygen;
    public GameObject scene7_Vial;
    public GameObject scene7_Oxygen;
    public GameObject scene8_Oxygen;
    public GameObject scene8_Vial;
    public GameObject scene8_WatchGlass;
    // Start is called before the first frame update
    void Start()
    {
        //sound.volume = 1;
    }

    // Update is called once per frame
    void Update()
    {
        sound.volume = EffectSlider.value;
        scene1_Beaker.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene1_Spatula.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene4_Beaker.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene5_Oxygen.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene6_Vial.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene6_Oxygen.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene7_Vial.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene7_Oxygen.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene8_WatchGlass.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene8_Oxygen.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene8_Vial.GetComponent<AudioSource>().volume = EffectSlider.value;
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
        sound.volume = EffectSlider.value;
        scene1_Beaker.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene1_Spatula.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene4_Beaker.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene5_Oxygen.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene6_Vial.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene6_Oxygen.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene7_Vial.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene7_Oxygen.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene8_WatchGlass.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene8_Oxygen.GetComponent<AudioSource>().volume = EffectSlider.value;
        scene8_Vial.GetComponent<AudioSource>().volume = EffectSlider.value;
        //Save();
    }

    private void Load()
    {
        sound.volume = PlayerPrefs.GetFloat("Volume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("Volume", EffectSlider.value);
    }
}
