using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class findingparkinglot : MonoBehaviour {

	private NavMeshAgent agent;
	public Transform[] points;
	public int destPoint;
	public bool destinationDetected = false;
	public int parkingTimeSeconds;
	public List<int> pSpaces;
	public Transform parkingManager;


	// Use this for initialization
	void Start () 
	{
		
			
			
		agent = GetComponent<NavMeshAgent> ();
		GotoNextPoint ();
		pSpaces.Add (0);
		pSpaces.Add (1);
		pSpaces.Add (2);
	



	}
	
	// Update is called once per frame
	void Update () 
	{
		//print (pSpaces);
		if (!agent.pathPending && agent.remainingDistance < 0.5f)
		{
			
			parkingTime ();
		}

	}

	IEnumerator parkingTime ()
	{
		yield return new WaitForSeconds (parkingTimeSeconds);
		GotoNextPoint();
		destPoint++;

	}


	void GotoNextPoint () 
	{
		if (points.Length == 0)
			return;
		

		agent.destination = points [destPoint].position;

		//destPoint = (destPoint + 1) / points.Length;

	}

	public void AddToList (int trans)
	{

		pSpaces.Add (trans);


	}

	public void RemoveFromList (int trans)
	{

		pSpaces.Remove (trans);


	}

}
