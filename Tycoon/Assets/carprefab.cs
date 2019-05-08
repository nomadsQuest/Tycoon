using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class carprefab : MonoBehaviour {

	private NavMeshAgent agent;
	public GameObject parkingParent;
	public Transform exit;
	public int randomParking;
	public int parkingTimeSeconds;
	public Transform lights;
	public Animator anim;
	public GameObject customer;
	public bool customerLimit = false;
	private parkingList carList;
	public Transform customerSpawnPoint;

	//sorted parking
	public Transform parking;
	public int rand;
	public int order;

	public bool carCheck = false;
	//private Random random = new Random();





	//public parkingList car;



	//public Transform[] openSpaces;

	//public List <int> parkingSpaceOpen = new List<int>();

	void Awake ()
	{
		
		parkingParent = GameObject.Find ("ParkingLocations");
		carList = GameObject.Find ("ParkingList").GetComponent<parkingList> ();


		//sorted parking
		order = carList.min;
		//customer = GameObject.Find("Man1");
	}

	// Use this for initialization
	void Start ()
	{

		//sorted parking
		rand = Random.Range (carList.min , carList.spaces.Count);

		order = carList.min;

		if(!carList.spaces.Contains(rand)) 
		{
			print("doesnotcontain");
			rand = order;
			carList.AddToList (order);
		
		}
		else 
		{
			print("contains");
			carList.RemoveFromList(rand);
		}

		parking = GameObject.Find ("ParkingLocations").transform.GetChild (rand);

		parkingTimeSeconds = Random.Range (10, 20);
		//parkingTimeSeconds = Random.Range (2, 8);

		//print(carList.parkingSpaces[index]);

		exit = parkingParent.transform.GetChild (6);


		//parking = parkingParent.transform.GetChild (carList.parkingSpaces.Count - 1);	


	
		lights = this.gameObject.transform.GetChild(0);

		anim = GetComponent<Animator> ();


		//parking = transform.Find ("parking").gameObject;
		//exit = transform.Find ("exit").gameObject;
		agent = GetComponent<NavMeshAgent> ();
		agent.destination = parking.position;



		gameObject.tag = "car";



	}
	
	// Update is called once per frame




	void Update () 
	{

		//print (carList.parkingSpaces.Count[0]);



		if (!agent.pathPending && agent.remainingDistance < 1.5f)
		{
			StartCoroutine (parkingTime ());
		}


	}
		
	IEnumerator parkingTime ()
	{
		if (carCheck != true)
		{
		carCheck = true;
		anim.SetBool ("isParked", true);
		lights.gameObject.SetActive (false);
		//SpawnPerson ();
		yield return new WaitForSeconds (parkingTimeSeconds);
		lights.gameObject.SetActive (true);
		agent.destination = exit.position;
		anim.SetBool ("isParked", false);
		carList.AddToList (rand);
		
		}

	}


	/*
	void SpawnPerson ()
	{
		if (customerLimit != true)
		{

			Instantiate (customer, customerSpawnPoint.position, customerSpawnPoint.rotation);

		customerLimit = true;
		}
	}

*/


}
