using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Vidplay : MonoBehaviour {
    [SerializeField]
    private string videoFileName;

    void Start() {
        PlayVideo();
    }

    public void PlayVideo() {
        VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
        if (videoPlayer) {
            string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
            videoPlayer.url = videoPath;
            videoPlayer.Play();
        }
    }
}