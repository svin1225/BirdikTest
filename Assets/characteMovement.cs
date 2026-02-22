using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class characteMovement : MonoBehaviour
{
    public GameObject Merch;
    public static bool ShakingHands = false;
    public CharacterController controller;
    private float speed = 5f;
    private float gravity = -9.81f;
    private float jumpheight = 5f;
    private bool isGrounded = true;
    float distance;
    private Vector3 velocity;
    
    void Update()
    {
        distance = Vector3.Distance(transform.position, Merch.transform.position);
        if ((AnimatorController.ShakingHands == true) && (distance < 1.2f))
        {
            GetComponent<MouseController>().enabled = false;
        }
        else if (AnimatorController.ShakingHands == false)
        {
            GetComponent<MouseController>().enabled = true;
        }
        isGrounded = controller.isGrounded;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        controller.Move(move * speed * Time.deltaTime);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            velocity.y = jumpheight;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
