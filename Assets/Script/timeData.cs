using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeData 
{
    public Vector3 position;
    public characterData charData;

    public timeData(characterData getData){
        charData = new characterData(getData.position, getData.lookRight, getData.atkCooldown, getData.cooldownTimer, getData.atkWait,
        getData.diagonalLook, getData.health, getData.animFramecount);
    }//(Vector3 getPos, bool getFaceSide, float getAtkCool, float getCoolTimer, float getWait, float getOrient, int getHealth, int GetFrameCount)

    public characterData getData(){
        return charData;
    }
}
