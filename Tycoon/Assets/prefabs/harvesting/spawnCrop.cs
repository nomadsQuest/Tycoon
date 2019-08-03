using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCrop : MonoBehaviour {

	//public plow plowing;
	//public watering waterObj;

	public Crop crop;



	public PlantingManager plantManager;
	public CropInventory inventory;
	public playerInventory pInventory;


	private float growTime;
	public float minGrow = 5;
	public float maxGrow = 10;

	public float waterTime = 10;

	public GameObject[] seedPrefab;
	public GameObject seed;

	public Material normalGround;
	public Material fertilizedGround;
	public Material wateredGround;

	public Color hoverColor;

	public Renderer rend;

	public GameObject harvestParticle;


	public GameObject stage1;
	public GameObject stage2;
	public GameObject stage3;

	public bool cropReady;
	public bool isFertile;
	public bool cropActive;


	public string spawnerName;

	public Camera cam;

	public int cropType;
	public bool hasCrop;

	// Use this for initialization

	void Awake ()
	{
		plantManager = GameObject.Find ("plantManager").GetComponent<PlantingManager> ();
		inventory = GameObject.Find ("Inventory").GetComponent<CropInventory> ();
		pInventory = GameObject.Find ("player").GetComponent<playerInventory> ();
	}

	void Start () 
	{

	

		cam = Camera.main;

		rend = this.GetComponent<Renderer> ();

		//normalGround = new Color (168, 84, 50);
		//fertilizedGround = new Color (224, 75, 0);
		//wateredGround = new Color (156, 61, 37);

		rend.sharedMaterial = normalGround;
		spawnerName = gameObject.name;
		hoverColor = Color.blue;
	}

	/*
	void OnMouseEnter()
	{
		if (plantManager.isPlow != false && isFertile != true)
		{
		rend.sharedMaterial = hoverColor;

		} 
	}

	void OnMouseExit()
	{
		if (isFertile != true)
		rend.sharedMaterial = normalGround; 
	}
	*/

	public void planting ()
	{
		if (plantManager.isPlow == true)
		{	
			Fertilize ();
			print ("hasFertilized");
			//plantManager.isPlow = false; is called when equipping the tool

		}
			
		if (plantManager.isSeed != false && cropReady != true && cropActive != true && isFertile != false && plantManager.waterReady != true)
		{
			crop = plantManager.currentCrop;
			pInventory.subtractBerry();
			seed = Instantiate (crop.seed, transform.position, transform.rotation);
			StartCoroutine (GrowCrop ());
			plantManager.isSeed = false;
		}


		if (plantManager.waterReady != false)
		{
			print ("wateredTile");
			StartCoroutine (wateredGroundTimer ());
			//plantManager.waterReady = false;
		}

		if (cropReady != false)
		{
			cropActive = false;
			isFertile = false;
			rend.sharedMaterial = normalGround;
			Destroy (stage3);
			print ("harvested!");
			inventory.locate (cropType);
			cropReady = false;
			GameObject harvestEffect = (GameObject)Instantiate(harvestParticle, transform.position, Quaternion.Euler (-90, 0, 0));
			Destroy(harvestEffect, 1f);
		}

		
	}

	IEnumerator GrowCrop ()
	{
		
		crop = plantManager.currentCrop;
		cropActive = true;
		growTime = Random.Range (minGrow, maxGrow);
		yield return new WaitForSeconds (growTime);
		Destroy (seed);
		stage1 = Instantiate (crop.growth[0], transform.position, transform.rotation);
		yield return new WaitForSeconds (growTime);
		Destroy (stage1);
		stage2 = Instantiate (crop.growth[1], transform.position, transform.rotation);
		yield return new WaitForSeconds (growTime);
		Destroy (stage2);
		stage3 = Instantiate (crop.growth[2], transform.position, transform.rotation);
		cropReady = true;

	}



	void Fertilize ()
	{
		print ("isFertilized");
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
