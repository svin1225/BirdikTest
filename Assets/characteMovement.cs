using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class characteMovement : MonoBehaviour
{
    private bool povorot = true;
    public GameObject Merch;
    public GameObject Dialog;
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
            if (povorot == true)
            {
                Debug.Log("поворот игрока = " + transform.eulerAngles);
                Debug.Log("поворот торговца = " + Merch.transform.eulerAngles);
                //transform.LookAt (Merch.transform.position);
                Debug.Log("изменненый поворот игрока = " + transform.eulerAngles);
                //transform.eulerAngles = Merch.transform.eulerAngles * -1;
            }
            povorot = false;
            //transform.rotation = Quaternion.Euler(0, 90, 0);
            GetComponent<MouseController>().enabled = false;
            Dialog.SetActive(true);
            UnityEngine.Cursor.visible = true;
            UnityEngine.Cursor.lockState = CursorLockMode.None;
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
