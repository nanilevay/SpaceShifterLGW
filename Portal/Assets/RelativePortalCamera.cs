using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelativePortalCamera : MonoBehaviour
{

    //Referring to the dummy cameras placed inside LeftEyeAnchor & RightEyeAnchor used as position / rotation trackers
    public GameObject Player;
    public Camera MainCamera_L;
    public Camera MainCamera_R;

    //Pairs of cameras used for the renderTexture
    public GameObject PortalCamera_Holder;
    public Camera PortalCamera_L;
    public Camera PortalCamera_R;

    //Portals
    public Transform Source;
    public Transform Destination;

    //Debug hud
    public static Text debugText_PosCompare;
    public static Text debugText_EulerRightCompare;
    public static Text debugText_EulerLeftCompare;
    public static Text debugText_Headset;




    void Start()
    {
        Application.onBeforeRender += OnBeforeRender;

        

    }





    // OneBeforeRender is used for better pos / rotation tracking.
    // Putting all the tracking stuff inside should kill all lags.
    // https://bit.ly/2OTVi65
    void OnBeforeRender()
    {


        /*
        ----------
        TRACKING & CLIP
        ----------    
        */

        // Holder position
        Vector3 cameraPositionInSourceSpace_L = Source.InverseTransformPoint(MainCamera_L.transform.position);
        PortalCamera_Holder.transform.position = Destination.TransformPoint(cameraPositionInSourceSpace_L);

        // Left rotation
        Quaternion cameraRotationInSourceSpace_L = Quaternion.Inverse(Source.rotation) * MainCamera_L.transform.rotation;
        PortalCamera_L.transform.rotation = Destination.rotation * cameraRotationInSourceSpace_L;

        // Right rotation
        // Vector3 cameraPositionInSourceSpace_R = Source.InverseTransformPoint(MainCamera_R.transform.position);
        // PortalCamera_R.transform.position = Destination.TransformPoint(cameraPositionInSourceSpace_R);
        Quaternion cameraRotationInSourceSpace_R = Quaternion.Inverse(Source.rotation) * MainCamera_R.transform.rotation;
        PortalCamera_R.transform.rotation = Destination.rotation * cameraRotationInSourceSpace_R;

        // Cliplane projection matrix
        // All the code relative to this part come from https://bit.ly/2Kc6VGN and here https://bit.ly/2WUpwZx
        Vector4 clipPlaneB_L = CameraSpacePlane(PortalCamera_L.GetComponent<Camera>(), Destination.transform.position, Destination.transform.forward * -1, 1.0f);
        Matrix4x4 projectionB_L = MainCamera_L.GetComponent<Camera>().GetStereoProjectionMatrix(Camera.StereoscopicEye.Left);
        CalculateObliqueMatrix(ref projectionB_L, clipPlaneB_L);
        PortalCamera_L.GetComponent<Camera>().projectionMatrix = MainCamera_L.GetComponent<Camera>().CalculateObliqueMatrix(clipPlaneB_L);

        Vector4 clipPlaneB_R = CameraSpacePlane(PortalCamera_R.GetComponent<Camera>(), Destination.transform.position, Destination.transform.forward * -1, 1.0f);
        Matrix4x4 projectionB_R = MainCamera_R.GetComponent<Camera>().GetStereoProjectionMatrix(Camera.StereoscopicEye.Right);
        CalculateObliqueMatrix(ref projectionB_R, clipPlaneB_R);
        PortalCamera_R.GetComponent<Camera>().projectionMatrix = MainCamera_R.GetComponent<Camera>().CalculateObliqueMatrix(clipPlaneB_R);


        
    }




    /*
    ----------
    FUNCTIONS
    ----------
    */

    // Extended sign: returns -1, 0 or 1 based on sign of a
    private static float sgn(float a)
    {
        if (a > 0.0f) return 1.0f;
        if (a < 0.0f) return -1.0f;
        return 0.0f;
    }

    // Given position/normal of the plane, calculates plane in camera space.
    private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
    {
        Vector3 offsetPos = pos + normal;
        Matrix4x4 m = cam.worldToCameraMatrix;
        Vector3 cpos = m.MultiplyPoint(offsetPos);
        Vector3 cnormal = m.MultiplyVector(normal).normalized * sideSign;
        return new Vector4(cnormal.x, cnormal.y, cnormal.z, -Vector3.Dot(cpos, cnormal));
    }

    // Adjusts the given projection matrix so that near plane is the given clipPlane
    // clipPlane is given in camera space. See article in Game Programming Gems 5 and
    // http://aras-p.info/texts/obliqueortho.html
    private static void CalculateObliqueMatrix(ref Matrix4x4 projection, Vector4 clipPlane)
    {
        Vector4 q = projection.inverse * new Vector4(
            sgn(clipPlane.x),
            sgn(clipPlane.y),
            1.0f,
            1.0f
        );
        Vector4 c = clipPlane * (2.0F / (Vector4.Dot(clipPlane, q)));
        // third row = clip plane - fourth row
        projection[2] = c.x - projection[3];
        projection[6] = c.y - projection[7];
        projection[10] = c.z - projection[11];
        projection[14] = c.w - projection[15];
    }
}