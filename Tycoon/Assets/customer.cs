using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class customer : MonoBehaviour {



	private Transform target;


	private NavMeshAgent agent;

	private Animator anim;

	public bool eatingFinished;


	//Classes
	private PlayerResources resources;
	private food plate;

	//
	public float speed = 10;
	public float rotationSpeed = 10;

	//Int
	public int eatingTime = 5;
	//private int _money = 30;
	private int foodItemchosen;
	private int wavepointIndex = 0;


	//UI

	public Image bubble;
	public Image foodItem;
	public Sprite [] foodItems;


	public waypoints wayPoint;

	// Use this for initialization
	void Start ()
	{
		wayPoint = GameObject.Find ("customerwaypoints").GetComponent<waypoints> ();
		plate = GameObject.FindWithTag ("plate").GetComponent<food> ();
		target = wayPoint.points [0];
		agent = GetComponent<NavMeshAgent> ();
		anim = GetComponent<Animator> ();

		resources = GameObject.FindWithTag ("resource").GetComponent<PlayerResources> ();

		foodItemchosen = Random.Range (0, foodItems.Length);

		foodItem.sprite = foodItems[foodItemchosen];




	}

	void GetNextWaypoint()
	{
		wavepointIndex++;

		target = wayPoint.points [wavepointIndex];

		if (wavepointIndex >= wayPoint.points.Length)
		{
			Destroy (gameObject);
			return;
		}


	}



	void Update ()

	{

		agent.destination = target.position;

		if (!agent.pathPending && agent.remainingDistance <= 0.2f)
		{
				StartCoroutine (isEating());
				return;

		}

		transform.rotation = Quaternion.Slerp(transform.rotation,
			Quaternion.LookRotation(target.position - transform.position), rotationSpeed*Time.deltaTime);


	}
	IEnumerator isEating()
	{
		
		if (eatingFinished == false)
		{
			eatingFinished = true;
			addFood ();
			//print ("isEating");
			yield return new WaitForSeconds (eatingTime);
			bubble.enabled = false;
			foodItem.enabled = false;
			GetNextWaypoint ();
			//addMoney ();



		


		}

	}

	void addMoney()
	{
		
		//resources.AddMoney (_money);
	}

	void addFood()
	{
		plate.ChosenFoodItem (foodItemchosen);
	}


}
