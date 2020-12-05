using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones; // importante

public class Exemplo : MonoBehaviour
{
    public UnityArmatureComponent armatureComponent;
    public float hatTimeScale = 1;
    public float danceTimeScale = 1;
    public float idleTimeScale = 1;


    public void TouchHat(){
        armatureComponent.animation.Play("hat", 1);
        armatureComponent.animation.timeScale = hatTimeScale;
    }

    public void Dance(){
        armatureComponent.animation.Play("dance");
        armatureComponent.animation.timeScale = danceTimeScale;
    }

    public void Idle(){
        armatureComponent.animation.Play("idle");
        armatureComponent.animation.timeScale = idleTimeScale;
    }

}
