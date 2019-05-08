using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {

	public float Speed = 30f;
	// Use this for initialization

	// Update is called once per frame
	void Update () 
	{
		playerMovement ();
	}

	void playerMovement ()
	{
		float hor = Input.GetAxis ("Horizontal");
		float ver = Input.GetAxis ("Vertical");
		Vector3 playermove = new Vector3 (hor, 0f, ver) * Speed * Time.deltaTime;
		transform.Translate (playermove, Space.Self);
	}

}
