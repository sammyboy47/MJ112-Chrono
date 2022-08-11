using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineControl : MonoBehaviour
{
    public int FrameCount;
    public bool isRewind = false, isPlay = false;
    public enum stateOfTime
    {
        REWIND, STOP, PLAY
    }
    public stateOfTime timeState = stateOfTime.STOP;
    public GameMaster GMSys;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FixedUpdate()
    {
        switch (timeState)
        {
            case stateOfTime.STOP:
                break;
            case stateOfTime.REWIND:
                if (FrameCount > 0)
                { FrameCount--; }
                if(FrameCount<0) FrameCount = 0;
                break;
            case stateOfTime.PLAY:
                FrameCount++;
                break;
            default:
                break;
        }

    }

    public void fncSetTimeState(int getState)
    {
        if (getState == -1) timeState = stateOfTime.REWIND;
        else if (getState == 0) timeState = stateOfTime.STOP;
        else if (getState == 1) timeState = stateOfTime.PLAY;
    }
}
