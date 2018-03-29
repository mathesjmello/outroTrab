using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
	public int levelindex;
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag.Equals ("Player")) {
			Persistence.levelstatus [levelindex-1] = 1;
			Persistence.SaveData();
			MyLoading.Loading ("LevelSelect");
		}
	}
}
