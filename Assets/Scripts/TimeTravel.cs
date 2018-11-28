using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTravel : MonoBehaviour{

    public Transform teleportTarget;
    public GameObject player;
    public GameObject year;
    public string text;


    // Use this for initialization
    void Start(){
        player = GameObject.FindWithTag("Player");
        GetComponent<TextMesh>().text = "test";

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player"){
            player.transform.position = teleportTarget.transform.position;
        }
    }
}
