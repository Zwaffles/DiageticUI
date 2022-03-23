using UnityEngine;

public class LoopController : MonoBehaviour
{
    public GameObject GameObjVP;
    int NormalLoopDuration = 32;
    int AddedFrames = 5;

    void Start()
    {
        var ownVP = GetComponent<UnityEngine.Video.VideoPlayer>();
        ownVP.sendFrameReadyEvents = true;
        ownVP.frameReady += Transition;
        ownVP.Prepare();
    }

    void Transition(UnityEngine.Video.VideoPlayer vp, long frame)
    {
        var ownVP = GetComponent<UnityEngine.Video.VideoPlayer>();
        var secondVP = GameObjVP.GetComponent<UnityEngine.Video.VideoPlayer>();

        if (frame < AddedFrames && secondVP.isPlaying)
        {
            frame = secondVP.frame - 32;

        }
        else if (frame == NormalLoopDuration)
        {
            secondVP.Play();
            Debug.Log("transition p1 raised");

        }
        else if (frame == (long)ownVP.frameCount - 1)
        {
            ownVP.Stop();
            ownVP.Prepare();
            Debug.Log("transition p2 raised");
        }
    }
}
