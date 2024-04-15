using UnityEngine;
using Cinemachine;

public class CinemachinePlayerFollower : MonoBehaviour
{
    public Transform playerTransform; // Reference to the player's transform
    public CinemachineVirtualCamera virtualCamera; // Reference to the Cinemachine virtual camera

    private void Start()
    {
        // Set the Follow target of the virtual camera to the player's transform
        if (virtualCamera != null && playerTransform != null)
        {
            virtualCamera.Follow = playerTransform;
        }
    }

    private void Update()
    {
        // Update the rotation of the virtual camera to match the player's rotation
        if (virtualCamera != null && playerTransform != null)
        {
            virtualCamera.transform.rotation = playerTransform.rotation;
        }
    }
}