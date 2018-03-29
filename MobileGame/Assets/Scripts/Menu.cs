using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {
	public GameObject alert;

	void Start(){
		Persistence.LoadData();
	}
	public void Sair(){

		Application.Quit ();
	}

	public void Play(){

		MyLoading.Loading ("LevelSelect");
	}
	public void MenuBack(){

		MyLoading.Loading ("Menu");
	}

	void  Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			alert.SetActive (true);

		}

	}

	public void ResetData()
	{
		Persistence.levelstatus= new int[]{1,0,0,0,0,0,0,0};
		PlayerPrefsX.SetIntArray ("LevelStatus", Persistence.levelstatus);
		MyLoading.Loading("LevelSelect");
	}
}
