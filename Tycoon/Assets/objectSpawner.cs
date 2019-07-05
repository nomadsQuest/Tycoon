using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objectSpawner : MonoBehaviour {

	public watering waterCan;
	public PlantingManager plantManager;
	public GameObject wateringCan;


	public GameObject plowPrefab;
	public Transform plow;

	public GameObject wateringCanPrefab;


	public Transform spawnPoint;

	public GameObject plowInstance;
	public GameObject wateringCanInstance;

	public GameObject[] seeds;



	public bool plowActive;
	public bool waterActive;

	public GameObject joint;




	//public Text plowText;

	public float dist;

	// Use this for initialization
	void Awake ()
	{
		plantManager = GameObject.Find ("plantManager").GetComponent<PlantingManager> ();
		waterCan = GameObject.Find ("WaterCan").GetComponent<watering> ();
		wateringCan = GameObject.Find ("WaterCan");
		joint = GameObject.Find ("armJoint");
	}
		

	void FixedUpdate ()
	{

		if (Input.GetMouseButtonDown (0))
		{
			StartCoroutine (placing ());
			//spawnPoint.Rotate (-30, 0, 0);
		}
		/*
		if (Input.GetMouseButtonUp (0))
		{
			//spawnPoint.Rotate (30, 0, 0);
		}
		*/

		float dist = Vector3.Distance (plow.position,this.transform.position);



		if (Input.GetKeyDown (KeyCode.Q))
			{
				//plowActive = false;
				//waterActive = false;
				//print ("destroyingPlow");

			if (plowActive != false)
			{
				destroyPlow ();
			}
			if (waterActive != false)
			{
				DestroyWaterCan ();
			}

			}


		if (dist <= 10)
		{
			if (Input.GetKeyDown (KeyCode.P) && plowActive != true)
			{
			plantManager.PlowingActive ();
			spawnPlow ();
			print ("spawningPlow");
			plowActive = true;
			
			}
		
		}


	}

	IEnumerator placing ()
	{
		joint.transform.Rotate (0, 0, 10);
		yield return new WaitForSeconds (0.1f);
		joint.transform.Rotate (0, 0, -10);
	}

		// Update is called once per frame
	 void spawnPlow () 
	{
		if (wateringCanInstance != null)
		Destroy (wateringCanInstance);

		//waterActive = false;
		plow.gameObject.SetActive (false);

		plantManager.waterReady = false;

		waterCan.hasSpawned = false;

		plantManager.isPlow = true;

		plowActive = true;

		plowInstance = Instantiate (plowPrefab, spawnPoint.position, spawnPoint.rotation);

		plowInstance.transform.parent = spawnPoint.transform;




	}

	public void spawnWateringCan () 
	{
		if (plowInstance != null)
		Destroy (plowInstance); 

		waterActive = true;

		wateringCan.SetActive (false);

		wateringCanInstance = Instantiate (wateringCanPrefab, spawnPoint.position, spawnPoint.rotation);

		wateringCanInstance.transform.parent = spawnPoint.transform;

		plowActive = false;
	}

	 void destroyPlow () 
	{
		plowActive = false;
		Destroy (plowInstance);
		plantManager.isPlow = false;
		plow.gameObject.transform.position = this.transform.position;
		plow.gameObject.SetActive (true);
	}

	public void DestroyWaterCan () 
	{
		print ("destroying watering can");
		waterActive = false;
		wateringCan.transform.position = transform.position;
		wateringCan.SetActive (true);
		waterCan.hasSpawned = false;
		Destroy (wateringCanInstance);
		plantManager.waterReady = false;


	}

	void spawnSeed ()
	{
		if (Input.GetKeyDown (KeyCode.Alpha1))
			Instantiate (seeds [0], transform.position, transform.rotation);
	}


}
