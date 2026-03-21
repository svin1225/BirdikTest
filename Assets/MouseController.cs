using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    private float speedHor = 2f;
    private float speedVert = 2f;

    private float minVert = -45f;
    private float maxVert = 45f;

    private float rotationX;
    private float rotationY;
    
    public Transform playerBody;
    public Transform cameraTransform;
    public float cameraDistance = 0.2f;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
        if (cameraTransform == null)
            cameraTransform = Camera.main.transform;
        if (playerBody == null)
            playerBody = transform;
    }

    void Update()
    {
        rotationX -= Input.GetAxis("Mouse Y") * speedVert;
        rotationX = Mathf.Clamp(rotationX, minVert, maxVert);

        float delta = Input.GetAxis("Mouse X") * speedHor;
        rotationY += delta;

        // Поворачиваем игрока только по Y
        playerBody.localEulerAngles = new Vector3(0, rotationY, 0);
        
        // Камера сзади игрока и смотрит на него (вид от 3 лица)
        Vector3 cameraOffset = new Vector3(0, 1, -cameraDistance);
        cameraTransform.position = playerBody.position + Quaternion.Euler(rotationX, rotationY, 0) * cameraOffset;
        cameraTransform.LookAt(playerBody.position + Vector3.up * 1);
    }
}
