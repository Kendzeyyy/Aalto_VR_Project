using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirFloating : MonoBehaviour {

    public float FloatStrenght;
    public float RandomRotationStrenght;


    // Use this for initialization
    void Start () {
		
	}

       void Update()
    {
       // transform.GetComponent<Rigidbody>().AddForce(Vector3.up * FloatStrenght);
        transform.GetComponent<Rigidbody>().AddForce(0, -5, 0);
       
        //transform.Rotate(RandomRotationStrenght, RandomRotationStrenght, RandomRotationStrenght);
    }
}
