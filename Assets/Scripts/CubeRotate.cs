using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour {

	Transform cmpTransform;
	Vector3 rotationVector = new Vector3(0f, 0.2f, 0f);

	// Use this for initialization
	void Start () {
		cmpTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		cmpTransform.Rotate(rotationVector);
	}
}
