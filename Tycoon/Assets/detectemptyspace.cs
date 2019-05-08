using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectemptyspace : MonoBehaviour {


	public parkingList car;
	public int trans;
	// Use this for initialization
	void Start () 
	{
		car = GameObject.Find ("ParkingList").GetComponent<parkingList>();

	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject)
		{
			//print("isColliding");
			//Destroy (other.gameObject);
			car.RemoveFromList (trans);
			//print ("car");
			//Destroy (other.gameObject);

		}
	}

	void OnTriggerExit(Collider other) 
	{
		if(other.gameObject)
		{
			//print ("isExitingCollider");
			//Destroy (other.gameObject);
			car.AddToList (trans);
			//print ("car");
			//Destroy (other.gameObject);

		}
		}
	
}
