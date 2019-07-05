using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plow : MonoBehaviour {
	

	public Transform player;

	public bool isReady;

	public Text plowText;

	public PlantingManager plantManager;

	public float dist = 0;

	// Use this for initialization
	void Start () {
		
		player = GameObject.Find ("player").transform;
		plantManager = GameObject.Find ("plantManager").GetComponent<PlantingManager> ();
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		float dist = Vector3.Distance (player.position, transform.position);

		if (dist <= 5f)
		{
			isReady = true;
		}else
		{
			isReady = false;
		}

		if (isReady != false)
		{
			plowText.text = ("P");
			if (Input.GetKey (KeyCode.Y))
			{
				plantManager.ActivateWater ();	
			}
		}else{
			plowText.text = ("");
		}

	}
}
