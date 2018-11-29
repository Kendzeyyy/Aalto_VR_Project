using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Movie : MonoBehaviour {
    //public VideoClip videoClip;

    private string videoURL = "http://www.quirksmode.org/html5/videos/big_buck_bunny.mp4";

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
