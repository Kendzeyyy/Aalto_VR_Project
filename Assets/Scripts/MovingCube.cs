using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{

	Vector3 originalPosition;

	// Use this for initialization
	void Start()
	{
		originalPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
	}

	// Update is called once per frame
	void Update()
	{
		// Moving the cubes slowly
		transform.Translate(0f, 0f, -0.1f * Time.deltaTime);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "End")
		{
			transform.position = originalPosition;
		}
	}
}
