using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watering : MonoBehaviour {

	public bool waterReady;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	
	}

	void OnMouseDown ()
	{
		print ("waterReady");
		waterReady = true;



	}
}
