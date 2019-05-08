using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroycars : MonoBehaviour {


	void OnTriggerEnter (Collider other)
	{
		print ("isColliding");
		if (other.gameObject.tag == "car")
			
			Destroy (other.gameObject);
	}

}
