using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daynightcycle : MonoBehaviour {

	public float dayDuration = 1f;
	public bool isNight = false;
	public bool hotSun = false;




	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.RotateAround (Vector3.zero, Vector3.right, dayDuration * Time.deltaTime);
		transform.LookAt (Vector3.zero);

	
	
	}


	void OnTriggerExit (Collider other)
	{

		if (other.gameObject.name == "hotSun" )
		{
			hotSun = true;
		}

		if (other.gameObject.name == "normalSun" )
		{
			hotSun = false;
		}


		if (other.gameObject.name == "day" || other.gameObject.name == "night")
		{
		isNight = !isNight;
		print ("Collided!");
		}

	}

	void FixedUpdate()
	{

		/*
	if (transform.rotation.x < 10f)
	{
		isNight = true;
	} 
*/

	

	//if (transform.rotation.x >= 0f)
	//{
	//	isNight = false;
	//	return;
	//}



	}



}
