using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointtomoveraycast : MonoBehaviour {

	public Transform objectToPlace;
	public Camera placingCam;
	public LayerMask mask;

	// Use this for initialization
	void Start () 
	{
	

	}
	
	// Update is called once per frame
	void Update () 
	{
	

		Ray ray = placingCam.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 10000, mask, QueryTriggerInteraction.Ignore))
		{
			objectToPlace.position = hit.point;
			objectToPlace.rotation = Quaternion.FromToRotation (Vector3.up, hit.normal);
		}
	}
}
