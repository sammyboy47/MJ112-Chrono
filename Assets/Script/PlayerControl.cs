using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    /*
        MOUSE
        LB -    TIME MODE : SELECT(click - goes to Action Mode) - REWIND(HOLD)
        RB -    TIME MODE:  PLAY/STOP (click)
                            MODE(HOLD)
                ACTION  :   ORDER (CLICK)

        LB -    CLICK on Agent - Char Action, stops
                CLICK OUTSIDE - PLAY/STOP

                CHAR ACTION - unselect agent

        RB -    HOLD (REWIND) RLEASE(STOP)
                Click on Agent - Movement

            
    */
    [Header ("Is it currently controlling a character?")]
    public bool isControl = false; //Controlling an Agent
    [System.Serializable]
    public class btnFunction {
        public bool isSecondFunction { get { return pressTimer > 0.5f; } }
        public float pressTimer;
        public KeyCode btnKey;
        // public btnFunction(KeyCode getKey)
        // {
        //     this.isSecondFunction = false;
        //     this.pressTimer = 0;
        //     btnKey = getKey;
        // }
    }

    public KeyCode btnL, btnR, btnM;

    public enum btnInput { LB, MB, RB }
    public btnFunction btnRewind, btnPlay, btnTimeMenu,
    btnCharPrev, btnCharNext, btnCharMenu,
    btnRotLeft, btnRoRight, btnNext,
    btnDistanceLeft, btnDistanceRight;

    public btnInput plyrInput;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (!isControl && isNotControllingAgent())
        {

        }
    }

    public void OldCode () {
        #region Old Code
        /*
        #region PressDown
        if (Input.anyKey)
            switch (GameMaster.instance.CtrlMode) {
                case GameMaster.ControlMode.TIME:
                    if (Input.GetKey (btnL)) {
                        GameMaster.instance.sysTime.fncSetTimeState (-1); // = TimelineControl.stateOfTime.REWIND;
                        // btnRewind.pressTimer += Time.deltaTime;
                    }
                    // else if (Input.GetKeyDown(btnM))
                    // {
                    //     // GameMaster.instance.sysTime.fncSetTimeState(0);//timeState = TimelineControl.stateOfTime.STOP;
                    //     //CHANGE MENU
                    // }
                    else if (Input.GetKeyDown (btnR)) {
                        if (GameMaster.instance.sysTime.timeState == TimelineControl.stateOfTime.STOP)
                            GameMaster.instance.sysTime.fncSetTimeState (1); //timeState = TimelineControl.stateOfTime.PLAY;
                        else if (GameMaster.instance.sysTime.timeState == TimelineControl.stateOfTime.PLAY)
                            GameMaster.instance.sysTime.fncSetTimeState (0); //timeState = TimelineControl.stateOfTime.STOP;
                    }
                    if (Input.GetKey (btnM)) {
                        btnTimeMenu.pressTimer += Time.deltaTime;
                    }
                    break;
                case GameMaster.ControlMode.CHARSELECT:
                    if (Input.GetKey (btnL)) { } //
                    else if (Input.GetKey (btnR)) { } else if (Input.GetKey (btnM)) {
                        // print("CHECK BTNCHARMENU ON " + Time.time);
                        btnCharMenu.pressTimer += Time.deltaTime;
                    }
                    break;
                case GameMaster.ControlMode.ORIENT:
                    if (Input.GetKey (btnL)) { } //ROTATE LEFT--
                    if (Input.GetKey (btnR)) { } //FINISH
                    if (Input.GetKey (btnM)) { } //ROTATE RIGHT++
                    break;
                case GameMaster.ControlMode.MOVE:
                    //use pathfinding here
                    if (Input.GetKey (btnL)) { } //DISTANCE--
                    if (Input.GetKey (btnR)) { } //FINISH
                    if (Input.GetKey (btnM)) { } //DISTANCE++
                    break;
                case GameMaster.ControlMode.AIM:
                    //
                    if (Input.GetKey (btnL)) { } //ROTATE LEFT
                    if (Input.GetKey (btnR)) { } //NEXT
                    if (Input.GetKey (btnM)) { } //ROTATE RIGT
                    break;
                default:
                    break;
            }
        #endregion
        #region PressUp
        else
            switch (GameMaster.instance.CtrlMode) {
                case GameMaster.ControlMode.TIME:

                    if (Input.GetKeyUp (btnL)) {
                        // GameMaster.instance.sysTime.timeState = TimelineControl.stateOfTime.STOP;
                        GameMaster.instance.sysTime.fncSetTimeState (0);
                        btnRewind.pressTimer = 0;
                    }
                    if (Input.GetKeyUp (btnR)) {
                        btnPlay.pressTimer = 0;
                    }
                    if (Input.GetKeyUp (btnM)) { //timeState = TimelineControl.stateOfTime.STOP;
                        GameMaster.instance.sysTime.fncSetTimeState (0);
                        if (btnTimeMenu.isSecondFunction) { GameMaster.instance.CtrlMode = GameMaster.ControlMode.CHARSELECT; }
                        btnTimeMenu.pressTimer = 0;

                        //CHANGE MENU
                    }

                    break;
                case GameMaster.ControlMode.CHARSELECT:
                    if (Input.GetKey (btnL)) { btnCharPrev.pressTimer = 0; } //
                    else if (Input.GetKey (btnR)) { btnCharNext.pressTimer = 0; } else if (Input.GetKey (btnM)) {
                        print ("KEYUP ON BTNCHARMENU at " + Time.time);
                        if (btnCharMenu.isSecondFunction)
                            GameMaster.instance.CtrlMode = GameMaster.ControlMode.TIME;
                        else { }
                        btnCharMenu.pressTimer = 0;
                    }
                    break;
                case GameMaster.ControlMode.ORIENT:
                    if (Input.GetKey (btnL)) { } //ROTATE LEFT--
                    if (Input.GetKey (btnR)) { } //FINISH
                    if (Input.GetKey (btnM)) { } //ROTATE RIGHT++
                    break;
                case GameMaster.ControlMode.MOVE:
                    //use pathfinding here
                    if (Input.GetKey (btnL)) { } //DISTANCE--
                    if (Input.GetKey (btnR)) { } //FINISH
                    if (Input.GetKey (btnM)) { } //DISTANCE++
                    break;
                case GameMaster.ControlMode.AIM:
                    //
                    if (Input.GetKey (btnL)) { } //ROTATE LEFT
                    if (Input.GetKey (btnR)) { } //NEXT
                    if (Input.GetKey (btnM)) { } //ROTATE RIGT
                    break;
                default:
                    break;
            }
        #endregion
        */
        #endregion
    }

    public void fncClickOnAgent () { }
    public void fncMouseOnAgent (bool isMouseOn) {
        isControl = isMouseOn;
    }

    bool isNotControllingAgent () {
        return GameMaster.instance.CtrlMode != GameMaster.ControlMode.CHARSELECT &&
            GameMaster.instance.CtrlMode != GameMaster.ControlMode.ORIENT &&
            GameMaster.instance.CtrlMode != GameMaster.ControlMode.MOVE &&
            GameMaster.instance.CtrlMode != GameMaster.ControlMode.AIM;
    }

    IEnumerator btn1, btn2, btn3;

    IEnumerator fncBtnPress (btnFunction thisBtn) {
        float pressTime = 0;
        bool isBtnPress = true;
        KeyCode thisKeyCode = GameMaster.instance.btn1; {
            // switch()
            yield return null;
            pressTime += Time.deltaTime;
        }
        while (!isBtnPress);
        // yield return null;
    }

}