using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daynightcycle : MonoBehaviour {

	public float dayDuration = 1f;
	public bool isNight = false;


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

	void FixedUpdate()
	{


	if (transform.rotation.x < 1f)
	{
		isNight = true;
		} else{
			isNight = false;
		}
			

	//if (transform.rotation.x >= 0f)
	//{
	//	isNight = false;
	//	return;
	//}



	}
}
