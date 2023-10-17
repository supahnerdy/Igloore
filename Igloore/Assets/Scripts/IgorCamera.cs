using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform player;  // Reference to the player's transform
    public Vector3 offset = new Vector3(0f, 2f, -5f);  // Offset from the player
    public float rotationSpeed = 5f;  // Speed of camera rotation
    public float maxDistance = 10f;   // Maximum distance the camera can be from the player

    private void Start()
    {
        // this.transform.parent = player.transform;
    }

    void LateUpdate()
    {
        if (player != null)
        {
            // Calculate the desired position of the camera
            Vector3 desiredPosition = player.position + -player.forward * offset.z + player.up * offset.y;

            // Smoothly interpolate between the current camera position and the desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, rotationSpeed * Time.deltaTime);

            // Set the position of the camera to the smoothed position
            transform.position = smoothedPosition;

            // Check for obstacles between the camera and player
            RaycastHit hit;
            if (Physics.Raycast(player.position, smoothedPosition - player.position, out hit, maxDistance))
            {
                // If an obstacle is detected, adjust the camera position to avoid it
                transform.position = hit.point;
            }
            else
            {
                // No obstacles, update the camera's position
                transform.position = smoothedPosition;
            }
            // Make the camera look at the player
            transform.LookAt(player);
        }
    }

}


