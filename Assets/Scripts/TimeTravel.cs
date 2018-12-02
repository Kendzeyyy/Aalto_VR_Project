using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTravel : MonoBehaviour{

    public Transform teleportTarget;
    public GameObject player;
    public TextMesh year;


    // Use this for initialization
    void Start(){
        player = GameObject.FindWithTag("Player");

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player"){
            player.transform.position = teleportTarget.transform.position;
            year.text = "2017";
        }
    }
}
