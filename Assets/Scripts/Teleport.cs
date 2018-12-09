using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

	public Transform teleportTarget;
	public GameObject theCube1;
	public GameObject theCube2;
	public GameObject theCube3;
	public GameObject theCube4;
	public GameObject theCube5;
	public GameObject theCube6;
	public GameObject theCube7;
	public GameObject theCube8;
	public GameObject theCube9;
	public GameObject theCube10;
	public GameObject theCube11;
	public GameObject theCube12;

	// Use this for initialization
	void Start () {
		theCube1 = GameObject.FindWithTag("cube1");
		theCube2 = GameObject.FindWithTag("cube2");
		theCube3 = GameObject.FindWithTag("cube3");
		theCube4 = GameObject.FindWithTag("cube4");
		theCube5 = GameObject.FindWithTag("cube5");
		theCube6 = GameObject.FindWithTag("cube6");
		theCube7 = GameObject.FindWithTag("cube7");
		theCube8 = GameObject.FindWithTag("cube8");
		theCube9 = GameObject.FindWithTag("cube9");
		theCube10 = GameObject.FindWithTag("cube10");
		theCube11 = GameObject.FindWithTag("cube11");
		theCube12 = GameObject.FindWithTag("cube12");
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "cube1")

		{
			theCube1.transform.position = teleportTarget.transform.position;

        }
		else if (collider.gameObject.tag == "cube2")
		{
			theCube2.transform.position = teleportTarget.transform.position;
		}
		else if (collider.gameObject.tag == "cube3")
		{
			theCube3.transform.position = teleportTarget.transform.position;
		}
		else if (collider.gameObject.tag == "cube4")
		{
			theCube4.transform.position = teleportTarget.transform.position;
		}
		else if (collider.gameObject.tag == "cube5")
		{
			theCube5.transform.position = teleportTarget.transform.position;
		}
		else if (collider.gameObject.tag == "cube6")
		{
			theCube6.transform.position = teleportTarget.transform.position;
		}
		else if (collider.gameObject.tag == "cube7")
		{
			theCube7.transform.position = teleportTarget.transform.position;
		}
		else if (collider.gameObject.tag == "cube8")
		{
			theCube8.transform.position = teleportTarget.transform.position;
		}
		else if (collider.gameObject.tag == "cube9")
		{
			theCube9.transform.position = teleportTarget.transform.position;
		}
		else if (collider.gameObject.tag == "cube10")
		{
			theCube10.transform.position = teleportTarget.transform.position;
		}
		else if (collider.gameObject.tag == "cube11")
		{
			theCube11.transform.position = teleportTarget.transform.position;
		}
		else if (collider.gameObject.tag == "cube12")
		{
			theCube12.transform.position = teleportTarget.transform.position;
		}
	}
}
