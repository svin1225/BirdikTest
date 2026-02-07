using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator humanAnimator;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            humanAnimator.SetBool("Walk", true);
        } else if (Input.GetKey(KeyCode.E))
        {
            humanAnimator.SetTrigger("Shake");
        }
        else
        {
            humanAnimator.SetBool("Walk", false);
        }
    }
}
