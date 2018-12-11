using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Reset")
        {
			Debug.Log("Reset scene");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
