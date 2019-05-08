using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listspawn : MonoBehaviour {


	public int rand;

	private int randString;

	public Transform child;

	public carpoint car;

	public string spot;

	public int order;



	// Use this for initialization



	void Start ()
	{


		car = GameObject.Find ("Parent").GetComponent<carpoint>();

		rand = Random.Range (car.min , car.loc.Count);

		order = car.min;

		if(!car.loc.Contains(rand)) 
		{
			print("doesnotcontain");
			rand = order;
			car.RemoveInt (order);
		}
		else 
			print("contains");
			car.RemoveInt(rand);


		//print (min);


		//randString = order + 1;
		randString = rand + 1;

		spot = ("") + randString;

		child = GameObject.Find ("Parent").transform.GetChild (rand);

		//child = GameObject.Find ("Parent").transform.GetChild (rand);
		//child = GameObject.Find ("Parent").transform.GetChild (order);
		//child = GameObject.Find ("Parent").transform.GetChild (order);
		//car.RemoveInt (order);
	}
	
	// Update is called once per frame
	void Update ()
	{

		this.transform.position = child.position;
		
		//this.transform.position = child.position;

		//add and subtract from list
		if (Input.GetKeyUp (spot))
		{
			car.AddInt(rand);
			//car.AddInt(order);
			Destroy (gameObject);
		}


	}
}
