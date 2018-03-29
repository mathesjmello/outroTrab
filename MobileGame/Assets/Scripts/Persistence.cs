using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Persistence {
	public static string nextLevel;
	public static float musicvolume;
	public static float sfxvolume;
	public static int[] levelstatus={1,0,0,0,0,0,0,0};

	public static void SaveData(){
		PlayerPrefs.SetFloat ("MVolume", musicvolume);
		PlayerPrefs.SetFloat ("SFXVolume", sfxvolume);
		PlayerPrefsX.SetIntArray ("LevelStatus", levelstatus);
	}

	public static void LoadData(){
		
		musicvolume=PlayerPrefs.GetFloat("MVolume");
		sfxvolume=PlayerPrefs.GetFloat("SFXVolume");
		
		var temp = PlayerPrefsX.GetIntArray ("LevelStatus");
		if (temp.Length == levelstatus.Length)
			levelstatus = temp;

	}
}

