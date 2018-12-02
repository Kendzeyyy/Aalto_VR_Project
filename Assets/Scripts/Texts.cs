using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texts : MonoBehaviour {

	void Update () {
		transform.LookAt(Camera.main.transform);
		transform.Rotate(0f, 180f, 0f);
	
	}
}
