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
		float speedx = Input.GetAxisRaw ("Horizontal");
		float speedz = Input.GetAxisRaw ("Vertical");

		rigidbody.AddForce (Vector3.forward*speedz, ForceMode.Force);
		rigidbody.AddForce (Vector3.right*speedx, ForceMode.Force);
	}
}
