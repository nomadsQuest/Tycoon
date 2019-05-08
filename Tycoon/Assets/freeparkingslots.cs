using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class freeparkingslots : MonoBehaviour {



	public TextMeshPro txtpro;
	public int car = 6;

	// Use this for initialization
	void Start () 
	{
		txtpro.text = "" + car.ToString ();
		//Invoke ("carLeft", 1f);

	}
	
	// Update is called once per frame
	public void carParked () 
	{
		//print ("carleftworking");
		car--;
		txtpro.text = "" + car.ToString();
	}

	public void carLeft () 
	{	
		//print ("carleftworking");
		car++;
		txtpro.text = "" + car.ToString ();
	}
}
