using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

	public static BuildManager instance;

	private GameObject itemToBuild;

	public GameObject item1Prefab;
	public GameObject item2Prefab;
	public GameObject item3Prefab;
	public GameObject item4Prefab;
	public GameObject item5Prefab;
	public GameObject item6Prefab;
	public GameObject item7Prefab;






	void Awake ()
	{


		if (instance != null)
		{
			print("More than one buildmanager in scene");
			return;
		}

		instance = this;
	}

	public GameObject getItemToBuild ()
	{
		return itemToBuild;
	}

	public void SetItemToBuild (GameObject item)

	{
		itemToBuild = item;
	}


	// Use this for initialization
	void Start () 
	{
		itemToBuild = null;
	}
	
	// Update is called once per frame
	public GameObject GetItemtoBuild ()
	{
		return itemToBuild;
	}




}
