using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones; // importante

public class Novo : MonoBehaviour
{
     public UnityArmatureComponent armatureComponent;

         public void Hello(){
        armatureComponent.animation.Play("tchau", 1);
        armatureComponent.animation.timeScale = 1.2f;
    }

    public void Dance(){
        armatureComponent.animation.Play("dance");
        armatureComponent.animation.timeScale = 0.7f;
    }

}
