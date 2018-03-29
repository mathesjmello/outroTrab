
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Drag : MonoBehaviour {
	public GameObject dedoobjectPrefab;
	

	void Update ()
	{
		
		#if UNITY_EDITOR
		if (Input.GetMouseButtonUp(0))
		{
			dedoobjectPrefab.transform.DetachChildren();
		}
		dedoobjectPrefab.transform.position = Vector3.right * 100;		
		if (Input.GetMouseButton(0))
			dedoobjectPrefab.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + Vector3.forward+ new Vector3(0,0,9);
		#endif
		
		#if UNITY_ANDROID
		if(Input.touchCount!=1)
			dedoobjectPrefab.transform.DetachChildren();
		dedoobjectPrefab.transform.position= Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position) + Vector3.forward+ new Vector3(0,0,9);
		#endif
	}
}
