using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;
using UnityEngine.XR;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;

public class Rotate : MonoBehaviour
{
    public GameObject Player;
    float distance;
    public static bool ShakingHands = false;

    void Update()
    {
        distance = Vector3.Distance(transform.position, Player.transform.position);
        if ((AnimatorController.ShakingHands == true) && (distance < 1.2f))
        {
            Player.transform.rotation = Quaternion.Euler
            (transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 180, transform.rotation.eulerAngles.z);
        }
    }
}