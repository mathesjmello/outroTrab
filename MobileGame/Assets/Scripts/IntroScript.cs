using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("ExitIntro", 4);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ExitIntro(){
		MyLoading.Loading ("Menu");
	}
}
