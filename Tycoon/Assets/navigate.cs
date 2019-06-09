using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class navigate : MonoBehaviour {

	public float rotationSpeed = 15f;
	public NavMeshAgent agent;
	public Transform target;
	public bool isWaiting = false;
	public int waypointIndex = 0;

	public List<int> navPoints = new List<int> ();
	public int randomNumber;

	//public Animator anim;

	public currency money;

	public int currentIndex;

	public int visitAmount = 0;

	public waypoints wayPointParent;

	public bool repeatCheck;

	private int wait;

	private bool check;



	void Awake ()
	{

		navPoints.Add (0);
		navPoints.Add (1);
		navPoints.Add (2);
		navPoints.Add (3);
		navPoints.Add (4);
		navPoints.Add (5);



		randomNumber = Random.Range (navPoints[0], navPoints.Count - 1);
		currentIndex = randomNumber;
		wayPointParent = GameObject.Find ("Waypoints").GetComponent<waypoints> ();



	}
	void Start () {
		
		visitAmount = Random.Range (0, 2);
		//target = wayPointParent.points [randomNumber];
		agent = GetComponent<NavMeshAgent> ();
		money = GetComponent<currency> ();
		GetNextWaypoint ();



	}

	/*
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject)
		{
			print ("getting trigger");
			trigger = other.gameObject.GetComponent<scriptableTrigger>();
		}
	}
	*/
	// Update is called once per frame
	void Update () 
	{
		if (!agent.pathPending && agent.remainingDistance <= 0.2 && check != true)
		{
			check = true;
			StartCoroutine (waitTime ());
			wait = Random.Range (3, 5);
		}


		if (visitAmount >= 4)
		{
			target = wayPointParent.points [4];
		}

		if (isWaiting != true)
			gameObject.GetComponent<Renderer> ().material.color = Color.white;
		
		agent.destination = target.position;


	}
		
	void GetNextWaypoint ()
	{
		randomNumber = Random.Range (navPoints[0], navPoints.Count - 1);

		visitAmount += 1;

		if (currentIndex == randomNumber || currentIndex != 3)
		{
			randomNumber += 1;
			currentIndex = randomNumber;
			target = wayPointParent.points [randomNumber];
		}

		if (currentIndex == 3)
		{
			randomNumber -= 1;
			currentIndex = randomNumber;
			target = wayPointParent.points [randomNumber];
		}else
		{
			target = wayPointParent.points [randomNumber];
			currentIndex = randomNumber;
		}


		//waypointIndex++;
		//target = waypoints.points [waypointIndex];
	}

	IEnumerator waitTime ()
	{
		yield return new WaitForSeconds (wait);
		GetNextWaypoint ();
		check = false;
	}


}
