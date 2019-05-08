using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class animtest : MonoBehaviour {


	private Animator anim;
	private NavMeshAgent agent;

	public  AnimatorControllerParameter[] conditions;
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey ("t"))
		{
			anim.SetBool ("isArcade", false);
			anim.SetBool ("isTable", true);

		}

		if (Input.GetKey ("a"))
		{
			anim.SetBool ("isTable", false);
			anim.SetBool ("isArcade", true);
		}
	}
}
