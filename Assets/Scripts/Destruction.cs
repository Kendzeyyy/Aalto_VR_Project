using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour {

	public GameObject remains;
    public AudioSource audioSource;
	public AudioClip collisionSound;

    // Use this for initialization
    void Start(){
        audioSource = GetComponent<AudioSource>();
        collisionSound = GetComponent<AudioClip>();

        //remains = (GameObject)Resources.Load("Assets/Prefabs/RemainsApi", typeof(GameObject));
        remains = (Resources.Load("Assets/Prefabs/RemainsBox") as GameObject).gameObject;
        Debug.Log("Load remainbox api");
        //breakingbox = (Resources.Load("Assets/Sound/BreakingSound") as AudioSource);

        
    }

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "2019")
		{
            Vector3 temp = gameObject.transform.position;
			Destroy(gameObject);
			Instantiate(remains,temp,Quaternion.identity);
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = collisionSound;
            audioSource.Play();
            Debug.Log("toimiii");
        }
    }
}
