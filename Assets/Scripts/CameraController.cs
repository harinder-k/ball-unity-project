using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	const float Y_ANGLE_MIN = 0.0f;
	const float Y_ANGLE_MAX = 50.0f;

	public GameObject player;
	float cameraDistance = 10.0f;
	float positionX = 0.0f;
	float positionY = 0.0f;
	float rotationSpeed = 4.0f;

	// Use this for initialization
	void Start () {
	}

	void Update () {
		positionX += Input.GetAxis ("Mouse X") * rotationSpeed;
		positionY += Input.GetAxis ("Mouse Y") * rotationSpeed;
		positionY = Mathf.Clamp (positionY, Y_ANGLE_MIN, Y_ANGLE_MAX);
	}

	void LateUpdate () {
		Vector3 dir = new Vector3 (0, 0, -cameraDistance);
		Quaternion rotation = Quaternion.Euler (positionY, positionX, 0.0f);
		transform.position = player.transform.position + rotation * dir;
		transform.LookAt (player.transform);
	}
}
