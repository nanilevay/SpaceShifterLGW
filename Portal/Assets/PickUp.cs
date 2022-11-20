using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{
	public Transform player;
	public float throwForce = 10;
	bool hasPlayer = false;
	bool beingCarried = false;
	public GameObject guide;

	void OnTriggerEnter(Collider other)
	{
		hasPlayer = true;
	}

	void OnTriggerExit(Collider other)
	{
		hasPlayer = false;
	}

	void Update()
	{
		if (beingCarried)
		{
			if (Input.GetMouseButtonDown(0))
			{
				this.GetComponent<Rigidbody>().isKinematic = false;
				this.GetComponent<Rigidbody>().useGravity = true;
				this.transform.parent = null;
				beingCarried = false;
				this.GetComponent<Rigidbody>().AddForce(player.forward * throwForce);
			}
		}
		else
		{
			if (Input.GetMouseButtonDown(0) && hasPlayer)
			{
				this.GetComponent<Rigidbody>().isKinematic = true;
				this.GetComponent<Rigidbody>().useGravity = false;
				this.transform.position = guide.transform.position;
				this.transform.rotation = guide.transform.rotation;
				this.transform.parent = guide.transform;
				beingCarried = true;
			}
		}
	}
}