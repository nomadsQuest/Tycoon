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




	//for easy nav 
	/*
	public GameObject scriptObject;
	public scriptableTrigger trigger;
*/
	// Use this for initialization

	void Awake ()
	{

		navPoints.Add (0);
		navPoints.Add (1);
		navPoints.Add (2);
		navPoints.Add (3);
		navPoints.Add (4);
		navPoints.Add (5);



		randomNumber = Random.Range (navPoints[0], navPoints.Count - 2);
		currentIndex = randomNumber;
		wayPointParent = GameObject.Find ("Waypoints").GetComponent<waypoints> ();


		//anim.SetBool ("isActive", false);

		//scriptable objects


	}
	void Start () {
		
		visitAmount = Random.Range (0, 3);
		//target = waypoints.points [randomize];
		target = wayPointParent.points [randomNumber];
		agent = GetComponent<NavMeshAgent> ();
		// anim = GetComponent<Animator> ();

		money = GetComponent<currency> ();



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
		/**
		if (agent.isStopped != false)
		{
			Vector3 direction = (target.position - transform.position).normalized;
			Quaternion  qDir= Quaternion.LookRotation(direction);
			transform.rotation = Quaternion.Slerp(transform.rotation, qDir, Time.deltaTime * rotationSpeed);
		}
		*/


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
		randomNumber = Random.Range (navPoints[0], navPoints.Count - 2);

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


	//Waypoint Triggers
	public void ObjectTriggerArcade()

	{
		agent.isStopped = true;
		gameObject.GetComponent<Renderer> ().material.color = Color.red;
		if (isWaiting != true)
		{
			StartCoroutine (arcade ());
		}
	}

	public void ObjectTriggerTable()

	{
		agent.isStopped = true;
		gameObject.GetComponent<Renderer> ().material.color = Color.red;
		//anim.SetBool ("isJumping", true);
		if (isWaiting != true)
		{
			StartCoroutine (table ());
		}
	}

	public void ObjectTriggerTree()

	{
		agent.isStopped = true;
		gameObject.GetComponent<Renderer> ().material.color = Color.red;
		//anim.SetBool ("isJumping", true);
		if (isWaiting != true)
		{
			StartCoroutine (tree ());
		}
	}

	public void ObjectTriggerChair()

	{
		agent.isStopped = true;
		gameObject.GetComponent<Renderer> ().material.color = Color.red;
		//anim.SetBool ("isJumping", true);
		if (isWaiting != true)
		{
			StartCoroutine (chair ());
		}
	}

	/*
	public void ObjectTrigger(string _name)
	{
		agent.isStopped = true;
		gameObject.GetComponent<Renderer> ().material.color = Color.red;

		if (isWaiting != true)
		{
			StartCoroutine (_name ());
		}
	}
*/
	/*
	public void ScriptableTrigger()

	{
		agent.isStopped = true;
		//agent = null;
		gameObject.GetComponent<Renderer> ().material.color = Color.red;
		//anim.SetBool ("isJumping", true);
		if (isWaiting != true)
		{
			StartCoroutine (script ());

		}


		IEnumerator script()
	{
		isWaiting = true;
		print (objectName);
		
		yield return new WaitForSeconds (2);
	
		print ("arcadeFinished");
		GetNextWaypoint ();
		agent.isStopped = false;
		money.addMoney (10);
		//yield return new WaitForSeconds (3);

	}
*/

	IEnumerator arcade()
	{
		isWaiting = true;
		print ("arcadeWaiting");
		//anim.SetBool ("isAction", true);
		yield return new WaitForSeconds (1);
		//anim.SetBool ("isAction", false);
		print ("arcadeFinished");
		GetNextWaypoint ();
		agent.isStopped = false;
		money.addMoney (10);
		//yield return new WaitForSeconds (2);

	}

	IEnumerator table()
	{
		isWaiting = true;
		print ("tableWaiting");
		//agent.enabled = false;
		//anim.SetBool ("isAction", true);
		yield return new WaitForSeconds (1);
		//anim.SetBool ("isAction", false);
	//	agent.enabled = true;
		print ("tableFinished");
		GetNextWaypoint ();
		agent.isStopped = false;
		money.addMoney (30);
		//yield return new WaitForSeconds (2);

	}

	IEnumerator tree()
	{
		isWaiting = true;
		print ("treeWaiting");
		//anim.SetBool ("isAction", true);
		yield return new WaitForSeconds (1);
		//anim.SetBool ("isAction", false);
		print ("treeFinished");
		GetNextWaypoint ();
		agent.isStopped = false;
		money.addMoney (5);
		//yield return new WaitForSeconds (3);

	}

	IEnumerator chair()
	{
		isWaiting = true;
		print ("chairWaiting");
		//anim.SetBool ("isAction", true);
		yield return new WaitForSeconds (1);
		//anim.SetBool ("isAction", false);
		print ("chairFinished");
		GetNextWaypoint ();
		agent.isStopped = false;
		money.addMoney (10);
		//yield return new WaitForSeconds (3);

	}


	
}
