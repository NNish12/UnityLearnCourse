using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 cameraTransform;
    private void Start()
    {
        cameraTransform = transform.position;
    }
    void LateUpdate()
    {
        transform.position = player.transform.position + cameraTransform;
    }
}
