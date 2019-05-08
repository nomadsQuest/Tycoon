using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class carpoint: MonoBehaviour {

	public List<int> loc = new List<int> ();

	public int min;

	// Use this for initialization

	void Start ()
	{
		loc.Add (0);
		loc.Add (1);
		loc.Add (2);
		loc.Add (3);
		loc.Add (4);
	
	}
	// Update is called once per frame
	public void AddInt (int _carSpace) 
	{
		loc.Add (_carSpace);
	}

	public void RemoveInt (int _carSpace) 
	{
		loc.Remove (_carSpace);
	}

	void Update ()
	{
		loc.Sort ();

		min = loc [0];


	}


}
