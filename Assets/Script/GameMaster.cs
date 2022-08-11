using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {
    public static GameMaster instance;

    public TimelineControl sysTime;

    public KeyCode btn1, btn2, btn3;

    public enum ControlMode { TIME, CHARSELECT, ORIENT, MOVE, AIM }
    public ControlMode CtrlMode;
    public bool isRewind () //= false; 
    {
        return sysTime.timeState == TimelineControl.stateOfTime.REWIND;
    }
    void Awake () {
        if (instance == null) instance = this;
        else GameObject.Destroy (this);
    }

    // Start is called before the first frame update
    void Start () {

    }

    // public void btnPress(KeyCode getKey)

    // Update is called once per frame
    void FixedUpdate () {
        #region
        /*
        switch (CtrlMode)
        {
            case ControlMode.TIME:
                if (Input.GetKey(btn1)) { sysTime.timeState = TimelineControl.stateOfTime.REWIND; }
                if (Input.GetKeyUp(btn1)) { sysTime.timeState = TimelineControl.stateOfTime.STOP; }
                if (Input.GetKeyDown(btn2))
                {
                    sysTime.timeState = TimelineControl.stateOfTime.STOP;
                    //CHANGE MENU
                }
                if (Input.GetKeyDown(btn3))
                {
                    if (sysTime.timeState == TimelineControl.stateOfTime.STOP)
                        sysTime.timeState = TimelineControl.stateOfTime.PLAY;
                    else if (sysTime.timeState == TimelineControl.stateOfTime.PLAY)
                        sysTime.timeState = TimelineControl.stateOfTime.STOP;
                }
                break;
            case ControlMode.CHARSELECT:
                if (Input.GetKey(btn1)) { }//
                if (Input.GetKey(btn2)) { }
                if (Input.GetKey(btn3)) { }
                break;
            case ControlMode.ORIENT:
                if (Input.GetKey(btn1)) { }//ROTATE LEFT--
                if (Input.GetKey(btn2)) { }//FINISH
                if (Input.GetKey(btn3)) { }//ROTATE RIGHT++
                break;
            case ControlMode.MOVE:
            //use pathfinding here
                if (Input.GetKey(btn1)) { }//DISTANCE--
                if (Input.GetKey(btn2)) { }//FINISH
                if (Input.GetKey(btn3)) { }//DISTANCE++
                break;
            case ControlMode.AIM:
            //
                if (Input.GetKey(btn1)) { }//ROTATE LEFT
                if (Input.GetKey(btn2)) { }//NEXT
                if (Input.GetKey(btn3)) { }//ROTATE RIGT
                break;
            default: break;
        }
        */
        #endregion
    }

    public void fncSetControlMode (ControlMode getCtrlMode) {
        sysTime.fncSetTimeState (0);
        CtrlMode = getCtrlMode;
    }

}