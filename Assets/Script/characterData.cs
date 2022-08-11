using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

//  [RequireComponent(typeof(Animator))]
public class characterData : MonoBehaviour
{
    public Animator anim; 
    public int health;
    public float animFramecount;
    public float atkCooldown, cooldownTimer, atkWait, diagonalLook;//diagonalLook +1 Looking upward, -1 Looking downward;

    public bool lookRight;
    public Vector3 position;
    // Start is called before the first frame update

    public characterData(Vector3 getPos, bool getFaceSide, float getAtkCool, float getCoolTimer, float getWait, float getOrient, int getHealth, float GetFrameCount)
    {
        this.position = getPos;
        this.lookRight = getFaceSide;
        this.atkCooldown = getAtkCool;
        this.cooldownTimer = getCoolTimer;
        this.atkWait = getWait;
        this.diagonalLook = getOrient;
        this.health = getHealth;
        this.animFramecount = GetFrameCount;
    }
    
    public characterData copyData(characterData copyData){
        return new characterData(copyData.position, copyData.lookRight,
        copyData.atkCooldown, copyData.cooldownTimer, copyData.atkWait, copyData.diagonalLook,
        copyData.health, copyData.animFramecount);
    }

    public void updateChar(){
        // anim.playbackTime(anim.animat)
    }
    /*
    public void updateCharData(characterData getData)
    {
        this.position = getData.position;
        this.lookRight = getData.lookRight;
        this.atkCooldown = getData.atkCooldown;
        this.cooldownTimer = getData.cooldownTimer;
        this.atkWait = getData.atkWait;
        this.diagonalLook = getData.diagonalLook;
        this.health = getData.health;
        this.animFramecount = getData.animFramecount;
    }*/

}
