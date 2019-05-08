using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
/*
public class testcustomer : MonoBehaviour {

	public float speed = 10;
	public float rotationSpeed = 10;

	private Transform target;
	private int wavepointIndex = 0;

	private NavMeshAgent agent;

	public bool eatingFinished;

	public int eatingTime = 10;

	public bool eatingCheck = false;




	// Use this for initialization
	void Start ()
	{
		target = wayPointParent.points [0];
		agent = GetComponent<NavMeshAgent> ();
		//anim = GetComponent<Animator> ();
	}

	void GetNextWaypoint()
	{
		wavepointIndex++;
		target = wayPointParent.points [wavepointIndex];

		if (wavepointIndex >= wayPointParent.points.Length)
		{
			Destroy (gameObject);
			return;
		}

	}

	void Update ()

	{

		print (wavepointIndex);
		agent.destination = target.position;

		if (agent.remainingDistance <= 0.8f && eatingCheck == true)
		{
			
			StartCoroutine (eating ());

		}

		if (agent.remainingDistance <= 0.4f && eatingCheck == false)
		{
			GetNextWaypoint ();
			eatingCheck = true;
		}



		transform.rotation = Quaternion.Slerp(transform.rotation,
			Quaternion.LookRotation(target.position - transform.position), rotationSpeed*Time.deltaTime);


	}

	IEnumerator eating()
	{
		agent.enabled = false;
		print ("isEating");
		yield return new WaitForSeconds (eatingTime);
		agent.enabled = true;
		eatingCheck = false;


		//eatingFinished = true;

	}

}
*/