using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class parkingList : MonoBehaviour {


	public List<int> spaces = new List<int> ();

	public int randomnumber;




	public int min;

	// Use this for initialization
	void Awake () 
	{
		
		spaces.Add (0);
		spaces.Add (1);
		spaces.Add (2);
		spaces.Add (3);
		spaces.Add (4);
		spaces.Add (5);

	

		//print (randomnumber);
	}



	public void AddToList (int trans)
	{

		spaces.Add (trans);


	}

	public void RemoveFromList (int trans)
	{

		spaces.Remove (trans);
	

	
	}
	// Update is called once per frame
	void Update () 
	{
		spaces.Sort ();

		min = spaces [0];

		spaces = spaces.Distinct ().ToList ();
	}
}
