using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubespawn : MonoBehaviour {
	
	public GameObject cube;


	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyUp ("s"))
		{
			Instantiate (cube, transform.position, transform.rotation);

		}
	}


}
