using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroycustomers : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) 
	{
		if (other.tag == "customer" || other.tag == "Player")
			Destroy (other.gameObject);
	}
}
