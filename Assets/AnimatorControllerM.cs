using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class AnimatorControllerM : MonoBehaviour
{
    public Animator merchAnimator;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            merchAnimator.SetTrigger("shake");
        }
    }
}
