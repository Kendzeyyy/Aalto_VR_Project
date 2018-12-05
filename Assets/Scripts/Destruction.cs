using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour {

	public GameObject remains;


	// Use this for initialization
	void Start(){

		remains = (Resources.Load("Assets/Prefabs/RemainsApi") as GameObject).gameObject;
		//remains = (GameObject)Resources.Load("Assets/Prefabs/RemainsApi", typeof(GameObject));
	}

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "2019"){

            Vector3 temp = gameObject.transform.position;
			Destroy(gameObject);
			Instantiate(remains,temp,Quaternion.identity);

		}
    }
}
