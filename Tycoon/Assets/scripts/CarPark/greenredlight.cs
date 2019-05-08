using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenredlight : MonoBehaviour {

	public Renderer rend;

	// Use this for initialization
	void Start () 
	{
		rend = GetComponent<Renderer> ();
		transform.GetComponent<Renderer> ().material.color = Color.green;
		//Invoke ("colorRed", 1);
	}




	void OnTriggerEnter (Collider other)
	{
		rend.material.color = Color.red;

	}


	void OnTriggerExit (Collider other)
	{
		rend.material.color = Color.green;
	}

		

	

}
