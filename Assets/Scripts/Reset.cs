using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;

    // Use this for initialization
    void Start () {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Reset")
        {
            SceneManager.LoadScene("ObjectGrab", LoadSceneMode.Single);
            Debug.Log("Reset scene");
        }
    }
}
