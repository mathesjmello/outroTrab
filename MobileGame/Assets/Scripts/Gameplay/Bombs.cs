using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombs : MonoBehaviour
{
	public string ThisLevel;
	public AudioSource SFX;
	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag.Equals("Player"))
		{
			SFX.Play();
			other.gameObject.SetActive(false);
			Invoke("Carrega",2);
			
		}
	}

	void Carrega()
	{
		
		MyLoading.Reset(ThisLevel);
		
	}
}
