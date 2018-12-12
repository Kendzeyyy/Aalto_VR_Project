using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;
using System.Net;
using Newtonsoft.Json;

public class Flickr : MonoBehaviour
{
    //used packages: 
    //Install-package 
    //Newtonsoft.Json


    //this is what we need. there is min and max dates for upload+taken. 
    //https://www.flickr.com/services/api/flickr.people.getPhotos.html
    // private FlickrNet.Flickr myFlickr;     //flickrnet didnt work with unity..

    private string myApiKey = Secrets.myApiKey;
    //private string mySecretKey = Secrets.mySecretKey;
    private string userid = Secrets.userid;
    private string flickrFrob = "";
    private string token = "";
    private string username = "";
    private string url = "";
    private string minUploadDate = "";
    private string maxUploadDate = "";
    private string minTakenDate = "";
    private string maxTakenDate = "";
    List<string> flickrpicturelist = new List<string>();

    private ApiTracker apiTracker;

    void Awake()
    {
        apiTracker = GetComponent<ApiTracker>();
    }


    public IEnumerator OnCollisionEnter(Collision collision)
    {
        //texture things..in unity.
        Texture2D tex;
        tex = new Texture2D(4, 4, TextureFormat.DXT1, false);

        //api call example
        //https://api.flickr.com/services/rest/?method=flickr.people.getPhotos&api_key=0579d5b4256b91929f80cea37fb63f8c&user_id=134653989%40N07&min_upload_date=1.1.2018&max_upload_date=31.12.2018&min_taken_date=&max_taken_date=&content_type=&format=json&nojsoncallback=1&auth_token=72157702486478861-fa74bb8610aa766e&api_sig=4122e3678f6107dc4ad280c07952b2f3
        var noSignUrl = "https://api.flickr.com/services/rest/" +
            "?method=flickr.people.getPhotos" +
            "&api_key=0579d5b4256b91929f80cea37fb63f8c" +
            "&user_id=134653989%40N07" +
            "&min_upload_date=1.1.2018=" +
            "&max_upload_date=31.12.2018" +
            "&min_taken_date=" +
            "&max_taken_date=" +
            "&content_type=" +
            "&format=json" +
            "&nojsoncallback=1" +
            "&auth_token=72157702486478861-fa74bb8610aa766e" +
            "&api_sig=f7b42ae3f1fc127d93bc0f141bdbf590";


        //this one we use, values binded to get flexible usage
        url = "https://api.flickr.com/services/rest/" +
            "?method=flickr.people.getPhotos" +
            "&api_key={0}" +
            "&user_id={1}" +
            "&min_upload_date={2}=" +
            "&max_upload_date={3}" +
            "&min_taken_date=" +
            "&max_taken_date=" +
            "&content_type=" +
            "&format=json" +
            "&nojsoncallback=1";


        //these can be set from cubes' values .. so tag them here. now hardcoded.
        minUploadDate = "24.11.2018";
        maxUploadDate = "31.12.2018";

        var baseUrl = string.Format(url, myApiKey, userid, minUploadDate, maxUploadDate);
        Debug.Log("this is the api url request BASEURL " + baseUrl);

        //ok so httpwebreq cant handle SHA256 Certificate, use unitywebrequest or www instead. 
        using (WWW www = new WWW(baseUrl))
        {
            yield return www;
            Debug.Log("this is WWW call " + www);

            string flickrResult = www.text;
            Debug.Log("this is supposed to be the json from server: " + flickrResult);
            FlickrData apiData = JsonConvert.DeserializeObject<FlickrData>(flickrResult);

            foreach (Photo data in apiData.photos.photo)
            {
                //retrieve one photo: 
                // http://farm{farmid}.staticflickr.com/{server-id}/{id}_{secret}{size}.jpg

                string photoUrl = "http://farm{0}.staticflickr.com/{1}/{2}_{3}_n.jpg";

                string baseFlickrUrl = string.Format(photoUrl,
                    data.farm,
                    data.server,
                    data.id,
                    data.secret);

                Debug.Log("this is  image url for one image.. hopefully: " + baseFlickrUrl);
                // yield return baseFlickrUrl;
                //add picture's address to list.. 
                flickrpicturelist.Add(baseFlickrUrl);


            }
            //access list of pictures with certain api request like this
            // loop through the pictures in a ring
            using (WWW xxx = new WWW(flickrpicturelist[apiTracker.apiCount % flickrpicturelist.Count]))
            {
                yield return xxx;
                xxx.LoadImageIntoTexture(tex);
                GetComponent<Renderer>().material.mainTexture = tex;
            }
        }



    }

    // Update is called once per frame
    void Update()
    { }


    //stuff for flickr's api.. dont delete ! :)
    public class Photo
    {
        public string id { get; set; }
        public string owner { get; set; }
        public string secret { get; set; }
        public string server { get; set; }
        public int farm { get; set; }
        public string title { get; set; }
        public int ispublic { get; set; }
        public int isfriend { get; set; }
        public int isfamily { get; set; }
    }

    public class Photos
    {
        public int page { get; set; }
        public int pages { get; set; }
        public int perpage { get; set; }
        public string total { get; set; }
        public List<Photo> photo { get; set; }
    }

    public class FlickrData
    {
        public Photos photos { get; set; }
        public string stat { get; set; }
    }
}