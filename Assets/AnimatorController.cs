using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public static bool ShakingHands = false;
    public Animator humanAnimator;
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {
            humanAnimator.SetBool("Walk", true);
            ShakingHands = false;
        } 
        else if (Input.GetKey(KeyCode.E))
        {
            humanAnimator.SetTrigger("Shake");
            ShakingHands = true;
        }
        else
        {
            humanAnimator.SetBool("Walk", false);
        }
    }
}
