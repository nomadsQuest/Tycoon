using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nightObj : MonoBehaviour {

	public daynightcycle cycle;
	public solarStorage storage;
	public Light light;


	// Use this for initialization
	void Start () 
	{
		storage = GameObject.Find ("energyStorage").GetComponent<solarStorage> ();
		cycle = GameObject.Find ("sun").GetComponent<daynightcycle> ();

		if (light == null)
			return;


	}
	
	// Update is called once per frame
	void Update () 
	{

		if (cycle.isNight != false)
			lightOn ();

		if (cycle.isNight != true)
			lightOff();

	}

	void lightOn ()
	{
		if (storage.Watts > 0f) 
		{
			light.enabled = true;
			storage.Watts -= 2f;
		} else
			light.enabled = false;
			
	}

	void lightOff ()
	{
		light.enabled = false;
	}
}
