using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

	private float normalTime;

	public void PauseGame()
	{
		normalTime = Time.timeScale;
		Time.timeScale = 0f;
	}

	public void ResumeGame()
	{

		Time.timeScale = normalTime;
	}

	public void BackMenu()
	{
		Time.timeScale = normalTime;
		MyLoading.Loading("LevelSelect");
	}

	public void RestartLvl(string nomefaze)
	{
		Time.timeScale = normalTime;
		MyLoading.Loading(nomefaze);	
	}

}
