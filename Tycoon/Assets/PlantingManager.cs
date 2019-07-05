using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantingManager : MonoBehaviour {

	public playerInventory pInventory;

	public bool isPlow;
	public bool waterReady;

	public bool isBerrySeed;
	public bool isCarrotSeed;
	public bool isWeedSeed;

	//public GameObject seed;
	// Use this for initialization
	void Start () {
		pInventory = GameObject.Find ("player").GetComponent<playerInventory> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Alpha1))
		{
			if (pInventory.blueBerrySeeds >= 1)
			{
			isBerrySeed = true;
			print ("berrySeedReady");
			//seed.GetComponent<Renderer> ().material.color = Color.blue;
			//seed.SetActive (true);
			}
		}

		if (Input.GetKeyDown (KeyCode.Alpha2))
		{
			if (pInventory.carrotSeeds >= 1)
			{
			isCarrotSeed = true;
			print ("carrotSeedReady");
			}
		}

		if (Input.GetKeyDown (KeyCode.Alpha3))
		{
			if (pInventory.weedSeeds >= 1)
			{
			isWeedSeed = true;
			print ("weedSeedReady");
			}
		}
			

		if (Input.GetKeyDown (KeyCode.N))
		{
			waterReady = true;
			print ("waterReady");
		}
			

		if (Input.GetKeyDown (KeyCode.M))
		{
			isPlow = true;
			print ("plowReady");
		}


			
	}


	public void PlowingActive () 
	{
		isPlow = true;
	}

	public void ActivateWater()
	{
		print ("waterReady");
		waterReady = true;

	}


}
