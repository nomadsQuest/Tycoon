using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activatelocations : MonoBehaviour {



	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) 
	{
		if (other.gameObject)
		{
			print (other.name);
			gameObject.SetActive (false);
		}

		
	}
}
