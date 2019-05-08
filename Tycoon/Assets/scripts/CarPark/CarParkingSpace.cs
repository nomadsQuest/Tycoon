using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarParkingSpace : MonoBehaviour {



	public float speed = 10;

	private Transform target;
	private int wavepointIndex = 0;

	public bool hasParked;

	public freeparkingslots slots;

	private bool called = false;

	private bool call = false;


	void Start () 
	{
		
		slots = GameObject.Find ("numb").GetComponent<freeparkingslots> ();
		hasParked = false;

	}
	


	void OnTriggerEnter (Collider other)
	{

			//if (called != true)
			//{
				
			slots.carParked ();
			//called = true;
			
			//}



	}

	void OnTriggerExit (Collider other)
	{

			//if (call != true)
			//{
				slots.carLeft ();
				//call = true;

		//	}

	}
			
		



}
