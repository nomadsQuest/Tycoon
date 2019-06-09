using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class dtCar : MonoBehaviour {

	public DTcarSpawn spawn;
	public NavMeshAgent agent;
	public Transform order;
	public Transform exit;
	public float orderTime;
	private bool hasOrdered;

	// Use this for initialization
	void Start ()
	{
		spawn = GameObject.Find ("carSpawnDT").GetComponent<DTcarSpawn> ();
		agent.destination = order.position;
		orderTime = Random.Range (4, 5);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!agent.pathPending && agent.remainingDistance <= 0.2 && hasOrdered != true){
			StartCoroutine (OrderFood ());
			hasOrdered = true;

		}
	}

	IEnumerator OrderFood ()
	{
		
		yield return new WaitForSeconds (orderTime);
		spawn.isSpawn = false;
		agent.destination = exit.position;
	}
}
