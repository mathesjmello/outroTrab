
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Drag : MonoBehaviour {
	public GameObject dedoobjectPrefab;
	public GameObject Personagem;
	public GameObject tutorial;
	public Vector2 vel;
	public float divizor;
	public bool invert;
	public float grav;
	GameObject[] dedoobject;
	// Use this for initialization
	void Start ()
	{
		Personagem.GetComponent<Rigidbody2D>().velocity = vel;
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Personagem.GetComponent<Rigidbody2D>().gravityScale = grav;
		if (Input.GetButtonDown("Fire1"))
		{
			
			tutorial.SetActive(false);
			grav=grav*-1;
		}
		if (invert) {
			vel=new Vector2(-2,Personagem.GetComponent<Rigidbody2D>().gravityScale/divizor);
			Personagem.GetComponent<Rigidbody2D> ().velocity=vel;
			return;
		}
		if (Personagem.GetComponent<Rigidbody2D> ().velocity.x < 0.5f) {
			Personagem.GetComponent<Rigidbody2D> ().velocity = vel;
		} 
	}
}
