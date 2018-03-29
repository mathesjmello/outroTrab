
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Drag : MonoBehaviour {
	public GameObject dedoobjectPrefab;
	private GameObject[] dedoObjects;
	private int tocando;

	private void Start()
	{
		dedoObjects= new GameObject[5];
		dedoObjects[0] = (GameObject) Instantiate(dedoobjectPrefab);
		dedoObjects[1] = (GameObject) Instantiate(dedoobjectPrefab);
		dedoObjects[2] = (GameObject) Instantiate(dedoobjectPrefab);
		dedoObjects[3] = (GameObject) Instantiate(dedoobjectPrefab);
		dedoObjects[4] = (GameObject) Instantiate(dedoobjectPrefab);
	}

	void Update ()
	{
		for (int i = 0; i < dedoObjects.Length; i++)
		{
			dedoObjects[i].transform.position= Vector3.right*100;
		}
		
	#if UNITY_EDITOR
		if (Input.GetMouseButton(0))
		
		dedoObjects[0].transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition)+Vector3.forward;		
	#endif
		for (int i = 0; i < Input.touches.Length; i++)
		{
			dedoObjects[i].transform.position = Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position) + Vector3.forward;
		}
		
		
	}
}
