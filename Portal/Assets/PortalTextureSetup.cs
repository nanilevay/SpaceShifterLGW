using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour {

	public Camera cameraA;
	public Camera cameraB;

	public Camera cameraBL;
	public Camera cameraBR;

	public Material cameraMatA;
	public Material cameraMatBR;
	public Material cameraMatBL;

	// Use this for initialization
	void Start () {
		if (cameraA.targetTexture != null)
		{
			cameraA.targetTexture.Release();
		}
		cameraA.targetTexture = new RenderTexture(1920, 1832, 24);
		cameraMatA.mainTexture = cameraA.targetTexture;

		if (cameraB.targetTexture != null)
		{
			cameraB.targetTexture.Release();
		}
		cameraB.targetTexture = new RenderTexture(1920, 1832, 24);
		cameraMatBR.mainTexture = cameraB.targetTexture;


		if (cameraBL.targetTexture != null)
		{
			cameraBL.targetTexture.Release();
		}
		cameraBL.targetTexture = new RenderTexture(1920, 1832, 24);
		cameraMatBL.mainTexture = cameraBL.targetTexture;

		if (cameraBR.targetTexture != null)
		{
			cameraBR.targetTexture.Release();
		}
		cameraBR.targetTexture = new RenderTexture(1920, 1832, 24);
		cameraMatBR.mainTexture = cameraBR.targetTexture;
	}
	
}
