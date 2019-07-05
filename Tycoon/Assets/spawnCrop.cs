using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCrop : MonoBehaviour {

	//public plow plowing;
	//public watering waterObj;
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


	public GameObject[] berryStages;
	public GameObject[] carrotStages;
	public GameObject[] weedStages;

	public GameObject weed1;
	public GameObject weed2;
	public GameObject weed3;

	public bool cropReady;
	public bool isFertile;
	public bool cropActive;


	public string spawnerName;

	public Camera cam;

	public int cropType;

	// Use this for initialization

	void Awake ()
	{
		cam = Camera.main;
			//GameObject.Find ("pCam").GetComponent<Camera>();
	}

	void Start () 
	{
		

		plantManager = GameObject.Find ("plantManager").GetComponent<PlantingManager> ();
		inventory = GameObject.Find ("Inventory").GetComponent<CropInventory> ();
		pInventory = GameObject.Find ("player").GetComponent<playerInventory> ();
		rend = GetComponent<Renderer> ();
		rend.sharedMaterial = normalGround;
		spawnerName = gameObject.name;
		hoverColor = Color.blue;


	}
	
	// Update is called once per frame
	void Update () 
	{
		

		/*if (plantManager.isPlow != false)
		{
			
		if (Input.GetMouseButtonDown (0)) 
		{
			RaycastHit hit;
				Ray ray = cam.ScreenPointToRay(Input.mousePosition);

			if(Physics.Raycast (ray, out hit))
			{
				if(hit.transform.name == spawnerName)
				{
					print ("detectedraycast");
					Fertilize ();
					plantManager.isPlow = false;
				}
			}
		}

			Vector3 forward = transform.TransformDirection(Vector3.forward) * 1000;
			Debug.DrawRay(transform.position, forward, Color.green);
	}

*/

	}
	/*void OnMouseEnter()
	{
		{
		rend.material.color = hoverColor;
		} 
	}

	void OnMouseExit()
	{
		

	}
*/
	public void planting ()
	{
		if (plantManager.isPlow != false)
		{	
			Fertilize ();
			//plantManager.isPlow = false;


		}
			
		if (plantManager.isBerrySeed != false && cropReady != true && cropActive != true && isFertile != false && plantManager.waterReady != true)
		{
			pInventory.subtractBerry();
			seed = Instantiate (seedPrefab[0], transform.position, transform.rotation);
			StartCoroutine (GrowBerry ());
			plantManager.isBerrySeed = false;
		}

		if (plantManager.isCarrotSeed != false && cropReady != true && cropActive != true && isFertile != false && plantManager.waterReady != true)
		{
			pInventory.subtractCarrot();
			seed = Instantiate (seedPrefab[1], transform.position, transform.rotation);
			StartCoroutine (GrowCarrot ());
			plantManager.isCarrotSeed = false;
		}

		if (plantManager.isWeedSeed != false && cropReady != true && cropActive !=true  && isFertile != false && plantManager.waterReady != true)
		{
			pInventory.subtractWeed();
			seed = Instantiate (seedPrefab[2], transform.position, transform.rotation);
			StartCoroutine (GrowWeed ());
			plantManager.isWeedSeed = false;
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
			Destroy (weed3);
			print ("harvested!");
			inventory.locate (cropType);
			cropReady = false;
			GameObject harvestEffect = (GameObject)Instantiate(harvestParticle, transform.position, Quaternion.Euler (-90, 0, 0));
			Destroy(harvestEffect, 1f);
		}

		
	}

	IEnumerator GrowBerry ()
	{

		cropActive = true;
		growTime = Random.Range (minGrow, maxGrow);
		yield return new WaitForSeconds (growTime);
		Destroy (seed);
		weed1 = Instantiate (berryStages[0], transform.position, transform.rotation);
		yield return new WaitForSeconds (growTime);
		Destroy (weed1);
		weed2 = Instantiate (berryStages[1], transform.position, transform.rotation);
		yield return new WaitForSeconds (growTime);
		Destroy (weed2);
		weed3 = Instantiate (berryStages[2], transform.position, transform.rotation);
		cropReady = true;

	}

	IEnumerator GrowCarrot ()
	{
		
		cropActive = true;
		growTime = Random.Range (minGrow, maxGrow);
		yield return new WaitForSeconds (growTime);
		Destroy (seed);
		weed1 = Instantiate (carrotStages[0], transform.position, transform.rotation);
		yield return new WaitForSeconds (growTime);
		Destroy (weed1);
		weed2 = Instantiate (carrotStages[1], transform.position, transform.rotation);
		yield return new WaitForSeconds (growTime);
		Destroy (weed2);
		weed3 = Instantiate (carrotStages[2], transform.position, transform.rotation);
		cropReady = true;

	}

	IEnumerator GrowWeed ()
	{
		cropActive = true;
		growTime = Random.Range (minGrow, maxGrow);
		yield return new WaitForSeconds (growTime);
		Destroy (seed);
		weed1 = Instantiate (weedStages[0], transform.position, transform.rotation);
		yield return new WaitForSeconds (growTime);
		Destroy (weed1);
		weed2 = Instantiate (weedStages[1], transform.position, transform.rotation);
		yield return new WaitForSeconds (growTime);
		Destroy (weed2);
		weed3 = Instantiate (weedStages[2], transform.position, transform.rotation);
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
