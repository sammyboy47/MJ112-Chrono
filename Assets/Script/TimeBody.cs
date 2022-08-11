using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBody : MonoBehaviour
{
    bool isRewinding = false;
    public int RecCntr;
    List<timeData> recordData;
    public characterData charData;


    // Start is called before the first frame update
    void Start()
    {
        recordData = new List<timeData>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameMaster.instance.isRewind())
            fncStartRewind();
        else fncStopRewind();
    }

    void FixedUpdate()
    {
        if (isRewinding)
            fncRewind();
        else
            fncRecord();

    }

    public void fncStartRewind() { isRewinding = true; }
    public void fncStopRewind()
    {
        isRewinding = false;
    }

    public void fncRewind()
    {
        //int getFrame = 
        if(recordData.Count>0)
            charData = charData.copyData(recordData[GameMaster.instance.sysTime.FrameCount].charData);
        else
        fncStopRewind();
    }
    public void fncRecord()
    {
        recordData.Insert(0, new timeData(charData));
    }
}