using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cooking : MonoBehaviour {

	private Animator anim;
	public GameObject plate;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject.tag == "customer")
		{
			anim.SetBool ("isCooking", true);
			plate.SetActive (true);
		}
	}

	void OnTriggerExit (Collider other) 
	{
		if(other.gameObject.tag == "customer")
		{
			anim.SetBool ("isCooking", false);
			plate.SetActive (false);
		}
	}
}
