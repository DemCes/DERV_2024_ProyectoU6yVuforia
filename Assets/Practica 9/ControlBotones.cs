using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  

public class ControlBotones: MonoBehaviour
{
    [SerializeField] Animator anim;

    private int index = -1;

    
    public void PlayAnimation(int animationIndex)
    {
        switch (animationIndex)
        {
            case 0:
                anim.Play("Can Can");
                break;
            case 1:
                anim.Play("House Dance");
                break;
            case 2:
                anim.Play("Tut Hip Hop");
                break;
        }
        index = animationIndex;
    }
}