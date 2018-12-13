using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {

    if (collider.gameObject.name == "ResetCube")
        {
            GameObject ResetCube;
            ResetCube = GameObject.Find("ResetCube");
            Debug.Log("Reset scene");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
