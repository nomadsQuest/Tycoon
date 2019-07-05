using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class watering : MonoBehaviour {

	public bool waterReady;
	public Transform player;

	public bool isReady;

	public Text buttonText;

	public PlantingManager plantManager;
	public objectSpawner spawner;

	public float dist;

	public bool hasSpawned;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("player").transform;
		plantManager = GameObject.Find ("plantManager").GetComponent<PlantingManager> ();
		spawner = GameObject.Find ("player").GetComponent<objectSpawner> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float dist = Vector3.Distance (player.position,transform.position);

		if (dist <= 5f)
		{
			isReady = true;
		}else
		{
			isReady = false;
		}
			
		if (isReady != false)
		{
			buttonText.text = ("Y");

			if (Input.GetKeyDown(KeyCode.Y))
			{
				hasSpawned = true;
				plantManager.ActivateWater ();	
				spawner.spawnWateringCan ();
			}
		}else
		{
			buttonText.text = ("");
		}
	
	}

	void OnMouseDown ()
	{
		print ("waterReady");
		waterReady = true;

	}

	public void ActivateWater()
	{
		print ("waterReady");
		waterReady = true;

	}

}
