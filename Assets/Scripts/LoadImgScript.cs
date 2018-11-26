using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml;
using System.ComponentModel;

using System.Linq;
using System.Text;
//using FlickrNet;


public class LoadImgScript : MonoBehaviour
{

    private string url = "https://docs.unity3d.com/uploads/Main/ShadowIntro.png";
    private string flickrstaticurl = "https://api.flickr.com/services/rest/?method=flickr.people.getPhotos&api_key=4296d1e17b486dae66f1cd78c725d8d2&user_id=134653989@N07";
    Texture2D img;
    private string myApiKey = "4296d1e17b486dae66f1cd78c725d8d2";
    private string userid = "134653989@N07";
    private string mySecretKey = "8afe1fec0cae3b57";


    /*class Flickerinos : IFlickrParsable
    {
        LoadImgScript p = new LoadImgScript();
        FlickrNet.Flickr flik = new FlickrNet.Flickr(p.myApiKey, p.mySecretKey);

    }*/

    // Use this for initialization
    /*void Start () {
        StartCoroutine(LoadImg());
	}
	
    IEnumerator LoadImg()
    {
        yield return 0;
        WWW imgLink = new WWW(url);
        yield return imgLink;
        img = imgLink.texture;
    }

	// Update is called once per frame
	void OnGUI () {
        GUILayout.Label(img);
	}*/

    IEnumerator Start()
    {
        //  Flickr flickr = new Flickr(myApiKey);
        
        Texture2D tex;
        tex = new Texture2D(4, 4, TextureFormat.DXT1, false);
          using (WWW www = new WWW(url))
          {
              yield return www;
              www.LoadImageIntoTexture(tex);
              GetComponent<Renderer>().material.mainTexture = tex;
          }
        // var options = new PhotoSearchOptions { Tags = "colorful", PerPage = 20, Page = 1 };
        //PhotoCollection photos = flickr.PeopleGetPhotos();
        //add api key + userid

        //var options = new PhotoSearchOptions { PerPage = 2, Page = 1, UserId = "134653989@N07" };
        //PhotoCollection photos = FlickrManager.GetInstance().PhotosSearch(options);

        /*    foreach (Photo photo in photos)
            {
                Console.WriteLine("Photo {0} has title {1}", photo.PhotoId, photo.Title);
            }*/
    }
    /*public static FlickrNet.Flickr GetInstance()
    {
        return new FlickrNet.Flickr(ApiKey, SharedSecret);
    }*/

}
