using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalTextSetup : MonoBehaviour
{
    public Camera CameraB;

    public Material cameraMatB;

    public Camera CameraA;

    public Material cameraMatA;


    // Start is called before the first frame update
    void Start()
    {
        if(CameraB.targetTexture != null)
        {
            CameraB.targetTexture.Release();
        }

        CameraB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatB.mainTexture = CameraB.targetTexture;

        if (CameraA.targetTexture != null)
        {
            CameraA.targetTexture.Release();
        }

        CameraA.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatA.mainTexture = CameraA.targetTexture;
    }

}
