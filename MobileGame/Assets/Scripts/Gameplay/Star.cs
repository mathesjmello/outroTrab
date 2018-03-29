using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour {

	public GameObject Control;
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag.Equals("Player"))
		{
			Control.GetComponent<Drag> ().invert=true;
		}
	}
}

