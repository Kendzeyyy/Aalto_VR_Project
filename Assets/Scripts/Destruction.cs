using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour {

	public GameObject remains;

	// Use this for initialization
	void Start()
	{
		remains = GameObject.FindWithTag("RemainsCube");
	}
	// Update is called once per frame
	void Update()
	{

	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.name == "DestroyCubes")
        {
			Destroy(collider.gameObject);
			
		}
    }
}
