using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantingManager : MonoBehaviour {

	public playerInventory pInventory;

	public bool isPlow;
	public bool waterReady;

	public bool isSeed;

	public Crop currentCrop;
	public Crop[] crops;

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
			UpdateCrop (crops [0]);
			print ("berrySeedReady");
				isSeed = true;
			}
		}

		if (Input.GetKeyDown (KeyCode.Alpha2))
		{
			if (pInventory.carrotSeeds >= 1)
			{
			UpdateCrop (crops [1]);
				isSeed = true;
			print ("carrotSeedReady");
			}
		}

		if (Input.GetKeyDown (KeyCode.Alpha3))
		{
			if (pInventory.weedSeeds >= 1)
			{
			UpdateCrop (crops [2]);
				isSeed = true;
			print ("weedSeedReady");
			}
		}

		if (Input.GetKeyDown (KeyCode.Alpha4))
		{
			//if (pInventory.weedSeeds >= 1)
		//	{
				UpdateCrop (crops [3]);
				isSeed = true;
				print ("weedSeedReady");
			//}
		}

		if (Input.GetKeyDown (KeyCode.Alpha5))
		{
			//if (pInventory.weedSeeds >= 1)
			//{
				UpdateCrop (crops [4]);
				isSeed = true;
				print ("weedSeedReady");
			//}
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

	public void UpdateCrop (Crop newCrop)
	{
		currentCrop = newCrop;
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
