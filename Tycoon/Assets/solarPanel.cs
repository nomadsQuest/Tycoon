using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solarPanel : MonoBehaviour {


	public daynightcycle cycle;


	public float solarGeneration = 0.5f;

	// Use this for initialization
	void Start ()
	{
		cycle = GameObject.Find ("sun").GetComponent<daynightcycle> ();
	





	}

	
	// Update is called once per frame
	void Update () 
	{
	
	if (cycle.isNight != false)
		EnergyOff();

	if (cycle.isNight != true)
		EnergyOn ();
	
	}

	void EnergyOn ()
	{

	}

	void EnergyOff ()
	{
		 += 0;
	}


}
