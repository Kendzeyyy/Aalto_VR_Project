using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApiTracker : MonoBehaviour
{

    public int apiCount = 0;
    private string currentActiveAPI = "";

    // Use this for initialization
    void Start()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == currentActiveAPI)
        {
            apiCount++;
            Debug.Log(currentActiveAPI + " count is now " + apiCount);
        }
        else
        {
            apiCount = 0;
        }
        currentActiveAPI = collision.gameObject.name;
        Debug.Log("Current active API: " + currentActiveAPI);
    }

    // Update is called once per frame
    void Update()
    {

    }
}