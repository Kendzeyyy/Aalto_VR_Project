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

        //remains = (GameObject)Resources.Load("Assets/Prefabs/RemainsApi", typeof(GameObject));
        remains = (Resources.Load("Assets/Prefabs/RemainsBox") as GameObject).gameObject;
        Debug.Log("Load remainbox api");
 
    }

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag.StartsWith("Des20"))
		{
			Vector3 temp = gameObject.transform.position;
			Destroy(gameObject);
			Instantiate(remains,temp,Quaternion.identity);
			//audioSource.Play();
			GetComponent<AudioSource>().Play();
			audioSource.PlayOneShot(collisionSound, 0.05f);
			Debug.Log("Breaking sound played");
        }
    }
}
