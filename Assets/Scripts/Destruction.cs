using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour {

    public GameObject theCube1;

    // Use this for initialization
    void Start()
    {
        theCube1 = GameObject.FindWithTag("cube1");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(theCube1);
        }
    }
}
