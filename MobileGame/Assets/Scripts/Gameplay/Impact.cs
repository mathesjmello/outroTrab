using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour {

	Vector3 deltapos;
	Vector3 oldpos;
	// Update is called once per frame
	void FixedUpdate () {
		deltapos = transform.position - oldpos;
		oldpos = transform.position;
	}
	void OnCollisionEnter2D(Collision2D col){
		
		if(col.rigidbody)
			
			col.rigidbody.AddForce(deltapos*10,ForceMode2D.Impulse);

		deltapos = Vector3.zero;
	}
}
