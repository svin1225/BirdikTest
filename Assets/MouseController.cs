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
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        rotationX -= Input.GetAxis("Mouse Y") * speedVert;
        rotationX = Mathf.Clamp(rotationX, minVert, maxVert);

        float delta = Input.GetAxis("Mouse X") * speedHor;
        rotationY = transform.localEulerAngles.y + delta;

        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
