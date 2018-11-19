using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
 
    public float targetTime = 5.0f;
    Vector3 originalPosition;

	// Use this for initialization
	void Start()
	{
		originalPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        
    }

	// Update is called once per frame
	void Update()
	{
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            // Moving the cubes slowly towards camera
            transform.Translate(0f, 0f, -0.1f * Time.deltaTime);
            timerEnded();
        }
	}

    void timerEnded()
    {
        // Reverse cubes movements
        
    }

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "End")
		{
			transform.position = originalPosition;
		}
	}
}
