using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;
using System.Net;
using Newtonsoft.Json;
using UnityEngine.Video;

public class ApiSelector : MonoBehaviour {

    public Texture m_MainTexture;

    private enum API { Flickr, Youtube };

    void OnCollisionEnter(Collision collision)
    {
        setBackgroundToDefault();
        Debug.Log(collision.gameObject.name + " collided with " + this.gameObject.name);
        string nameOfGameObject = collision.gameObject.name;

        if (nameOfGameObject == API.Flickr.ToString())
        {
            removeConflictingScipts();
            gameObject.AddComponent<Flickr>();
        }
        else if (nameOfGameObject == API.Youtube.ToString())
        {

            removeConflictingScipts();
            gameObject.AddComponent<Movie>();
        }
    }

    private void removeConflictingScipts()
    {
        Destroy(gameObject.GetComponent<Flickr>());
        Destroy(gameObject.GetComponent<Movie>());
        Destroy(gameObject.GetComponent<VideoPlayer>());
    }

    private void setBackgroundToDefault()
    {
        Renderer m_Renderer = gameObject.GetComponent<Renderer>();
        m_Renderer.material.SetTexture("_MainTex", m_MainTexture);
    }
}

