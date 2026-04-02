using UnityEngine;

public class PovorotX : MonoBehaviour
{
    public Transform playerBody;
    public Transform cameraTransform;
    public float cameraDistance = 4f;
    public float minDistance = 0.1f;
    public LayerMask obstacleLayer;
    
    private float speedVert = 2f;
    private float minVert = -65f;
    private float maxVert = 25f;
    private float rotationX;
    
    void Start()
    {
        if (cameraTransform == null)
            cameraTransform = Camera.main.transform;
        if (playerBody == null)
            playerBody = transform;
    }

    void Update()
    {
        rotationX -= Input.GetAxis("Mouse Y") * speedVert;
        rotationX = Mathf.Clamp(rotationX, minVert, maxVert);
        
        Vector3 cameraOffset = new Vector3(0, 4, -cameraDistance);
        Vector3 desiredCameraPos = playerBody.position + playerBody.rotation * Quaternion.Euler(rotationX, 0, 0) * cameraOffset;
        
        RaycastHit hit;
        Vector3 direction = desiredCameraPos - (playerBody.position + Vector3.up * 1);
        
        if (Physics.Raycast(playerBody.position + Vector3.up * 1, direction, out hit, cameraDistance, obstacleLayer))
        {
            float distance = Mathf.Max(hit.distance * 0.9f, minDistance);
            cameraTransform.position = (playerBody.position + Vector3.up * 1) + direction.normalized * distance;
        }
        else
        {
            cameraTransform.position = desiredCameraPos;
        }
        
        cameraTransform.LookAt(playerBody.position + Vector3.up * 1);
    }
}
