using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Movie : MonoBehaviour
{
    //public VideoClip videoClip;

    //private string videoURL = "http://www.quirksmode.org/html5/videos/big_buck_bunny.mp4";
    private string videoURL = "C:\\Users\\jerem\\OneDrive\\Desktop\\VID_20180227_174537.mp4";
    //private string videoURL = "C:\\Users\\jerem\\OneDrive\\Desktop\\VID_20181008_210412.mp4";

    private MouseClick mouseClick;
    private ApiTracker apiTracker; 

    

    void Start()
    {
        var videoPlayer = gameObject.AddComponent<VideoPlayer>();
        //var audioSource = gameObject.AddComponent<AudioSource>();

        videoPlayer.isLooping = true;

        videoPlayer.playOnAwake = true;
        videoPlayer.url = videoURL;
        //videoPlayer.clip = videoClip;
        videoPlayer.renderMode = VideoRenderMode.MaterialOverride;
        videoPlayer.targetMaterialRenderer = GetComponent<Renderer>();
        videoPlayer.targetMaterialProperty = "_MainTex";
       
    }

    void Awake()
    {
        mouseClick = GetComponent<MouseClick>();
        apiTracker = GetComponent<ApiTracker>();

    }


    public void OnCollisionEnter(Collision collision)
    {
        if (apiTracker.apiCount > 2 && apiTracker.apiCount < 5)
        {
            videoURL = "C:\\Users\\jerem\\OneDrive\\Desktop\\VID_20181008_210412.mp4";
        }
        else
        {
            videoURL = "C:\\Users\\jerem\\OneDrive\\Desktop\\VID_20180227_174537.mp4";
        }
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
}