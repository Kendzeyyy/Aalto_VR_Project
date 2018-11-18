using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour {

	Transform cmpTransform;
	Vector3 rotationVector = new Vector3(0f, 0.2f, 0f);

	// Hover
	public float verticalSpeed;
	public float amplitude;
	public Vector3 tempPosition;

	// Use this for initialization
	void Start () {
		cmpTransform = GetComponent<Transform>();

		// Hover
		//tempPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		cmpTransform.Rotate(rotationVector);

		// Hover
		//tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude;
		//transform.position = tempPosition;
	}
}
