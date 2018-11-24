using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour {

	public GameObject remains;
	public GameObject cube1;

	// Use this for initialization
	void Start(){

		remains = (Resources.Load("Assets/Prefabs/RemainsApi") as GameObject).gameObject;
		//remains = (GameObject)Resources.Load("Assets/Prefabs/RemainsApi", typeof(GameObject));
		cube1 = GameObject.FindGameObjectWithTag("cube1");
	}

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "DestroyCubes"){
			Destroy(gameObject);
			Instantiate(remains);

		}
    }
}
