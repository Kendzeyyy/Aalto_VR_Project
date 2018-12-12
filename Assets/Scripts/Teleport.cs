using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

	public Transform teleportTarget;
	public Transform teleportTarget2;
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

	void OnTriggerEnter(Collider collider){

		//--- Straps ---

		if (collider.gameObject.name == "strap1")
		{
			GameObject strap1;
			strap1 = GameObject.Find("strap1");
			strap1.transform.position = teleportTarget2.transform.position;
		}

		else if (collider.gameObject.name == "strap2")
		{
			GameObject strap2;
			strap2 = GameObject.Find("strap2");
			strap2.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap3")
		{
			GameObject strap3;
			strap3 = GameObject.Find("strap3");
			strap3.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap4")
		{
			GameObject strap4;
			strap4 = GameObject.Find("strap4");
			strap4.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap5")
		{
			GameObject strap5;
			strap5 = GameObject.Find("strap5");
			strap5.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap6")
		{
			GameObject strap6;
			strap6 = GameObject.Find("strap6");
			strap6.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap7")
		{
			GameObject strap7;
			strap7 = GameObject.Find("strap7");
			strap7.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap8")
		{
			GameObject strap8;
			strap8 = GameObject.Find("strap8");
			strap8.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap9")
		{
			GameObject strap9;
			strap9 = GameObject.Find("strap9");
			strap9.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap10")
		{
			GameObject strap10;
			strap10 = GameObject.Find("strap10");
			strap10.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap11")
		{
			GameObject strap11;
			strap11 = GameObject.Find("strap11");
			strap11.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap12")
		{
			GameObject strap12;
			strap12 = GameObject.Find("strap12");
			strap12.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap13")
		{
			GameObject strap13;
			strap13 = GameObject.Find("strap13");
			strap13.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap14")
		{
			GameObject strap14;
			strap14 = GameObject.Find("strap14");
			strap14.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap15")
		{
			GameObject strap15;
			strap15 = GameObject.Find("strap15");
			strap15.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap16")
		{
			GameObject strap16;
			strap16 = GameObject.Find("strap16");
			strap16.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap17")
		{
			GameObject strap17;
			strap17 = GameObject.Find("strap17");
			strap17.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap18")
		{
			GameObject strap18;
			strap18 = GameObject.Find("strap18");
			strap18.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap19")
		{
			GameObject strap19;
			strap19 = GameObject.Find("strap19");
			strap19.transform.position = teleportTarget2.transform.position;
		}
		else if (collider.gameObject.name == "strap20")
		{
			GameObject strap20;
			strap20 = GameObject.Find("strap20");
			strap20.transform.position = teleportTarget2.transform.position;
		}
		

		//--- cubes ---

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
		else if (collider.gameObject.name == "ResetCube")
		{
			GameObject ResetCube;
			ResetCube = GameObject.Find("ResetCube");
			ResetCube.transform.position = teleportTarget.transform.position;
		}
	}
}
