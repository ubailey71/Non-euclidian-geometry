using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalCamera : MonoBehaviour
{
    public Transform playerCamera;
    public Transform playerPortal;

    public Transform cameraPortal;

    void Update()
    {
        Vector3 playerOffset = playerCamera.position - playerPortal.position;
        transform.position = cameraPortal.position + playerOffset;
        
        float portalAngleDifference = Quaternion.Angle(cameraPortal.rotation, playerPortal.rotation);
        Quaternion portalRotationDiff = Quaternion.AngleAxis(portalAngleDifference, Vector3.up);
        Vector3 newCamDirection = portalRotationDiff * playerCamera.forward;
        transform.rotation = Quaternion.LookRotation(newCamDirection,Vector3.up);
    }
}

