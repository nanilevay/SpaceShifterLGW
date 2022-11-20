using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class followView : MonoBehaviour
{
    public Transform playerCamera;
    public Transform portal;
    public Transform otherPortal;

    void Update()
    {
        Vector3 playerOffset = playerCamera.position - otherPortal.position;
        transform.position = portal.position + playerOffset;

        float angularDiff = Quaternion.Angle(portal.rotation, otherPortal.rotation);

        Quaternion portalRotDiff = Quaternion.AngleAxis(angularDiff, Vector3.up);
        Vector3 newCameraDir = portalRotDiff * playerCamera.forward;

        transform.rotation = Quaternion.LookRotation(newCameraDir, Vector3.up);
    }
}
