using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayingDaMovie : MonoBehaviour
{
    private VideoPlayer vP;

    // Start is called before the first frame update
    void Start()
    {
        vP = FindObjectOfType<VideoPlayer>();
    }

    public void VideoPlayerHandler(VideoClip _clip)
    {
        if(_clip == vP.clip)
        {
            if (vP.isPlaying) { vP.Pause(); }
            else { vP.Play(); }
            
        }
        else
        {
            vP.clip = _clip;
            vP.Play();
        }
    }
}
