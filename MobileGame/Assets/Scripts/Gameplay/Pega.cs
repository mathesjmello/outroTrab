using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pega : MonoBehaviour {
	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag.Equals("Player"))
		{
			other.gameObject.transform.parent = gameObject.transform;
			other.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
		}
	}

	private void OnCollisionExit2D(Collision2D other)
	{
		if (other.gameObject.tag.Equals("Player"))
		other.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
	}
}
