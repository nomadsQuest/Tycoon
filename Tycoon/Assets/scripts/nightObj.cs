using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nightObj : MonoBehaviour {

	public daynightcycle cycle;
	public Light light;


	// Use this for initialization
	void Start () 
	{
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
		light.enabled = true;
	}

	void lightOff ()
	{
		light.enabled = false;
	}
}
