using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carspawn : MonoBehaviour {

	public Transform carSpawnTransform;
	public GameObject[] car;
	public float waitTime;
	private bool coroutine;
	int randomCar;
	public bool noMoreSpace = false;
	private bool finishedWaiting;
	public parkingList list;
	public int minSpawn = 7;
	public int maxSpawn = 15;
	public int spawnLimit = 2;




	// Use this for initialization
	void Start ()
	{
		coroutine = true;
		//StartCoroutine (carSpawner ());
		list = GameObject.Find ("ParkingList").GetComponent<parkingList> ();
	

	
		
	}

	// Update is called once per frame
	void Update () 
	{
	/*	
		if (Input.GetKey ("c") && finishedWaiting == false)
		{
			finishedWaiting = true;
			StartCoroutine (carWait());
			Spawn ();
		}

*/
		//randomCar = Random.Range (0, car.Length);

		if (coroutine == true && noMoreSpace == false) {
			StartCoroutine (carSpawner ());
		} else
			print ("notspawning");
	


		if (list.spaces.Count <= spawnLimit)
		{
			print("nomorespace");
			noMoreSpace = true;
		}else
		{
			noMoreSpace = false;
		}
			

		//randomCar = Random.Range (0, car.Length);

	}

		

	private void Spawn()
	{
		
		Instantiate (car [randomCar], carSpawnTransform.position, carSpawnTransform.rotation);

	}




	public IEnumerator carSpawner ()
	{
		
		coroutine = false;
		waitTime = Random.Range (minSpawn, maxSpawn);
		yield return new WaitForSeconds (waitTime);
		Instantiate (car[randomCar], carSpawnTransform.position, carSpawnTransform.rotation);
		coroutine = true;
	}


	private IEnumerator carWait ()
	{
		yield return new WaitForSeconds (1f);
		finishedWaiting = false;


	}


}
