using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solarPanel : MonoBehaviour {


	public daynightcycle cycle;
	public solarStorage energy;

	public float solarGeneration = 0.5f;

	// Use this for initialization
	void Start ()
	{
		cycle = GameObject.Find ("sun").GetComponent<daynightcycle> ();
	
		energy = GameObject.Find ("energyStorage").GetComponent<solarStorage> ();




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
		energy.Watts += 1f;
	}

	void EnergyOff ()
	{
		
	}


}
