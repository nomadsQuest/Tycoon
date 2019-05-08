using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spotlightscrip : MonoBehaviour 
{
	private Light light;
	public daynightcycle cycle;

	// Use this for initialization
	void Start () 
	{
		cycle = GameObject.Find ("sun").GetComponent<daynightcycle> ();
		light = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (cycle.isNight == true)
			light.enabled = true;
		
		if (cycle.isNight == false)
			light.enabled = false;
	}
}
