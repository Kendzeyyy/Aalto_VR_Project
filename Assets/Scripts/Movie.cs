using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System.Collections;
using System.Collections.Generic;

public class Movie : MonoBehaviour
{

    private List<Video> movieList = new List<Video>
    {
        new Video() { VideoURL = "https://www.jwiedmann-it.de/videos/Arrival%20Trailer%20(2016)%20-%20Paramount%20Pictures.mp4"},
        new Video() { VideoURL = "https://www.jwiedmann-it.de/videos/Blue%20Planet%20II%20%20The%20Prequel.mp4"},
        new Video() { VideoURL = "https://www.jwiedmann-it.de/videos/SUPERHERO%20BABIES%20ENJOY%20MOVIE%20_%20POPCORN%20%e2%9d%a4%20SUPERHERO%20PLAY%20DOH%20CARTOONS%20FOR%20KIDS.mp4"},
        new Video() { VideoURL = "https://www.jwiedmann-it.de/videos/The%20Century%20of%20the%20Self%20-%20Part%201%20Happiness%20Machines.mp4"}
    };

    private MouseClick mouseClick; //TODO for selection o stop videos and stuff 
    private ApiTracker apiTracker;

    private string currentVideoURL;

    

    void Start()
    {
        var videoPlayer = gameObject.AddComponent<VideoPlayer>();
        //var audioSource = gameObject.AddComponent<AudioSource>();

        videoPlayer.isLooping = true;

        videoPlayer.playOnAwake = true;
        videoPlayer.url = currentVideoURL;
        //videoPlayer.clip = videoClip;
        videoPlayer.renderMode = VideoRenderMode.MaterialOverride;
        videoPlayer.targetMaterialRenderer = GetComponent<Renderer>();
        videoPlayer.targetMaterialProperty = "_MainTex";
       
    }

    

    void Awake()
    {
        mouseClick = GetComponent<MouseClick>(); //TODO for selection o stop videos and stuff 
        apiTracker = GetComponent<ApiTracker>();

    }


    public void OnCollisionEnter(Collision collision)
    {
        currentVideoURL = movieList[apiTracker.apiCount % movieList.Count].VideoURL;
    }




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            VideoPlayer vp = GetComponent<VideoPlayer>();

            if (vp.isPlaying)
            {
                vp.Pause();
            }
            else
            {
                vp.Play();
            }
        }
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        vp.playbackSpeed = vp.playbackSpeed / 10.0F;
    }

    internal class Video 
    {
        public string VideoURL { get; set; }

    }
}