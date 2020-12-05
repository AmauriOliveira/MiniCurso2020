using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones; // importante

public class Exemplo : MonoBehaviour
{
    public UnityArmatureComponent armatureComponent;

    public void TouchHat(){
        armatureComponent.animation.Play("hat", 1);
        armatureComponent.animation.timeScale = 1.5f;
    }

    public void Dance(){
        armatureComponent.animation.Play("dance");
        armatureComponent.animation.timeScale = 1.5f;
    }

    public void Idle(){
        armatureComponent.animation.Play("idle");
        armatureComponent.animation.timeScale = 1.5f;
    }

}
