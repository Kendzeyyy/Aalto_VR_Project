using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour {

	public GameObject remains;
	public AudioSource breakingbox;

	// Use this for initialization
	void Start(){

		//remains = (GameObject)Resources.Load("Assets/Prefabs/RemainsApi", typeof(GameObject));
		remains = (Resources.Load("Assets/Prefabs/RemainsBox") as GameObject).gameObject;

		//breakingbox = (Resources.Load("Assets/Sound/BreakingSound" as AudioSource);
		breakingbox = GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "2019")
		{
            Vector3 temp = gameObject.transform.position;
			Destroy(gameObject);
			Instantiate(remains,temp,Quaternion.identity);
			breakingbox.Play();
		}
    }
}
