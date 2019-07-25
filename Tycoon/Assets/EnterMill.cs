using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class EnterMill : MonoBehaviour {

	public Transform player;
	public Text EnterBuildingText;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.Find ("player").transform;
		EnterBuildingText.enabled = false;

	}
	
	// Update is called once per frame
	void Update () 
	{
		float dist = Vector3.Distance (transform.position, player.position);
		//print (dist);

		if (dist < 8f) 
		{
			EnterBuildingText.text = ("press E to Enter");
			EnterBuildingText.enabled = true;

			if (Input.GetKey ("g")) 
			{
				print ("Changing Level");


			}
		} else
		{
			EnterBuildingText.enabled = false;
		}
		
			
	}
}
