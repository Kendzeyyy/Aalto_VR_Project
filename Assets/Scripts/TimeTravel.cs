﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTravel : MonoBehaviour{

    public Transform teleportTarget;
    public GameObject player;
    public TextMesh year;
    private int a;


    // Use this for initialization
    void Start(){
        player = GameObject.FindWithTag("Player");
        a = 2018;
        year.text = a.ToString();


    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player"){
            player.transform.position = teleportTarget.transform.position;
            year.text = a.ToString();
            a--;
        }
    }
}
