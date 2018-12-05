using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderYearsLed : MonoBehaviour {

    public Renderer[] rend;
    public Material materiala;
    public Material defaultColor;

    int max;

    // Use this for initialization
    void Start () {

       
        rend = GetComponentsInChildren<Renderer>();
        materiala = Resources.Load<Material>("ColorChange/LimeLight");
        defaultColor = rend[0].material;
        max = rend.Length;
        Debug.Log(max);
    }

   
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            for (int i = 0; i < max; i++)
            {
                Debug.Log(rend[i].name);
                rend[i].material = materiala;
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            for (int i = 0; i < max; i++)
            {
                Debug.Log(rend[i].name);
                rend[i].material = defaultColor;
            }
        }
    }
    
}
