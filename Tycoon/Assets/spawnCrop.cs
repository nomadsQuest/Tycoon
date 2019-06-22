using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCrop : MonoBehaviour {

	public watering waterObj;

	public float growTime = 2;
	public float waterTime = 10;

	public GameObject seedPrefab;
	public GameObject seed;

	public Material normalGround;
	public Material fertilizedGround;
	public Material wateredGround;

	public Renderer rend;

	public GameObject harvestParticle;


	public GameObject[] growthStages;

	public GameObject weed1;
	public GameObject weed2;
	public GameObject weed3;

	public bool cropReady;
	public bool isFertile;


	public string spawnerName;

	// Use this for initialization
	void Start () 
	{

		waterObj = GameObject.Find ("waterSupply").GetComponent<watering> ();
		rend = GetComponent<Renderer> ();
		rend.sharedMaterial = normalGround;
		spawnerName = gameObject.name;

	}
	
	// Update is called once per frame
	void Update () 
	{
		
			

		if (Input.GetMouseButtonDown (1)) 
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if(Physics.Raycast (ray, out hit))
			{
				if(hit.transform.name == spawnerName)
				{
					print ("detectedraycast");
					Fertilize ();
				}
			}
		}
	}

	void OnMouseDown ()
	{
		if (waterObj.waterReady != false)
		{
			print ("wateredTile");
			StartCoroutine (wateredGroundTimer ());
			waterObj.waterReady = false;

		}
		if (cropReady != true  && isFertile != false)
		{
			seed = Instantiate (seedPrefab, transform.position, transform.rotation);
			StartCoroutine (Grow ()); 
		}

		if (cropReady != false)
		{
			isFertile = false;
			rend.sharedMaterial = normalGround;
			Destroy (weed3);
			print ("harvested!");
			cropReady = false;
			GameObject harvestEffect = (GameObject)Instantiate(harvestParticle, transform.position, Quaternion.Euler (-90, 0, 0));
			Destroy(harvestEffect, 1f);
		}


	}

	IEnumerator Grow ()
	{
		
		yield return new WaitForSeconds (growTime);
		Destroy (seed);
		weed1 = Instantiate (growthStages[0], transform.position, transform.rotation);
		yield return new WaitForSeconds (growTime);
		Destroy (weed1);
		weed2 = Instantiate (growthStages[1], transform.position, transform.rotation);
		yield return new WaitForSeconds (growTime);
		Destroy (weed2);
		weed3 = Instantiate (growthStages[2], transform.position, transform.rotation);
		cropReady = true;

	}

	void Fertilize ()
	{
		print ("rightclick");
		rend.sharedMaterial = fertilizedGround;
		isFertile = true;
	}



	IEnumerator wateredGroundTimer ()
	{
		growTime = growTime - 1;
		rend.sharedMaterial = wateredGround;
		yield return new WaitForSeconds (10);
		growTime = growTime + 1;
		rend.sharedMaterial = normalGround;

	}

}
