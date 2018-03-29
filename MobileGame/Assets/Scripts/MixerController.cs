using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class MixerController : MonoBehaviour {
	public AudioMixer mixer;
	public Slider slider;
	public Slider SliderSFx;
	public void  MasterVolume(float vol)
	{
		mixer.SetFloat ("MVolume", vol);
		PlayerPrefs.SetFloat ("MVolume", vol);
	}
	public void  SFxVolume(float vol)
	{
		mixer.SetFloat ("SFXVolume", vol);
		PlayerPrefs.SetFloat ("SFXVolume", vol);
	}
	// Use this for initialization
	void Start ()
	{

		SliderSFx.value = 1;
		slider.value = 1;
		PlayerPrefs.SetFloat("SFXVolume", SliderSFx.value);
		PlayerPrefs.SetFloat("MVolume", slider.value);
	}

	public void SaveSound()
	{
		PlayerPrefs.SetFloat("SFXVolume", SliderSFx.value);
		PlayerPrefs.SetFloat("MVolume", slider.value);
	}

}
