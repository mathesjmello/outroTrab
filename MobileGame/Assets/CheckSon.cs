using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSon : MonoBehaviour
{

	public AudioSource Musica;
	public AudioSource SFX;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetFloat("MVolume") <= 0)
		{
			Musica.Stop();
		}
		if (PlayerPrefs.GetFloat("SFXVolume") <= 0)
		{
			SFX.gameObject.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
