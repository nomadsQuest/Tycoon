﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solarStorage : MonoBehaviour {

	public float Watts;
	public float maxWatts = 1000;
	public Material energyMaterial;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Watts >= maxWatts)
			Watts = maxWatts;


	
		if (Watts > 0)
		{
			transform.GetChild (0).transform.GetComponent<Renderer> ().sharedMaterial = energyMaterial;
		}else
		{
			transform.GetChild (0).transform.GetComponent<Renderer> ().material.color = Color.black;
		}
			

		if (Watts > 200)
		{
			transform.GetChild (1).transform.GetComponent<Renderer> ().sharedMaterial = energyMaterial;
		}else
		{
			transform.GetChild (1).transform.GetComponent<Renderer> ().material.color = Color.black;
		}

		if (Watts > 400)
		{
			transform.GetChild (2).transform.GetComponent<Renderer> ().sharedMaterial = energyMaterial;
		}else
		{
			transform.GetChild (2).transform.GetComponent<Renderer> ().material.color = Color.black;
		}

		if (Watts > 600)
		{
			transform.GetChild (3).transform.GetComponent<Renderer> ().sharedMaterial = energyMaterial;
		}else
		{
			transform.GetChild (3).transform.GetComponent<Renderer> ().material.color = Color.black;
		}

		if (Watts > 800)
		{
			transform.GetChild (4).transform.GetComponent<Renderer> ().sharedMaterial = energyMaterial;
		}else
		{
			transform.GetChild (4).transform.GetComponent<Renderer> ().material.color = Color.black;
		}
	}
}