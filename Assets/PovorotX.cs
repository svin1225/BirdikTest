using UnityEngine;

public class PovorotX : MonoBehaviour
{
    public Transform playerBody;
    public Transform cameraTransform;
    public float cameraDistance = 2f;
    public float minDistance = 0.1f;
    public LayerMask obstacleLayer;
    
    void Start()
    {
        if (cameraTransform == null)
            cameraTransform = Camera.main.transform;
        if (playerBody == null)
            playerBody = transform;
    }

    void Update()
    {
        Vector3 cameraOffset = new Vector3(0, 2, -cameraDistance);
        Vector3 desiredCameraPos = playerBody.position + playerBody.rotation * cameraOffset;
        
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
