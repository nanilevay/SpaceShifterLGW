using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortalCamera : MonoBehaviour
{

    public Transform player;
    public GameObject headtracker_LEFT;
    public GameObject headtracker_RIGHT;
    public GameObject CameraB_RIGHT;
    public GameObject CameraB_LEFT;
    public Vector3 CameraB_Pos;

    // LateUpdate is called once after each frame
    void LateUpdate()
    {
        //Parenting B Cameras to player movements
        transform.position = player.transform.TransformPoint(CameraB_Pos.x, player.position.y, CameraB_Pos.z);

        //Parenting B Cameras to OVR left and right cameras roation
        //Left
        CameraB_LEFT.transform.eulerAngles = new Vector3(headtracker_LEFT.transform.eulerAngles.x, headtracker_LEFT.transform.eulerAngles.y, headtracker_LEFT.transform.eulerAngles.z);

        //Right
        CameraB_RIGHT.transform.eulerAngles = new Vector3(headtracker_RIGHT.transform.eulerAngles.x, headtracker_RIGHT.transform.eulerAngles.y, headtracker_RIGHT.transform.eulerAngles.z);
    }

}
