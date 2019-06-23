using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nightObj : MonoBehaviour {

	public daynightcycle cycle;
	public solarPanel panel;
	public Light light;


	// Use this for initialization
	void Start () 
	{
		panel = GameObject.Find ("solarEnergy").GetComponent<solarEnergy> ();
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
		if (panel.watts > 0) {
			light.enabled = true;
			panel.watts = panel.watts - 0.45f;
		} else
			light.enabled = false;
			
	}

	void lightOff ()
	{
		light.enabled = false;
	}
}
