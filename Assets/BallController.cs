using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
	Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxisRaw ("Horizontal");
		rigidbody.AddForce (Vector3.right * 10*x, ForceMode.Force);

		float z = Input.GetAxisRaw ("Vertical");
		rigidbody.AddForce (Vector3.forward * 10*z, ForceMode.Force);
	}
}
