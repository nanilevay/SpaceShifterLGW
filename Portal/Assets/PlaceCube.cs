using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCube : MonoBehaviour
{
	public GameObject player;

	public GameObject teleporter;


	void OnTriggerStay(Collider other)
	{
		if (other.tag == "cube")
		{

			if (Input.GetMouseButtonDown(1))
			{
				Debug.Log("working");
				//
				other.GetComponent<Rigidbody>().isKinematic = false;
				other.transform.parent = null;
				//
				other.transform.position = this.transform.position;

				player.transform.position = teleporter.transform.position;

			}
		}
	}

}
