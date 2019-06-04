using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
//	const float SPEED_MIN = -1000.0f;
//	const float SPEED_MAX = 1000.0f;
//
//	public Transform relativeTransform;
//	public float speed = 10;
//	public Vector3 jumpMovement = new Vector3 (0,10,0);
//
//	private Rigidbody rb;
//	private bool onFloor = false;
//
//	// Use this for initialization
//	void Start() {
//		rb = GetComponent<Rigidbody> ();
//	}
//	
//	// Update is called once per frame
//	void Update() {
//
//	}
//
//	void FixedUpdate() {
//		Vector3 moveDirection = Vector3.zero;
//
//		if (Input.GetKey (KeyCode.W)) {
//			moveDirection += relativeTransform.forward;
//		}
//		if (Input.GetKey (KeyCode.S)) {
//			moveDirection -= relativeTransform.forward;
//		}
//		if (Input.GetKey (KeyCode.A)) {
//			moveDirection -= relativeTransform.right;
//		}
//		if (Input.GetKey (KeyCode.D)) {
//			moveDirection += relativeTransform.right;
//		}
//
//		moveDirection.y = 0.0f;
//
//		if (onFloor) {
//			rb.AddForce (moveDirection.normalized * speed);
//			rb.velocity = new Vector3 (Mathf.Clamp (rb.velocity.x, SPEED_MIN, SPEED_MAX), Mathf.Clamp (rb.velocity.y, SPEED_MIN, SPEED_MAX), Mathf.Clamp (rb.velocity.z, SPEED_MIN, SPEED_MAX));
//		}
//
//		if (Input.GetKeyDown("space") && onFloor) {
//			rb.AddForce (jumpMovement);
//		}
//		Debug.Log (onFloor);
//	}
//
//	void OnCollisionEnter (Collision other) {
//		onFloor = true;
//	}
//
//	void OnCollisionExit (Collision other) {
//		onFloor = false;
//	}
	public float speed = 10;

	Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
}
