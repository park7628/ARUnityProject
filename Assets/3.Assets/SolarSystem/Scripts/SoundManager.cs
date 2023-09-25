using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public AudioClip hoverEffectSound;

	private bool hoverEffectSoundAlreadyPlayed;
	private AudioSource _audioSource;

	public static SoundManager instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

	public void Start()
	{
		_audioSource = this.gameObject.GetComponent<AudioSource>();
	}
	public void PlayHoverEffectSound(bool firstTime)
	{
		if(firstTime && !hoverEffectSoundAlreadyPlayed)
		{
			_audioSource.PlayOneShot(hoverEffectSound);
			hoverEffectSoundAlreadyPlayed = true;
		}
		else if(!firstTime)
		{
			// reset
			hoverEffectSoundAlreadyPlayed = false;
		}
	}
}
