using UnityEngine;
using System.Collections;

public class MouseClick : MonoBehaviour
{
    public bool isSelected = false; 
    void OnMouseDown()
    {
        if (isSelected)
        {
            Debug.Log("Before mouse (if): " + isSelected);
            isSelected = false;
            Debug.Log("After mouse (if): " + isSelected);


        }
        else
        {
            Debug.Log("Before mouse (else): " + isSelected);
            isSelected = true;
            Debug.Log("After mouse (else): " + isSelected);

        }
    }
}