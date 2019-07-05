using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class farmingRaycast : MonoBehaviour {

	public Camera cam;
	public float range = 200;
	public spawnCrop crop;

	public playerInventory inventory;


	public bool isCalled;

	//public LayerMask mask;
	// Use this for initialization
	void Start () 
	{
		inventory = GameObject.Find ("player").GetComponent<playerInventory> ();
		cam = Camera.main;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		RaycastHit hit;
	
		//Ray ray = new Ray (cam.transform.position, Vector3.forward);

		if (Input.GetMouseButtonDown (0))
		{	
		if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
		{
			print (hit.collider.name);

			crop = hit.collider.gameObject.GetComponent<spawnCrop>();

			if (crop != false)
			{
				crop.planting();
				print ("isWorking");
			}
			
				if (hit.collider.name == "berrySeeds" && isCalled != true && inventory.money >= 3)
				{
					isCalled = true;
					inventory.addBerry ();
					StartCoroutine (isCalledState ());
				}
					

				if (hit.collider.name == "carrotSeeds" && isCalled != true && inventory.money >= 2)
				{
					isCalled = true;
					inventory.addCarrot ();
					StartCoroutine (isCalledState ());
				}

				if (hit.collider.name == "weedSeeds" && isCalled != true && inventory.money >= 1)
				{
					isCalled = true;
					inventory.addWeed ();
					StartCoroutine (isCalledState ());
				}

		}



		/*else
		{
			//Vector3 forward = transform.TransformDirection(Vector3.forward) * 1000;
			//Debug.DrawLine(transform.position,forward, Color.green);
		}

		//Vector3 forward = transform.TransformDirection(Vector3.forward) * 1000;
		

		
		if(Physics.Raycast (ray, out hit))
		{
			print (hit.collider.gameObject.name);
			Debug.DrawLine(transform.position, hit.point, Color.red);
		}else
		{

		}

		if (Input.GetMouseButtonDown (0)) 
		{


		}
		*/
	}
	}

	IEnumerator isCalledState ()
	{
		yield return new WaitForSeconds(0.25f);
		isCalled = false;

	}
}
