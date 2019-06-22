using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointtomoveraycast : MonoBehaviour {

	public Transform objectToPlace;
	public Camera placingCam;
	public LayerMask mask;
	public float offsety = 0.5f;



	public bool placement;
	public bool isRotate;


	// Use this for initialization
	void Start () 
	{
		

	}
	
	// Update is called once per frame
	void Update () 
	{
		
		
		if (Input.GetMouseButton (0))
		{
			placement = true;
			task ();
		}
			

		if (placement != true)
		{


		Ray ray = placingCam.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 10000, mask, QueryTriggerInteraction.Ignore))
		{
			objectToPlace.position = hit.point;
			objectToPlace.position = new Vector3 (hit.point.x, hit.point.y + offsety, hit.point.z);
			//objectToPlace.rotation = Quaternion.FromToRotation (Vector3.up, hit.normal);
		}

			if (Input.GetKeyDown (KeyCode.RightArrow))
				transform.Rotate(new Vector3(0, 90, 0), Space.Self);
		} 



	}

	void task ()
	{
		


	}

}
