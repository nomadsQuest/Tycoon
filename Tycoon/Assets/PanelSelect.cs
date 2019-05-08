using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSelect : MonoBehaviour {

	private GameObject chair;
	private GameObject table;
	// Use this for initialization
	void Start () 
	{
		chair = GameObject.Find ("ChairPanel");
		table = GameObject.Find ("TablePanel");

		chair.SetActive (false);
		table.SetActive (false);
	}

	void Update ()
	{
		if (Input.GetKeyDown("1"))
		{
			table.SetActive (true);
			chair.SetActive (false);
		}

		if (Input.GetKeyUp("1"))
		{
			table.SetActive (false);

		}


		if (Input.GetKeyDown("2"))
		{
			table.SetActive (false);
			chair.SetActive (true);
		}

		if (Input.GetKeyUp("2"))
		{
			chair.SetActive (false);

		}

	}

	public void OpenTablePanel () 

	{
		table.SetActive (true);
	}

	public void CloseTablePanel () 
	{
		table.SetActive (false);
	}

	public void OpenChairPanel () 
	{
		chair.SetActive (true);

	}

	public void CloseChairPanel () 
	{
		chair.SetActive (false);
	}
}
