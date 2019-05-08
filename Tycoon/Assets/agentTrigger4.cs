using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agentTrigger4 : MonoBehaviour {

	public navigate nav;
	public bool isActive;
	public string agentName = "Agent";
	// Use this for initialization
	void Start () 
	{
		nav = GameObject.Find (agentName).GetComponent<navigate> ();
	}


	void OnTriggerEnter (Collider other) 
	{
		if (other.gameObject.tag == "Player" && isActive != true)
		{
			isActive = true;
			nav.ObjectTriggerChair();
			//nav.anim.SetBool ("isAction", true);
		}
	}

	void OnTriggerExit () 
	{
		isActive = false;
		nav.isWaiting = false;
		//nav.anim.SetBool ("isAction", false);
	}
}
